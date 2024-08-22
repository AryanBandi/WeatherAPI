namespace Test
{
    partial class WeatherAPI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnXML = new System.Windows.Forms.Button();
            this.btnJSON = new System.Windows.Forms.Button();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.latLabel = new System.Windows.Forms.Label();
            this.lowLabel = new System.Windows.Forms.Label();
            this.highLabel = new System.Windows.Forms.Label();
            this.longLabel = new System.Windows.Forms.Label();
            this.feelsLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.windLabel = new System.Windows.Forms.Label();
            this.cloudLabel = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.txtFeels = new System.Windows.Forms.TextBox();
            this.txtWind = new System.Windows.Forms.TextBox();
            this.txtCloud = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(119, 34);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(171, 31);
            this.btnXML.TabIndex = 0;
            this.btnXML.Text = "Get Weather XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // btnJSON
            // 
            this.btnJSON.Location = new System.Drawing.Point(119, 71);
            this.btnJSON.Name = "btnJSON";
            this.btnJSON.Size = new System.Drawing.Size(171, 31);
            this.btnJSON.TabIndex = 1;
            this.btnJSON.Text = "Get Weather JSON";
            this.btnJSON.UseVisualStyleBackColor = true;
            this.btnJSON.Click += new System.EventHandler(this.btnJSON_Click);
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(147, 138);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 20);
            this.txtZip.TabIndex = 2;
            this.txtZip.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(164, 120);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(77, 13);
            this.zipLabel.TabIndex = 3;
            this.zipLabel.Text = "Where you at?";
            this.zipLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(116, 182);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 4;
            this.cityLabel.Text = "City:";
            this.cityLabel.Click += new System.EventHandler(this.cityLabel_Click);
            // 
            // latLabel
            // 
            this.latLabel.AutoSize = true;
            this.latLabel.Location = new System.Drawing.Point(185, 182);
            this.latLabel.Name = "latLabel";
            this.latLabel.Size = new System.Drawing.Size(25, 13);
            this.latLabel.TabIndex = 5;
            this.latLabel.Text = "Lat:";
            // 
            // lowLabel
            // 
            this.lowLabel.AutoSize = true;
            this.lowLabel.Location = new System.Drawing.Point(211, 232);
            this.lowLabel.Name = "lowLabel";
            this.lowLabel.Size = new System.Drawing.Size(30, 13);
            this.lowLabel.TabIndex = 6;
            this.lowLabel.Text = "Low:";
            // 
            // highLabel
            // 
            this.highLabel.AutoSize = true;
            this.highLabel.Location = new System.Drawing.Point(146, 232);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(32, 13);
            this.highLabel.TabIndex = 7;
            this.highLabel.Text = "High:";
            this.highLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // longLabel
            // 
            this.longLabel.AutoSize = true;
            this.longLabel.Location = new System.Drawing.Point(245, 182);
            this.longLabel.Name = "longLabel";
            this.longLabel.Size = new System.Drawing.Size(34, 13);
            this.longLabel.TabIndex = 8;
            this.longLabel.Text = "Long:";
            // 
            // feelsLabel
            // 
            this.feelsLabel.AutoSize = true;
            this.feelsLabel.Location = new System.Drawing.Point(275, 232);
            this.feelsLabel.Name = "feelsLabel";
            this.feelsLabel.Size = new System.Drawing.Size(58, 13);
            this.feelsLabel.TabIndex = 9;
            this.feelsLabel.Text = "Feels Like:";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Location = new System.Drawing.Point(78, 232);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(37, 13);
            this.tempLabel.TabIndex = 10;
            this.tempLabel.Text = "Temp:";
            // 
            // windLabel
            // 
            this.windLabel.AutoSize = true;
            this.windLabel.Location = new System.Drawing.Point(137, 283);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(35, 13);
            this.windLabel.TabIndex = 11;
            this.windLabel.Text = "Wind:";
            // 
            // cloudLabel
            // 
            this.cloudLabel.AutoSize = true;
            this.cloudLabel.Location = new System.Drawing.Point(222, 282);
            this.cloudLabel.Name = "cloudLabel";
            this.cloudLabel.Size = new System.Drawing.Size(37, 13);
            this.cloudLabel.TabIndex = 12;
            this.cloudLabel.Text = "Cloud:";
            // 
            // txtCity
            // 
            this.txtCity.Enabled = false;
            this.txtCity.Location = new System.Drawing.Point(95, 198);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(62, 20);
            this.txtCity.TabIndex = 13;
            // 
            // txtLat
            // 
            this.txtLat.Enabled = false;
            this.txtLat.Location = new System.Drawing.Point(163, 198);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(62, 20);
            this.txtLat.TabIndex = 14;
            // 
            // txtLong
            // 
            this.txtLong.Enabled = false;
            this.txtLong.Location = new System.Drawing.Point(228, 198);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(62, 20);
            this.txtLong.TabIndex = 15;
            // 
            // txtTemp
            // 
            this.txtTemp.Enabled = false;
            this.txtTemp.Location = new System.Drawing.Point(63, 248);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(62, 20);
            this.txtTemp.TabIndex = 16;
            // 
            // txtHigh
            // 
            this.txtHigh.Enabled = false;
            this.txtHigh.Location = new System.Drawing.Point(131, 248);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.Size = new System.Drawing.Size(62, 20);
            this.txtHigh.TabIndex = 17;
            // 
            // txtLow
            // 
            this.txtLow.Enabled = false;
            this.txtLow.Location = new System.Drawing.Point(199, 248);
            this.txtLow.Name = "txtLow";
            this.txtLow.Size = new System.Drawing.Size(62, 20);
            this.txtLow.TabIndex = 18;
            // 
            // txtFeels
            // 
            this.txtFeels.Enabled = false;
            this.txtFeels.Location = new System.Drawing.Point(271, 248);
            this.txtFeels.Name = "txtFeels";
            this.txtFeels.Size = new System.Drawing.Size(62, 20);
            this.txtFeels.TabIndex = 19;
            // 
            // txtWind
            // 
            this.txtWind.Enabled = false;
            this.txtWind.Location = new System.Drawing.Point(119, 298);
            this.txtWind.Name = "txtWind";
            this.txtWind.Size = new System.Drawing.Size(74, 20);
            this.txtWind.TabIndex = 20;
            // 
            // txtCloud
            // 
            this.txtCloud.Enabled = false;
            this.txtCloud.Location = new System.Drawing.Point(199, 298);
            this.txtCloud.Name = "txtCloud";
            this.txtCloud.Size = new System.Drawing.Size(80, 20);
            this.txtCloud.TabIndex = 21;
            // 
            // btnClose
            // 
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(318, 350);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 31);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "I\'m done w/ you";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // WeatherAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(421, 382);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtCloud);
            this.Controls.Add(this.txtWind);
            this.Controls.Add(this.txtFeels);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.cloudLabel);
            this.Controls.Add(this.windLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.feelsLabel);
            this.Controls.Add(this.longLabel);
            this.Controls.Add(this.highLabel);
            this.Controls.Add(this.lowLabel);
            this.Controls.Add(this.latLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.btnJSON);
            this.Controls.Add(this.btnXML);
            this.Name = "WeatherAPI";
            this.Text = "Weather API Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.Button btnJSON;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label latLabel;
        private System.Windows.Forms.Label lowLabel;
        private System.Windows.Forms.Label highLabel;
        private System.Windows.Forms.Label longLabel;
        private System.Windows.Forms.Label feelsLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label windLabel;
        private System.Windows.Forms.Label cloudLabel;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.TextBox txtFeels;
        private System.Windows.Forms.TextBox txtWind;
        private System.Windows.Forms.TextBox txtCloud;
        private System.Windows.Forms.Button btnClose;
    }
}