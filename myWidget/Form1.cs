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

namespace myWidget
{
    public partial class Form1 : Form
    {
        MyClock testClock; //все для рисования часов
        Thread clockThread; //для цифирблата
        DateTime startTime; //время запуска
        public Form1()
        {
            InitializeComponent();
            TopMost = true;
            this.TransparencyKey = this.BackColor;
            this.FormBorderStyle = FormBorderStyle.None; //настройка формы без рамки
            dateLabel.Text = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
            startTime = DateTime.Now;
        }
        void uploadData()//ждет пока можно будет отправить данные о времени работы
        {

        }
        void drawClock()
        {
            while (true)
            {
                testClock.draveTime();
                Thread.Sleep(500);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            testClock = new MyClock(pictureBox1);
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            testClock.draveTime();
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
            clockThread = new Thread(drawClock);
            clockThread.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (clockThread is null)
            {

            }
            else
            {
                if (clockThread.IsAlive)
                    clockThread.Abort();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DateTime stopTime = DateTime.Now; //время запуска
            StreamWriter f = new StreamWriter("D:/tempTime.txt");
            f.WriteLine(startTime);
            f.WriteLine(stopTime);
            f.Close();
        }
    }
}
