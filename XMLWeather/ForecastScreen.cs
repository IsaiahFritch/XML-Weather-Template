using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            //arrays to store labels
            Label[] dates = new Label[] { date0Label, date1Label, date2Label, date3Label, date4Label, date5Label, date6Label },
            minTemps = new Label[] { min0Output, min1Output, min2Output, min3Output, min4Output, min5Output, min6Output },
            maxTemps = new Label[] { max0Output, max1Output, max2Output, max3Output, max4Output, max5Output, max6Output },
            weatherConds = new Label[] { weather0Output, weather1Output, weather2Output, weather3Output, weather4Output, weather5Output, weather6Output };

            //display dates
            for (int i = 0; i < dates.Length; i++) {dates[i].Text = Form1.days[i].date;}

            //display minimum temperature
            for (int i = 0; i < minTemps.Length; i++)
            {
                minTemps[i].Text = $"{Convert.ToDouble(Form1.days[i].tempLow).ToString("#")}°";

                # region fix rounding issues
                //if the temperature is 0 degrees, then it gets rounded to ""
                //fix the "empty" temperatures 
                if (minTemps[i].Text == "°")
                {
                    minTemps[i].Text = "0°";
                }
                if (minTemps[i].Text == "°")
                {
                    minTemps[i].Text = "0°";
                }
                #endregion
            }

            //display maximum temperature
            for (int i = 0; i < maxTemps.Length; i++)
            {
                maxTemps[i].Text = $"{Convert.ToDouble(Form1.days[i].tempHigh).ToString("#")}°";

                # region fix rounding issues
                //if the temperature is 0 degrees, then it gets rounded to ""
                //fix the "empty" temperatures 
                if (maxTemps[i].Text == "°")
                {
                    maxTemps[i].Text = "0°";
                }
                if (maxTemps[i].Text == "°")
                {
                    maxTemps[i].Text = "0°";
                }
                #endregion
            }

            //display weather conditions
            for (int i = 0; i < weatherConds.Length; i++) { weatherConds[i].Text = Form1.days[i].condition; }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //switch screen to Current Screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            //switch screen to Search Screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            SearchScreen fs = new SearchScreen();
            f.Controls.Add(fs);
        }
    }
}
