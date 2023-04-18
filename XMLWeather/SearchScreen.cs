using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class SearchScreen : UserControl
    {
        string oldSearch = Form1.location;

        public SearchScreen()
        {
            InitializeComponent();
            cityInputBox.Text = Form1.location;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //get new location
            Form1.location = cityInputBox.Text;
             
            //try to gather data, if that fails then the search was wrong
            try
            {
                searchFor();

                cityInputBox.Text = "Search Successful";
            }

            catch
            {
                //display the working information
                Form1.location = oldSearch;

                searchFor();

                cityInputBox.Text = "Search Failed";
            }
        }

        public void searchFor()
        {
            //clear old data
            Form1.days.Clear();

            //add new data
            Form1.ExtractForecast();
            Form1.ExtractCurrent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //switch screen to Current Screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            //switch screen to Forecast Screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen cs = new ForecastScreen();
            f.Controls.Add(cs);
        }
    }
}
