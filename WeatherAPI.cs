using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherAPI.Models;
using WeatherAPI.Processes;
using WeatherAPI.Services;

namespace Test
{
    public partial class WeatherAPI : Form
    {
        List<Weather> weather;
        public WeatherAPI()
        {
            InitializeComponent();
        }

        private void frmWeatherAPI_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void GetWeather(bool isXML)
        {
            string sZip = this.txtZip.Text.Trim();

            int iZip = Validation(sZip);

            if (iZip == 0)
                return;

            try
            {
                weather = WeatherService.GetWeather(iZip, isXML);

                this.PopulateWeatherData(weather);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateWeatherData(List<Weather> weather)
        {
            this.txtCity.Text = weather[0].City;
            this.txtCloud.Text = weather[0].Clouds;
            this.txtFeels.Text = weather[0].FeelsLike;
            this.txtHigh.Text = weather[0].HighTemp;
            this.txtLat.Text = weather[0].Latitude;
            this.txtLong.Text = weather[0].Longitude;
            this.txtLow.Text = weather[0].LowTemp;
            this.txtTemp.Text = weather[0].CurrentTemp;
            this.txtWind.Text = weather[0].Wind;
        }

        private int Validation(string sZip)
        {
            int iZip = 0;

            bool result = int.TryParse(sZip, out iZip);

            if (!result)
            {
                MessageBox.Show("A numeric value must be entered for zip code!");
                return iZip;
            }
            else if (sZip.Length != 5)
            {
                MessageBox.Show("Zip code must be 5 numbers!");
                iZip = 0;
                return iZip;
            }

            return iZip;
        }

        private void btnJSON_Click(object sender, EventArgs e)
        {
            this.GetWeather(true);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cityLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXML_Click(object sender, EventArgs e)
        {

            this.GetWeather(true);
        }
    }
}
