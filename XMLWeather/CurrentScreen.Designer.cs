namespace XMLWeather
{
    partial class CurrentScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.degreeLabel = new System.Windows.Forms.Label();
            this.weatherLabel = new System.Windows.Forms.Label();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.DarkGray;
            this.cityOutput.Location = new System.Drawing.Point(0, 63);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(250, 20);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.Color.LightPink;
            this.maxOutput.Location = new System.Drawing.Point(165, 197);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(78, 13);
            this.maxOutput.TabIndex = 32;
            this.maxOutput.Text = "max";
            this.maxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.Color.LightCyan;
            this.minOutput.Location = new System.Drawing.Point(50, 197);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(58, 13);
            this.minOutput.TabIndex = 30;
            this.minOutput.Text = "min";
            this.minOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.Font = new System.Drawing.Font("Monospac821 BT", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentOutput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.currentOutput.Location = new System.Drawing.Point(3, 86);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(244, 117);
            this.currentOutput.TabIndex = 28;
            this.currentOutput.Text = "00";
            this.currentOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monospac821 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.forecastLabel.Location = new System.Drawing.Point(154, 9);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(82, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(-2, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.currentTimeLabel.Location = new System.Drawing.Point(107, 377);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(142, 23);
            this.currentTimeLabel.TabIndex = 43;
            this.currentTimeLabel.Text = "Current Time";
            this.currentTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // degreeLabel
            // 
            this.degreeLabel.BackColor = System.Drawing.Color.Transparent;
            this.degreeLabel.Font = new System.Drawing.Font("Monospac821 BT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreeLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.degreeLabel.Location = new System.Drawing.Point(164, 71);
            this.degreeLabel.Name = "degreeLabel";
            this.degreeLabel.Size = new System.Drawing.Size(35, 38);
            this.degreeLabel.TabIndex = 44;
            this.degreeLabel.Text = "°";
            this.degreeLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // weatherLabel
            // 
            this.weatherLabel.BackColor = System.Drawing.Color.Transparent;
            this.weatherLabel.Font = new System.Drawing.Font("Monospac821 BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherLabel.ForeColor = System.Drawing.Color.Silver;
            this.weatherLabel.Location = new System.Drawing.Point(2, 273);
            this.weatherLabel.Name = "weatherLabel";
            this.weatherLabel.Size = new System.Drawing.Size(250, 20);
            this.weatherLabel.TabIndex = 45;
            this.weatherLabel.Text = "Weather Condition";
            this.weatherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.currentDateLabel.Location = new System.Drawing.Point(3, 377);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(98, 23);
            this.currentDateLabel.TabIndex = 46;
            this.currentDateLabel.Text = "Current Date";
            this.currentDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.currentDateLabel);
            this.Controls.Add(this.weatherLabel);
            this.Controls.Add(this.degreeLabel);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.label5);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(250, 400);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Label degreeLabel;
        private System.Windows.Forms.Label weatherLabel;
        private System.Windows.Forms.Label currentDateLabel;
    }
}
