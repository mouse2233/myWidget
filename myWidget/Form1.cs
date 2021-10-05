using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myWidget
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void drawClock(PictureBox pic)
        {
            //0    75   149
            //
            //75
            //
            //149

            Graphics g = pic.CreateGraphics();
            Pen blackPen = new Pen(Brushes.Black, 2);
            Pen redPen = new Pen(Brushes.Red);

            g.DrawEllipse(blackPen, 4, 4, 144, 144); // главный циферблат
            g.DrawEllipse(blackPen, 72, 2, 6, 6); //верх
            g.DrawEllipse(blackPen, 72, 144, 6, 6); //низ
            g.DrawEllipse(blackPen, 144, 72, 6, 6); //право
            g.DrawEllipse(blackPen, 2, 72, 6, 6); //лево
            //g.DrawLine(redPen, 75, 0, 75, 150);//верт
            //g.DrawLine(redPen, 0, 75, 150, 75);//гори
            g.DrawEllipse(blackPen, 74, 74, 2, 2);//точка

            int pos = 0;
            // берем по 30 градусов
            for (int i = 0; i < 12; i++)
            {
                pos += 30;
                int x = (int) ((Math.Sin(Math.PI * pos) * 150)+75)/180;
                int y = (int)((Math.Cos(Math.PI * pos) * 150) + 75) / 180;
                g.DrawLine(redPen, 75, 75, y, x);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None; //настройка формы без рамки
            drawClock(pictureBox1);
            //this.FormBorderStyle = FormBorderStyle.None;
            /*
            for (int i = 1; i < 10000; i++)
            {
                g.DrawLine(new Pen(Brushes.White, 4), new Point(10, 10), new Point(100, i-1));
                g.DrawLine(new Pen(Brushes.Red, 4), new Point(10, 10), new Point(100, i));
            }
            for (int i = 10000; i > 1; i--)
            {
                g.DrawLine(new Pen(Brushes.White, 4), new Point(10, 10), new Point(100, i + 1));
                g.DrawLine(new Pen(Brushes.Red, 4), new Point(10, 10), new Point(100, i));
            }
            */
            //pictureBox1.Image = null;
            //g.Dispose();
            //this.FormBorderStyle = FormBorderStyle.Sizable;
        }
    }
}
