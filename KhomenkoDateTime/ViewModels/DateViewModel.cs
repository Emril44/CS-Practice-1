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
                CalculateAge();
                GetWesternZodiac();
                GetChineseZodiac();
            }
		}

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private string _chinaZodiac = "";

        public string ChineseZodiac
        {
            get { return _chinaZodiac; }
            set { _chinaZodiac = value; }
        }

        private string _westZodiac = "";

        public string WesternZodiac
        {
            get { return _westZodiac; }
            set { _westZodiac = value; }
        }

        private void CalculateAge()
        {
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
            var today = DateTime.Today;
            return (Date.Day == today.Day) && (Date.Month == today.Month);
        }

        private void GetWesternZodiac()
        {
            int month = Date.Month;
            int day = Date.Day;
            switch (month)
            {
                case 1:
                    if (day <= 19)
                        WesternZodiac = "Capricorn";
                    else
                        WesternZodiac = "Aquarius";
                    break;

                case 2:
                    if (day <= 18)
                        WesternZodiac = "Aquarius";
                    else
                        WesternZodiac = "Pisces";
                    break;

                case 3:
                    if (day <= 20)
                        WesternZodiac = "Pisces";
                    else
                        WesternZodiac = "Aries";
                    break;

                case 4:
                    if (day <= 19)
                        WesternZodiac = "Aries";
                    else
                        WesternZodiac = "Taurus";
                    break;

                case 5:
                    if (day <= 20)
                        WesternZodiac = "Taurus";
                    else
                        WesternZodiac = "Gemini";
                    break;

                case 6:
                    if (day <= 20)
                        WesternZodiac = "Gemini";
                    else
                        WesternZodiac = "Cancer";
                    break;

                case 7:
                    if (day <= 22)
                        WesternZodiac = "Cancer";
                    else
                        WesternZodiac = "Leo";
                    break;

                case 8:
                    if (day <= 22)
                        WesternZodiac = "Leo";
                    else
                        WesternZodiac = "Virgo";
                    break;

                case 9:
                    if (day <= 22)
                        WesternZodiac = "Virgo";
                    else
                        WesternZodiac = "Libra";
                    break;

                case 10:
                    if (day <= 22)
                        WesternZodiac = "Libra";
                    else
                        WesternZodiac = "Scorpio";
                    break;

                case 11:
                    if (day <= 21)
                        WesternZodiac = "Scorpio";
                    else
                        WesternZodiac = "Sagittarius";
                    break;

                case 12:
                    if (day <= 21)
                        WesternZodiac = "Sagittarius";
                    else
                        WesternZodiac = "Capricorn";
                    break;
            }
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
	}
}
