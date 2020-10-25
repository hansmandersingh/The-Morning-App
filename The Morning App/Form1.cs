using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using UserInfoPopup;
using System.IO;

namespace The_Morning_App
{
    public partial class The_Morning_App : Form
    {

        private HttpClient client = new HttpClient();
        private static readonly string StartupKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        private static readonly string StartupValue = "The Morning App";
        public The_Morning_App()
        {
            InitializeComponent();
        }

        private void The_Morning_App_Load(object sender, EventArgs e)
        {
            SetStartup();
            SetUserInfo();
            GetData();
        }

        private void SetUserInfo()
        {
            string filePath = "C:\\Users\\Public\\Documents\\UserInfo.bin";

            if (File.Exists(filePath))
            {
                var deSerializedJson = JsonConvert.DeserializeObject<UserInfo>(File.ReadAllText(filePath));

                Title_label.Text = $"Hello {deSerializedJson.First_Name} {deSerializedJson.Last_Name}";
            } else
            {
                User_Info_Popup user_Info_Popup = new User_Info_Popup();
                user_Info_Popup.ShowDialog(this);

                
                var deSerializedJson = JsonConvert.DeserializeObject<UserInfo>(File.ReadAllText(filePath));

                Title_label.Text = $"Hello {deSerializedJson.First_Name} {deSerializedJson.Last_Name}";
            }
        }
        private void GetData()
        {
            HttpResponseMessage locationResponse = client.GetAsync("https://api.ipdata.co?api-key=f87ae1ac7ca66c29591b64c7d192a1b5a74b5b7a1b784e6dc427b3cb").Result;

            if (locationResponse.IsSuccessStatusCode)
            {
                var responseResult = locationResponse.Content.ReadAsStringAsync().Result;

                var data = JsonConvert.DeserializeObject<LocationApi>(responseResult);

                city_fill_label.Text = data.city;
                province_fill_label.Text = data.region;
                country_fill_label.Text = data.country_name;
                ip_Add_fill_label.Text = data.ip;

                GetWeatherData(data);
            }else
            {
                FetchError();
            }
        }

        private void GetWeatherData(LocationApi data)
        {
            HttpResponseMessage weatherResponse = client.GetAsync($"http://api.openweathermap.org/data/2.5/weather?q={data.city}&units=metric&appid=8bbeb96ca9da3d8c0e36ba3d48803fd5").Result;

            if (weatherResponse.IsSuccessStatusCode)
            {
                var weatherResponseResult = weatherResponse.Content.ReadAsStringAsync().Result;

                var weatherData = JsonConvert.DeserializeObject<WeatherApi>(weatherResponseResult);

                temp_now_fill_label.Text = weatherData.Main.temp.ToString() + " °C";

                GetCurrencyData(data);
            } else
            {
                FetchError();
            }
        }

        private void GetCurrencyData(LocationApi data)
        {
            HttpResponseMessage currencyResponse = client.GetAsync($"https://api.exchangeratesapi.io/latest?base={data.Currency.code}").Result;

            if (currencyResponse.IsSuccessStatusCode)
            {
                var currencyResponseResult = currencyResponse.Content.ReadAsStringAsync().Result;

                var currencyData = JsonConvert.DeserializeObject<CurrencyApi>(currencyResponseResult);

                currency_fill_label.Text = $"1 {data.Currency.code} = {currencyData.Rates.USD} USD";
            } else
            {
                FetchError();
            }
        }

        private void SetStartup()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
            key.SetValue(StartupValue, Application.ExecutablePath.ToString());
        }

        private void FetchError()
        {
            DialogResult dialogResult = MessageBox.Show("Fetch Request Error. \n \n Do you want to restart the app ?", "Fetch Error", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
            else if (dialogResult == DialogResult.No)
            {
                Application.Exit();
                Environment.Exit(0);
            }
        }
    }
}
