using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myWidget
{
    class MyClock //задача класса давать точное время и вычислять положение стрелок на цифирблате
    {

        private PictureBox globalPic; //место где рисуем
        private Graphics g;           //объект рисования
        Pen blackPen = new Pen(Brushes.Black, 2);
        Pen redPen = new Pen(Brushes.Red);
        private int bias = 0; //смещение центра цифирблата

        /// <summary>
        /// Инициализация цифирблата
        /// </summary>
        /// <param name="pic">место где рисуем</param>
        /// <param name="bias">смещение центра</param>
        public MyClock(PictureBox pic, int bias = 75)
        {
            this.bias = bias; // стандартное смещение для центра цифирблата
            globalPic = pic;
            myInit();
        }

        /// <summary>
        /// переинициализация и повторная отрисовка
        /// </summary>
        public void myInit()
        {
            g = globalPic.CreateGraphics();
            g.FillEllipse(Brushes.White, 4, 4, 143, 143); // главный циферблат
            g.DrawEllipse(blackPen, 4, 4, 145, 145); // главный циферблат
            g.DrawEllipse(blackPen, 72, 2, 6, 6); //верх
            g.DrawEllipse(blackPen, 72, 144, 6, 6); //низ
            g.DrawEllipse(blackPen, 144, 72, 6, 6); //право
            g.DrawEllipse(blackPen, 2, 72, 6, 6); //лево
            g.DrawEllipse(blackPen, 74, 74, 2, 2);//точка
            draveNet();
        }

        private int[] getCurrentTime() //запаковать время в массив с интами
        {
            int[] ans = new int[3];
            ans[0] = (int)DateTime.Now.Hour;
            ans[1] = (int)DateTime.Now.Minute;
            ans[2] = (int)DateTime.Now.Second;
            return ans;
        }

        /// <summary>
        /// Отрисовать текущее время
        /// </summary>
        /// <param name="secClock">отрисовка секундной стрелки</param>
        public void draveTime(bool secClock = true)
        {
            int[] myTime = getCurrentTime();
            g.FillEllipse(Brushes.White, 10, 10, 131, 131);
            draveOnClock(blackPen, 40, 12, myTime[0]);
            draveOnClock(blackPen, 65, 60, myTime[1]);
            if (secClock == true)
                draveOnClock(redPen, 60, 60, myTime[2]);
        }

        //bias - смещение            //count шагов стрелки
        private void draveOnClock(Pen myPen, int lenArrow, int count, int actualPosition)
        {
            //стираем старую линию
            int lastPosition = actualPosition != 0 ? actualPosition - 1 : count; //выбираем место удаления старой стрелки
            int step = 360 / count;
            int stepActual = step * lastPosition;
            step = 360 / count;
            stepActual = step * actualPosition;
            int x = bias - (int)(lenArrow * Math.Cos(Math.PI * stepActual / 180));
            int y = bias + (int)(lenArrow * Math.Sin(Math.PI * stepActual / 180));
            g.DrawLine(myPen, 75, 75, y, x);
        }
        //дорисовать зазубринки для стрелок
        private void draveNet()
        {
            int stepActual = 0;
            int step = 360 / 60;
            for (int i = 0; i < (60); i++)
            {
                stepActual += step;
                int x = bias+1 + (int)((bias - 3) * Math.Sin(Math.PI * stepActual / 180));
                int y = bias+1 + (int)((bias - 3) * Math.Cos(Math.PI * stepActual / 180));
                int xx = bias+1 + (int)((bias) * Math.Sin(Math.PI * stepActual / 180));
                int yy = bias+1 + (int)((bias) * Math.Cos(Math.PI * stepActual / 180));
                g.DrawLine(redPen, y, x, yy, xx);
            }

            stepActual = 0;
            step = 360 / 12;
            for (int i = 0; i < (12); i++)
            {
                stepActual += step;
                int x = bias + 1 + (int)((bias - 7) * Math.Sin(Math.PI * stepActual / 180));
                int y = bias + 1 + (int)((bias - 7) * Math.Cos(Math.PI * stepActual / 180));
                int xx = bias + 1 + (int)((bias) * Math.Sin(Math.PI * stepActual / 180));
                int yy = bias + 1 + (int)((bias) * Math.Cos(Math.PI * stepActual / 180));
                g.DrawLine(blackPen, y, x, yy, xx);
            }
        }
    }
}
