namespace AgeCalculator
{
    partial class AgeCalculator
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
            this.Heading = new System.Windows.Forms.Label();
            this.BYearHeading = new System.Windows.Forms.Label();
            this.AgeHeading = new System.Windows.Forms.Label();
            this.MonthHeading = new System.Windows.Forms.Label();
            this.CYearHeading = new System.Windows.Forms.Label();
            this.WeeksHeading = new System.Windows.Forms.Label();
            this.DaysHeading = new System.Windows.Forms.Label();
            this.MinutesHeading = new System.Windows.Forms.Label();
            this.SecondsHeading = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.BYear = new System.Windows.Forms.TextBox();
            this.CYear = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.Label();
            this.Months = new System.Windows.Forms.Label();
            this.Weeks = new System.Windows.Forms.Label();
            this.Days = new System.Windows.Forms.Label();
            this.Minutes = new System.Windows.Forms.Label();
            this.Seconds = new System.Windows.Forms.Label();
            this.HoursHeading = new System.Windows.Forms.Label();
            this.Hours = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(309, 33);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(141, 24);
            this.Heading.TabIndex = 0;
            this.Heading.Text = "Age Calculator";
            this.Heading.Click += new System.EventHandler(this.label1_Click);
            // 
            // BYearHeading
            // 
            this.BYearHeading.AutoSize = true;
            this.BYearHeading.Location = new System.Drawing.Point(68, 100);
            this.BYearHeading.Name = "BYearHeading";
            this.BYearHeading.Size = new System.Drawing.Size(54, 13);
            this.BYearHeading.TabIndex = 1;
            this.BYearHeading.Text = "Birth Year";
            this.BYearHeading.Click += new System.EventHandler(this.label2_Click);
            // 
            // AgeHeading
            // 
            this.AgeHeading.AutoSize = true;
            this.AgeHeading.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeHeading.Location = new System.Drawing.Point(68, 188);
            this.AgeHeading.Name = "AgeHeading";
            this.AgeHeading.Size = new System.Drawing.Size(29, 14);
            this.AgeHeading.TabIndex = 2;
            this.AgeHeading.Text = "Age";
            // 
            // MonthHeading
            // 
            this.MonthHeading.AutoSize = true;
            this.MonthHeading.Location = new System.Drawing.Point(68, 222);
            this.MonthHeading.Name = "MonthHeading";
            this.MonthHeading.Size = new System.Drawing.Size(42, 13);
            this.MonthHeading.TabIndex = 3;
            this.MonthHeading.Text = "Months";
            // 
            // CYearHeading
            // 
            this.CYearHeading.AutoSize = true;
            this.CYearHeading.Location = new System.Drawing.Point(68, 137);
            this.CYearHeading.Name = "CYearHeading";
            this.CYearHeading.Size = new System.Drawing.Size(69, 13);
            this.CYearHeading.TabIndex = 4;
            this.CYearHeading.Text = "Current Year";
            this.CYearHeading.Click += new System.EventHandler(this.label5_Click);
            // 
            // WeeksHeading
            // 
            this.WeeksHeading.AutoSize = true;
            this.WeeksHeading.Location = new System.Drawing.Point(68, 263);
            this.WeeksHeading.Name = "WeeksHeading";
            this.WeeksHeading.Size = new System.Drawing.Size(39, 13);
            this.WeeksHeading.TabIndex = 5;
            this.WeeksHeading.Text = "Weeks";
            // 
            // DaysHeading
            // 
            this.DaysHeading.AutoSize = true;
            this.DaysHeading.Location = new System.Drawing.Point(68, 304);
            this.DaysHeading.Name = "DaysHeading";
            this.DaysHeading.Size = new System.Drawing.Size(31, 13);
            this.DaysHeading.TabIndex = 6;
            this.DaysHeading.Text = "Days";
            // 
            // MinutesHeading
            // 
            this.MinutesHeading.AutoSize = true;
            this.MinutesHeading.Location = new System.Drawing.Point(393, 263);
            this.MinutesHeading.Name = "MinutesHeading";
            this.MinutesHeading.Size = new System.Drawing.Size(44, 13);
            this.MinutesHeading.TabIndex = 7;
            this.MinutesHeading.Text = "Minutes";
            this.MinutesHeading.Click += new System.EventHandler(this.MinutesHeading_Click);
            // 
            // SecondsHeading
            // 
            this.SecondsHeading.AutoSize = true;
            this.SecondsHeading.Location = new System.Drawing.Point(393, 304);
            this.SecondsHeading.Name = "SecondsHeading";
            this.SecondsHeading.Size = new System.Drawing.Size(47, 13);
            this.SecondsHeading.TabIndex = 8;
            this.SecondsHeading.Text = "Seconds";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(262, 363);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(263, 23);
            this.CalculateButton.TabIndex = 9;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // BYear
            // 
            this.BYear.Location = new System.Drawing.Point(143, 97);
            this.BYear.Name = "BYear";
            this.BYear.Size = new System.Drawing.Size(188, 20);
            this.BYear.TabIndex = 10;
            this.BYear.Text = "200";
            // 
            // CYear
            // 
            this.CYear.Location = new System.Drawing.Point(143, 130);
            this.CYear.Name = "CYear";
            this.CYear.Size = new System.Drawing.Size(188, 20);
            this.CYear.TabIndex = 11;
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(140, 188);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(0, 13);
            this.Age.TabIndex = 12;
            // 
            // Months
            // 
            this.Months.AutoSize = true;
            this.Months.Location = new System.Drawing.Point(140, 222);
            this.Months.Name = "Months";
            this.Months.Size = new System.Drawing.Size(0, 13);
            this.Months.TabIndex = 13;
            // 
            // Weeks
            // 
            this.Weeks.AutoSize = true;
            this.Weeks.Location = new System.Drawing.Point(140, 263);
            this.Weeks.Name = "Weeks";
            this.Weeks.Size = new System.Drawing.Size(0, 13);
            this.Weeks.TabIndex = 14;
            // 
            // Days
            // 
            this.Days.AutoSize = true;
            this.Days.Location = new System.Drawing.Point(140, 304);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(0, 13);
            this.Days.TabIndex = 15;
            // 
            // Minutes
            // 
            this.Minutes.AutoSize = true;
            this.Minutes.Location = new System.Drawing.Point(464, 263);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(0, 13);
            this.Minutes.TabIndex = 16;
            // 
            // Seconds
            // 
            this.Seconds.AutoSize = true;
            this.Seconds.Location = new System.Drawing.Point(464, 304);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(0, 13);
            this.Seconds.TabIndex = 17;
            // 
            // HoursHeading
            // 
            this.HoursHeading.AutoSize = true;
            this.HoursHeading.Location = new System.Drawing.Point(393, 222);
            this.HoursHeading.Name = "HoursHeading";
            this.HoursHeading.Size = new System.Drawing.Size(35, 13);
            this.HoursHeading.TabIndex = 18;
            this.HoursHeading.Text = "Hours";
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Location = new System.Drawing.Point(464, 222);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(0, 13);
            this.Hours.TabIndex = 19;
            // 
            // AgeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.HoursHeading);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.Weeks);
            this.Controls.Add(this.Months);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.CYear);
            this.Controls.Add(this.BYear);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SecondsHeading);
            this.Controls.Add(this.MinutesHeading);
            this.Controls.Add(this.DaysHeading);
            this.Controls.Add(this.WeeksHeading);
            this.Controls.Add(this.CYearHeading);
            this.Controls.Add(this.MonthHeading);
            this.Controls.Add(this.AgeHeading);
            this.Controls.Add(this.BYearHeading);
            this.Controls.Add(this.Heading);
            this.Name = "AgeCalculator";
            this.Text = "Age Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label BYearHeading;
        private System.Windows.Forms.Label AgeHeading;
        private System.Windows.Forms.Label MonthHeading;
        private System.Windows.Forms.Label CYearHeading;
        private System.Windows.Forms.Label WeeksHeading;
        private System.Windows.Forms.Label DaysHeading;
        private System.Windows.Forms.Label MinutesHeading;
        private System.Windows.Forms.Label SecondsHeading;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox BYear;
        private System.Windows.Forms.TextBox CYear;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label Months;
        private System.Windows.Forms.Label Weeks;
        private System.Windows.Forms.Label Days;
        private System.Windows.Forms.Label Minutes;
        private System.Windows.Forms.Label Seconds;
        private System.Windows.Forms.Label HoursHeading;
        private System.Windows.Forms.Label Hours;
    }
}

