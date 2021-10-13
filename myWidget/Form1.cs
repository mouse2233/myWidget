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
    public partial class Form1 : Form
    {
        MyClock testClock; //все для рисования часов
        Thread clockThread; //для цифирблата
        DateTime startTime; //время запуска
        bool menuVisible = false;
        public Form1()
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
        void uploadData()//ждет пока можно будет отправить данные о времени работы
        {
            //плюем запросом старую дату

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
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=myWidget;Integrated Security=True";
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
                var column1 = new DataGridViewColumn();
                column1.HeaderText = "поле1";
                column1.Name = "поле2";
                column1.CellTemplate = new DataGridViewTextBoxCell();

                var column2 = new DataGridViewColumn();
                column2.HeaderText = "поле1";
                column2.Name = "поле2";
                column2.CellTemplate = new DataGridViewTextBoxCell();

                var column3 = new DataGridViewColumn();
                column3.HeaderText = "поле1";
                column3.Name = "поле2";
                column3.CellTemplate = new DataGridViewTextBoxCell();

                var column4 = new DataGridViewColumn();
                column4.HeaderText = "поле1";
                column4.Name = "поле2";
                column4.CellTemplate = new DataGridViewTextBoxCell();

                var column5 = new DataGridViewColumn();
                column5.HeaderText = "поле1";
                column5.Name = "поле2";
                column5.CellTemplate = new DataGridViewTextBoxCell();

                var column6 = new DataGridViewColumn();
                column6.HeaderText = "поле1";
                column6.Name = "поле2";
                column6.CellTemplate = new DataGridViewTextBoxCell();

                dataGridView1.Columns.Add(column1);
                dataGridView1.Columns.Add(column2);
                dataGridView1.Columns.Add(column3);
                dataGridView1.Columns.Add(column4);
                dataGridView1.Columns.Add(column5);
                dataGridView1.Columns.Add(column6);
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {

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
