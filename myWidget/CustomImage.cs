using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myWidget
{
    /// <summary>
    /// Класс работы с кастомными картинками загруженными в ресурсы
    /// </summary>
    class CustomImage
    {
        /// <summary>
        /// отдает картинку по имени
        /// </summary>
        /// <param name="nameImage"> имя картинки</param>
        /// <returns></returns>
        public Image getImage(string nameImage)
        {
            Image image;
            switch (nameImage)
            {
                case "01d":
                    image = Properties.Resources._01d_2x;
                    break;
                case "01n":
                    image = Properties.Resources._01n_2x;
                    break;
                case "02d":
                    image = Properties.Resources._02d_2x;
                    break;
                case "02n":
                    image = Properties.Resources._02n_2x;
                    break;
                case "03d":
                    image = Properties.Resources._03d_2x;
                    break;
                case "03n":
                    image = Properties.Resources._03n_2x;
                    break;
                case "04d":
                    image = Properties.Resources._04d_2x;
                    break;
                case "04n":
                    image = Properties.Resources._04n_2x;
                    break;
                case "09n":
                    image = Properties.Resources._09d_2x;
                    break;
                case "09d":
                    image = Properties.Resources._09n_2x;
                    break;
                case "10d":
                    image = Properties.Resources._10d_2x;
                    break;
                case "10n":
                    image = Properties.Resources._10n_2x;
                    break;
                case "11d":
                    image = Properties.Resources._11d_2x;
                    break;
                case "11n":
                    image = Properties.Resources._11n_2x;
                    break;
                case "13d":
                    image = Properties.Resources._13d_2x;
                    break;
                case "13n":
                    image = Properties.Resources._13n_2x;
                    break;
                case "50d":
                    image = Properties.Resources._50d_2x;
                    break;
                case "50n":
                    image = Properties.Resources._50n_2x;
                    break;
                default:
                    image = Properties.Resources._default;
                    break;
            }
            return image;
        }

        /// <summary>
        /// соединяет картинки
        /// </summary>
        /// <param name="imageFirst">первая (левая) картинка</param>
        /// <param name="imageSecond">вторая (правая) картинка</param>
        /// <param name="left">смещение в лево (наложение)</param>
        /// <param name="high">смещение в низ (наложение)</param>
        /// <returns></returns>
        public Image connectImage(Image imageFirst, Image imageSecond, int left = 0, int high = 0)
        {
            Bitmap res = new Bitmap(Math.Max(imageFirst.Width, imageSecond.Width), Math.Max(imageFirst.Height, imageSecond.Height) * 2);

            Graphics g = Graphics.FromImage(res);
            g.DrawImage(imageFirst, 0, 0);
            g.DrawImage(imageSecond, imageFirst.Height - left, 0 - high);

            return res;
        }
    }
}
