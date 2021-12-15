using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace myWidget
{
    /*первый раз получаем погоду на неделю одновременно заполняем погоду на день*/

    /// <summary>
    /// класс для работы с погодой с сайта
    /// </summary>
    class Weather
    {
        private string locationApiKey = @"D:\apiKey.txt";
        public string status = "no init";
        private string apiKey = "";

        private Dictionary <string, string> currentWeather; //актуальная погода

        public delegate void informerEvent(string message); //делегат для события ошибки
        public event informerEvent SayError;

        public delegate void takeData();
        public event takeData TakeNewData;//покажем что можно брать

        private bool loopWeather = true;
        public Weather()
        {
            currentWeather = new Dictionary<string, string>();
            //часть 1 попробуем получить api key ибо печатать его в коде не очень хорошо т.к. все это выкладывается на гит
            try
            {
                using (FileStream fstream = File.OpenRead(locationApiKey))
                {
                    StreamReader reader = new StreamReader(fstream); // создаем «потоковый
                    apiKey = reader.ReadLine();
                }
            }
            catch
            {
                SayError?.Invoke("error 1, file api key not found!");
                status = "error 1, file api key not found!";
            }
            GetActualWeather();
        }
        /// <summary>
        /// получить актуальную информацию
        /// </summary>
        public void GetActualWeather()
        {
            try
            {
                WebRequest request = WebRequest.Create(@"http://api.openweathermap.org/data/2.5/weather?id=" + "520555" /*Nizhniy Novgorod*/ + @"&appid=" + apiKey + "&units=metric" + "&mode=xml&lang=ru");
                WebResponse response = request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string line = "";
                        line = reader.ReadToEnd();
                        Console.WriteLine(line);
                        xmlPars(line);
                    }
                }
                response.Close();
                Console.WriteLine("Запрос выполнен");
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine("Отвал короче " + e.Message);
                SayError?.Invoke("error 2, internet modul " + e.Message);
                status = "error 2, internet modul " + e.Message;
            }
        }

        /// <summary>
        /// получает информацию в цикле, каждый заданный интервал
        /// </summary>
        /// <param name="delay">задержка в минутах</param>
        public void GetActualWeatherLoop(int delay)
        {
            loopWeather = true;
            Task task = new Task(() =>
            {
                while (loopWeather)
                {
                    //Console.WriteLine("Hello Task!");
                    GetActualWeather();
                    TakeNewData?.Invoke();
                    Thread.Sleep(delay * 1000 * 60);
                }
            });
            task.Start();
            //Console.WriteLine("stop Task!");
        }

        public void StopGetActualWeatherLoop()
        {
            loopWeather = false;
        }

        /// <summary>
        /// отдает загруженный словарь данных
        /// </summary>
        /// <returns></returns>
        public Dictionary <string, string> getLoadData()
        {
            return currentWeather;
        }
        void xmlPars(string xml)
        {
            currentWeather.Clear();
            XmlDocument xDoc = new XmlDocument();
            xDoc.LoadXml(xml);
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                // обход всех узлов в корневом элементе
                foreach (XmlElement xnode in xRoot)
                {
                    // получаем значение атрибута
                    //Console.WriteLine(xnode.Name);
                    switch (xnode.Name)
                    {
                        case "temperature":
                            currentWeather.Add("temperature", xnode.Attributes.GetNamedItem("value").Value);
                            //Console.WriteLine("t " + xnode.Attributes.GetNamedItem("value").Value);
                            break;
                        case "feels_like":
                            currentWeather.Add("feels_like", xnode.Attributes.GetNamedItem("value").Value);
                            //Console.WriteLine("fell " + xnode.Attributes.GetNamedItem("value").Value);
                            break;
                        case "humidity":
                            currentWeather.Add("humidity", xnode.Attributes.GetNamedItem("value").Value);
                            //Console.WriteLine("hidr " + xnode.Attributes.GetNamedItem("value").Value);
                            break;
                        case "pressure":
                            currentWeather.Add("pressure", xnode.Attributes.GetNamedItem("value").Value);
                            //Console.WriteLine("press " + xnode.Attributes.GetNamedItem("value").Value);
                            break;
                        case "wind":
                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                if (childnode.Name == "speed")
                                {
                                    currentWeather.Add("wind_speed", childnode.Attributes.GetNamedItem("value").Value);
                                    //Console.WriteLine("wind " + childnode.Attributes.GetNamedItem("value").Value);
                                    break;
                                }
                            }
                            break;
                        case "weather":
                            currentWeather.Add("icon", xnode.Attributes.GetNamedItem("icon").Value);
                            //Console.WriteLine("weather " + xnode.Attributes.GetNamedItem("icon").Value);
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// получает погогду на неделю и одновременно на день
        /// </summary>
        public void GetWeekWeather()
        {
            try
            {
                WebRequest request = WebRequest.Create(@"https://api.openweathermap.org/data/2.5/forecast/?id=" + "520555" /*Nizhniy Novgorod*/ + @"&appid=" + apiKey + "&cnt=7&units=metric" + "&mode=xml&lang=ru");
                WebResponse response = request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string line = "";
                        line = reader.ReadToEnd();
                        Console.WriteLine(line);
                        //xmlPars(line);
                        //разобьем пожалуй на 
                    }
                }
                response.Close();
                Console.WriteLine("Запрос выполнен");
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine("Отвал короче " + e.Message);
                SayError?.Invoke("error 2, internet modul " + e.Message);
                status = "error 2, internet modul " + e.Message;
            }
        }
    }
}
