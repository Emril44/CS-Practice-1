using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KhomenkoDateTime.ViewModels
{
    internal class DateViewModel
    {
		private DateTime _date;
		
		public DateTime Date
		{
			get { return _date; }
			set
            {
                _date = value;
            }
		}

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; CalculateAge(); }
        }

        private string _chinaZodiac = "";

        public string ChineseZodiac
        {
            get { return _chinaZodiac; }
            set { _chinaZodiac = value; GetChineseZodiac(); }
        }

        private string _westZodiac = "";

        public string WesternZodiac
        {
            get { return _westZodiac = ""; }
            set { _westZodiac = value; GetWesternZodiac(); }
        }

        private void CalculateAge()
        {
            DateIsValid();

            var today = DateTime.Today;

            int age = (int)((today - Date).TotalDays / 365.242199);
            if (age >= 0 && age <= 135)
            {
                Age = age;
                return;
            }

            MessageBox.Show("Invalid age! (Below 0 or above 135)");
            return;   
        }

        public bool IsItBirthday()
        {
            DateIsValid();

            var today = DateTime.Today;
            return (Date.Day == today.Day) && (Date.Month == today.Month);
        }

        private void GetWesternZodiac()
        {
            int day = Date.Day;
            int month = Date.Month;
            if ((day >= 21 && month == 1) || (day <= 19 && month == 2))
                WesternZodiac = "Aquarius";
            else if ((day >= 20 && month == 2) || (day <= 20 && month == 3))
                WesternZodiac = "Pisces";
            else if ((day >= 21 && month == 3) || (day <= 20 && month == 4))
                WesternZodiac = "Aries";
            else if ((day >= 21 && month == 4) || (day <= 21 && month == 5))
                WesternZodiac = "Taurus";
            else if ((day >= 22 && month == 5) || (day <= 21 && month == 6))
                WesternZodiac = "Gemini";
            else if ((day >= 21 && month == 6) || (day <= 23 && month == 7))
                WesternZodiac = "Cancer";
            else if ((day >= 24 && month == 7) || (day <= 23 && month == 8))
                WesternZodiac = "Leo";
            else if ((day >= 24 && month == 8) || (day <= 23 && month == 9))
                WesternZodiac = "Virgo";
            else if ((day >= 24 && month == 9) || (day <= 23 && month == 10))
                WesternZodiac = "Libra";
            else if ((day >= 24 && month == 10) || (day <= 22 && month == 11))
                WesternZodiac = "Scorpio";
            else if ((day >= 23 && month == 11) || (day <= 21 && month == 12))
                WesternZodiac = "Sagittarius";
            else if ((day >= 22 && month == 12) || (day <= 20 && month == 1))
                WesternZodiac = "Capricorn";
        }

        private void GetChineseZodiac()
        {
            switch (Date.Year % 12)
            {
                case 0:  ChineseZodiac = "Monkey"; break;
                case 1:  ChineseZodiac = "Rooster"; break;
                case 2:  ChineseZodiac = "Dog"; break;
                case 3:  ChineseZodiac = "Pig"; break;
                case 4:  ChineseZodiac = "Rat"; break;
                case 5:  ChineseZodiac = "Ox"; break;
                case 6:  ChineseZodiac = "Tiger"; break;
                case 7:  ChineseZodiac = "Rabbit"; break;
                case 8:  ChineseZodiac = "Dragon"; break;
                case 9:  ChineseZodiac = "Snake"; break;
                case 10: ChineseZodiac = "Horse"; break;
                case 11: ChineseZodiac = "Goat"; break;
            }
        }

        private void DateIsValid()
		{
            if (Date.Equals(null))
            {
                MessageBox.Show("No date set!");
                return;
            }
        }
	}
}
