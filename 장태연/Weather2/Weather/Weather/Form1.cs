using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
    public partial class Form1 : Form
    {
        public string api_key = "c02b275b3821812edd753f1fe03f1d18";

        public string name;
        public double lat;
        public double lon;
        public double lat2;
        public double lon2;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void findlocation(string words)
        {
            using (WebClient wc = new WebClient())
            {

                string locationuri = $"http://api.openweathermap.org/geo/1.0/direct?q={words}&limit=5&appid=";
                wc.Encoding = Encoding.UTF8;
                var json = wc.DownloadString(locationuri + api_key);
                var jArray = JArray.Parse(json);

                textBox1.Text = jArray[0]["lat"].ToString();
                textBox2.Text = jArray[0]["lon"].ToString();
                name = jArray[0]["name"].ToString();    
            }
        }
        

        private void button2_Click(object sender, EventArgs e) {

                using (WebClient wc = new WebClient())
                {
                    
                    double.TryParse(textBox1.Text, out lat2);
                    double.TryParse(textBox2.Text, out lon2);
                    string weatheruri = $"https://api.openweathermap.org/data/2.5/weather?lat={lat2}&lon={lon2}&appid=";
                    var json = wc.DownloadString(weatheruri+api_key);
                    var jArray = JObject.Parse(json);

                    string o = jArray["main"]["temp"].ToString();
                    //200~
                    double apitemp;
                    double diftemp = 273.15;
                    double.TryParse(o, out apitemp);
                    double dtemp = apitemp - diftemp;
                    string temp = Math.Floor(dtemp).ToString();
                    string Sweather = "";

                    if (jArray["weather"][0]["main"].ToString() == ("Thunderstorm"))
                        Sweather = "번개";
                     else if (jArray["weather"][0]["main"].ToString() == ("Drizzle"))
                        Sweather = "이슬비";
                    else if (jArray["weather"][0]["main"].ToString() == ("Rain"))
                        Sweather = "비";
                    else if (jArray["weather"][0]["main"].ToString() == ("Snow"))
                        Sweather = "눈";
                    else if (jArray["weather"][0]["main"].ToString() == ("Clear"))
                        Sweather = "맑음";
                    else if (jArray["weather"][0]["main"].ToString() == ("Clouds"))
                        Sweather = "구름";

                    richTextBox1.Text = $"{name}의 정보\r\n"+$"위도{lat2}, 경도{lon2}\r\n" + "날씨 : " + Sweather + "\r\n"+ "온도 : " + temp;

                }
            }

        private void button3_Click(object sender, EventArgs e)
        {

            //api는 있으나 시간마다 있어서 데이터 가공이 필요함..
            //json 줄이 길때 크롬 json viewer 편함
            /*
            string myuri = "https://api.openweathermap.org/data/2.5/forecast?lat=36.0189315&lon=129.3429384&appid=c02b275b3821812edd753f1fe03f1d18";
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(myuri);
                var jArray = JObject.Parse(json);

                richTextBox1.Text = jArray.ToString();
           
            } */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            findlocation("pohang");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            findlocation("daegu");


        }
    }
}
