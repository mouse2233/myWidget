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
            checkBoxPoverh.Checked = !checkBoxPoverh.Checked; //но как вот это работает без делегата, ебать вопрос
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

                    string sqlExpression = String.Format("insert WorkTime(WorkTime.timeOn, WorkTime.timeOff) VALUES ('" + date1 + "', '" + date2 + "' )");
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        // добавление
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        int ans = command.ExecuteNonQuery();
                        if (ans != 1)
                        {
                            MessageBox.Show("Внимание, возникла ошибка записи данных в sql серсвер");
                        }
                    }
                    ok = 0;
                    hiddenAfterDelay(1000);
                    done = !done;
                    break;
                }
                catch
                {
                    ok -= 1; //отмерим 5 минут
                    Thread.Sleep(60000);
                }                
            }
            if (done)
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
            string sqlExpression = "select * from Tasks";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // создаем параметр для имени
                //                SqlParameter nameParam = new SqlParameter("@name", name);
                // добавляем параметр к команде
                //                command.Parameters.Add(nameParam);
                // создаем параметр для возраста
                //                SqlParameter ageParam = new SqlParameter("@age", age);
                // добавляем параметр к команде
                //                command.Parameters.Add(ageParam);
                SqlDataReader number = command.ExecuteReader();
                //                Console.WriteLine("Добавлено объектов: {0}", number); // 1
                


                List<string[]> data = new List<string[]>();
                while (number.Read())
                {
                    data.Add(new string[6]);

                    data[data.Count - 1][0] = number[0].ToString();
                    data[data.Count - 1][1] = number[1].ToString();
                    data[data.Count - 1][2] = number[2].ToString();
                    data[data.Count - 1][3] = number[3].ToString();
                    data[data.Count - 1][4] = number[4].ToString();
                    data[data.Count - 1][5] = number[5].ToString();
                }
                connection.Close();
                number.Close();


                dataGridView1.Columns.Add("", "");

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            string sqlExpression = "select * from Tasks";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // создаем параметр для имени
                //                SqlParameter nameParam = new SqlParameter("@name", name);
                // добавляем параметр к команде
                //                command.Parameters.Add(nameParam);
                // создаем параметр для возраста
                //                SqlParameter ageParam = new SqlParameter("@age", age);
                // добавляем параметр к команде
                //                command.Parameters.Add(ageParam);
                SqlDataReader number = command.ExecuteReader();
                //                Console.WriteLine("Добавлено объектов: {0}", number); // 1

                for (int i = 0; i < number.FieldCount; i++)
                {
                    DataGridViewColumn column1 = new DataGridViewColumn();
                    column1.HeaderText = number.GetName(i); //текст в шапке
                    column1.Width = 100; //ширина колонки
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
                    number[4].ToString(),
                    number[5].ToString()
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
             // создадим таблицу вывода товаров с колонками
             //Название, Цена, Остаток

            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Название"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.ReadOnly = true; //значение в этой колонке нельзя править
            column1.Name = "name"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Цена";
            column2.Name = "price";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Остаток";
            column3.Name = "count";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);

            dataGridView1.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки

            for (int i = 0; i < 5; ++i)
            {
                //Добавляем строку, указывая значения колонок поочереди слева направо
                dataGridView1.Rows.Add("Пример 1, Товар " + i, i * 1000, i);
            }

            for (int i = 0; i < 5; ++i)
            {
                //Добавляем строку, указывая значения каждой ячейки по имени (можно использовать индекс 0, 1, 2 вместо имен)
                dataGridView1.Rows.Add();
                dataGridView1["name", dataGridView1.Rows.Count - 1].Value = "Пример 2, Товар " + i;
                dataGridView1["price", dataGridView1.Rows.Count - 1].Value = i * 1000;
                dataGridView1["count", dataGridView1.Rows.Count - 1].Value = i;
            }

            //А теперь простой пройдемся циклом по всем ячейкам
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; ++j)
                {
                    //Значения ячеек хряняться в типе object
                    //это позволяет хранить любые данные в таблице
                    object o = dataGridView1[j, i].Value;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formSettings = new Form();
            formSettings.Show();
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
            TopMost = checkBoxPoverh.Checked;
        }

        private void visible(bool type)
        {
            if (type)
            {
                this.Width = 1160;
                this.Height = 190;
            }
            else
            {
                this.Width = 190;
                this.Height = 190;
            }
            panelTask.Visible = type;
            panelSetting.Visible = type;
            panelLoadData.Visible = type;
            TopMost = checkBoxPoverh.Checked;
        }
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            menuVisible = !menuVisible;
            visible(menuVisible);
        }
    }
}
