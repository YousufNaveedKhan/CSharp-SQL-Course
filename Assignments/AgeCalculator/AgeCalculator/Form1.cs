using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class AgeCalculator : Form
    {
        public AgeCalculator()
        {
            InitializeComponent();
        }


        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int BirthYear = Convert.ToInt32(BYear.Text);
            int CurrentYear = Convert.ToInt32(CYear.Text);

            int Calculate = CurrentYear - BirthYear;

            int Month = Calculate * 12;
            int Week = Month * 4;
            int Day = Week * 7;
            int Hour = Day * 24;
            int Minute = Hour * 60;
            int Second = Minute * 60;

            Age.Text = Calculate.ToString();
            Months.Text = Month.ToString();
            Weeks.Text = Week.ToString();
            Days.Text = Day.ToString();
            Hours.Text = Hour.ToString();
            Minutes.Text = Minute.ToString();
            Seconds.Text = Second.ToString();
        }
    }
}
