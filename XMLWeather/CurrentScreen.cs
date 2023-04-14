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
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            //display screen information
            cityOutput.Text = Form1.days[0].location;
            weatherLabel.Text = Form1.days[0].condition;
            currentOutput.Text = $"{Convert.ToDouble(Form1.days[0].currentTemp).ToString("#")}";
            minOutput.Text = $"{Convert.ToDouble(Form1.days[0].tempLow).ToString("#")}°";
            maxOutput.Text = $"{Convert.ToDouble(Form1.days[0].tempHigh).ToString("#")}°";
            currentTimeLabel.Text = "Last Updated:" + DateTime.Now.ToString("hh:mm tt");
            currentDateLabel.Text = Form1.days[0].date;

            //if the temperature is 0 degrees, then it gets rounded to ""
            //fix the "empty" temperatures 
            if (minOutput.Text == "")
            {
                minOutput.Text = "0";
            }
            if (maxOutput.Text == "")
            {
                maxOutput.Text = "0";
            }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
