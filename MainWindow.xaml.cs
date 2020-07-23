using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModoLabs
{
    /// <summary>
    /// Project which gets the input from the user for the weather report.
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void check_Click(object sender, RoutedEventArgs e)
        {
           string api_key = "e17f24790498ee4d3fcd1f3831ff6d5b";
            //string base_url = "http://api.openweathermap.org/data/2.5/weather?";
            Console.WriteLine("What is the country Code and ZipCode ");
            string CountryCode = CountryName.Text;
            string CName = CityName.Text;
             //string complete_url = base_url + "appid=" + api_key + "&q=" + city_name;
            getWeather(CName, CountryCode, api_key);

        }
        void getWeather(string CName, string CountryCode, string api_key)
        {
            using (WebClient web = new WebClient())
            {
                //open weather map api gives the required data with the input data.
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0},{1}&appid={2}", CName,CountryCode,api_key);
                // the url is converted into json.
                var json = web.DownloadString(url);
                // The results are saved in output.
                var result = JsonConvert.DeserializeObject<weatherInformation.root>(json);
                weatherInformation.root output = result;
                //The required parameters are output to the UI
                DisplayCityName.Text = string.Format("{0}",output.name);
                DisplayCountryName.Text = string.Format( "{0}",output.sys.country);
                DisplayTemperature.Text = string.Format( "{0} \u00B0"+"C",output.main.temp);
                feels_like.Text = string.Format("{0}", output.main.feels_Like);
                temp_min.Text = string.Format("{0}", output.main.temp_min);
                temp_max.Text = string.Format("{0}", output.main.temp_max);
                Pressure.Text = string.Format("{0}", output.main.pressure);
                Humidity.Text = string.Format("{0}", output.main.humidity);
                Visibility.Text = string.Format("{0}", output.main.visibility);

    }
        }
    }
}
 