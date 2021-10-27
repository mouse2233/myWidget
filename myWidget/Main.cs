using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Data.SqlClient;

namespace myWidget
{
    public partial class Main : Form
    {
        MyClock testClock; //все для рисования часов
        Thread clockThread; //для цифирблата
        DateTime startTime; //время запуска
        bool menuVisible = false;
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=myWidget;Integrated Security=True";

        public Main()
        {
            InitializeComponent();
            this.TransparencyKey = this.BackColor;
            this.FormBorderStyle = FormBorderStyle.None; //настройка формы без рамки
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
        visible(menuVisible);
        dateLabel.Text = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
            startTime = DateTime.Now;
            dateLabel.BackColor = Color.White;
            testClock = new MyClock(pictureBox1); //init часов
            clockThread = new Thread(drawClock); //инит потока часов
            clockThread.Start(); //старт потока часов
            Thread SQLThread = new Thread(uploadData); //создаем поток и пробуем подключиться к бд
            SQLThread.Start();
        }
        /// <summary>
        /// Нужно передать время задержки, но до этого запустить в отдельном потоке
        /// </summary>
        /// <param name="time"> время задержки</param>
        void hiddenAfterDelay(int time)
        {
            //Ебать тут гемор с делегатами
            Action action = () => TopMost = false;
            if (InvokeRequired)
                Invoke(action);
            else
                action();
            //checkBoxPoverh.Checked = !checkBoxPoverh.Checked; //но как вот это работает без делегата, ебать вопрос
        }
        void uploadData()//ждет пока можно будет отправить данные о времени работы
        {
            //плюем запросом старую дату
            bool done = false;
            int ok = 5;
            while (ok > 0)
            {
                try
                {
                    StreamReader t = new StreamReader("D:/tempTime.txt");
                    string date1 = t.ReadLine();
                    string date2 = t.ReadLine();
                    t.Close();
                    t.Dispose();
                    string sqlExpression = String.Format("insert WorkTime(WorkTime.timeOn, WorkTime.timeOff) VALUES ('" + date1 + "', '" + date2 + "' )");
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        // добавление
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        int ans = command.ExecuteNonQuery();
                        if (ans != 1 && ok > 0)
                        {
                            MessageBox.Show("Внимание, возникла ошибка записи данных в sql серсвер");
                        }
                    }
                    ok = 0;
                    hiddenAfterDelay(1000);
                    done = true;
                    break;
                }
                catch
                {
                    ok -= 1; //отмерим 5 минут
                    Thread.Sleep(60000);
                }                
            }
            if (!done)
                MessageBox.Show("Внимание, возникла ошибка записи данных в sql серсвер и закончились попытки переподключений");
            //и завершаем поток
        }

        void drawClock()
        {
            Thread.Sleep(500);
            testClock.myInit();
            while (true)
            {
                testClock.draveTime();
                Thread.Sleep(500);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string sqlExpression = "хп_ЗаписатьЗадачи '" + пЗадача.Text + "', '" + datePicker.Value.ToShortDateString().Replace('.', '/') + "', '" + TimePicker.Value.ToShortTimeString() + "'";
            /*
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader number = command.ExecuteReader();
                connection.Close();
                number.Close();
            }
            */
            //panelLoadData.Visible = false;
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            string sqlExpression = "exec хп_получитьЗадачи";
            if (checkGetChecket.Checked)
                sqlExpression += " @Выполненные = 1";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader number = command.ExecuteReader();
                for (int i = 0; i < number.FieldCount; i++)
                {
                    DataGridViewColumn column1 = new DataGridViewColumn();
                    column1.HeaderText = number.GetName(i); //текст в шапке
                    switch (number.GetName(i))
                    {
                        case ("id"):
                            column1.Width = 20; //ширина колонки
                            break;
                        case ("taskName"):
                            column1.Width = 300; //ширина колонки
                            break;
                        case ("taskStatus"):
                            column1.Width = 50; //ширина колонки
                            break;
                        case ("taskDate"):
                            column1.Width = 100; //ширина колонки
                            break;
                        case ("taskTime"):
                            column1.Width = 100; //ширина колонки
                            break;                            
                        default:
                            column1.Width = 100; //ширина колонки
                            break;
                    }


                    //column1.Width = 100; //ширина колонки
                    column1.ReadOnly = true; //значение в этой колонке нельзя править
                    column1.Name = number.GetName(i); //текстовое имя колонки, его можно использовать вместо обращений по индексу
                    column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
                    if (number.GetName(i) == "taskStatus")
                        column1.CellTemplate = new DataGridViewCheckBoxCell(); //тип нашей колонки
                    if (number.GetName(i) != "taskStatus")
                        column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
                    dataGridView1.Columns.Add(column1);
                }
                dataGridView1.AllowUserToAddRows = false;
                List<string[]> data = new List<string[]>();
                while (number.Read())
                {
                    dataGridView1.Rows.Add(number[0].ToString(),
                    number[1].ToString(),
                    number[2].ToString(),
                    number[3].ToString(),
                    number[4].ToString()
                    );                    
                }                
                connection.Close();
                number.Close();
            }
        }

        private bool moveForm = false;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            moveForm = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveForm)
            {
                Location = new Point(Cursor.Position.X - 75, Cursor.Position.Y - 75);
            }            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            moveForm = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string sqlExpression = "хп_УдалитьЗадачу ";
                sqlExpression += row.Cells[0].Value.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader number = command.ExecuteReader();
                    connection.Close();
                    number.Close();
                }

            }
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formSettings = new Settings();
            formSettings.Show();
            //panelSetting.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (clockThread is null)
            {

            }
            else
            {
                if (clockThread.IsAlive)
                    clockThread.Abort();
            }
            this.Close();
            this.Dispose();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (clockThread is null)
            {

            }
            else
            {
                if (clockThread.IsAlive)
                    clockThread.Abort();
            }
            DateTime stopTime = DateTime.Now; //время запуска
            StreamWriter f = new StreamWriter("D:/tempTime.txt");
            f.WriteLine(startTime);
            f.WriteLine(stopTime);
            f.Close();
        }

        private void checkBoxPoverh_CheckedChanged(object sender, EventArgs e)
        {
            //TopMost = checkBoxPoverh.Checked;
        }

        private void visible(bool type)
        {
            if (type)
            {
                this.Width = 1080;
                this.Height = 400;
            }
            else
            {
                this.Width = 190;
                this.Height = 190;
            }
            panelTask.Visible = type;
            //panelSetting.Visible = type;
            //panelLoadData.Visible = type;
            //TopMost = checkBoxPoverh.Checked;
        }
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            menuVisible = !menuVisible;
            visible(menuVisible);
        }

        private void кнНовоеЗадание_Click(object sender, EventArgs e)
        {
            Form addDB = new ДобавитьЗапись();
            addDB.Show();
        }

        private void writeTask_Click(object sender, EventArgs e)
        {
            //выставлять дату да нет
            //string sqlExpression = "хп_ЗаписатьЗадачи '" + пЗадача.Text + "', '" + datePicker.Value.ToShortDateString().Replace('.', '/') + "', '" + TimePicker.Value.ToShortTimeString() + "'";
            /*
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader number = command.ExecuteReader();
                connection.Close();
                number.Close();
            }
            */
            //panelLoadData.Visible = false;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            //panelLoadData.Visible = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            //panelSetting.Visible = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string sqlExpression = "хп_ОбновитьЗадачу ";
                sqlExpression += row.Cells[0].Value.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader number = command.ExecuteReader();
                    connection.Close();
                    number.Close();
                }

            }
            buttonTest_Click(null, null);
        }
    }
}
