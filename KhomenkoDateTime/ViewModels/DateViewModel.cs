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
			set { _date = value; }
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


        public void CalculateAge()
        {
            DateIsValid();

            var today = DateTime.Today;

            int age = (int)((today - _date).TotalDays / 365.242199);
            if (age >= 0 && age <= 135)
            {
                _age = age;
                return;
            }

            MessageBox.Show("Invalid age! (Below 0 or above 135)");
            return;   
        }

        public bool IsItBirthday()
        {
            DateIsValid();

            var today = DateTime.Today;
            return (_date.Day == today.Day) && (_date.Month == today.Month);
        }

        public string GetWesternZodiac()
        {
            int month = _date.Month; int day = _date.Day;

            switch (month)
            {
                case 1:
                    if (day <= 19)
                        return "Capricorn"; else return "Aquarius";
                case 2:
                    if (day <= 18)
                        return "Aquarius"; else return "Pisces";
                case 3:
                    if (day <= 20)
                        return "Pisces"; else return "Aries";
                case 4:
                    if (day <= 19)
                        return "Aries"; else return "Taurus";
                case 5:
                    if (day <= 20)
                        return "Taurus"; else return "Gemini";
                case 6:
                    if (day <= 20)
                        return "Gemini"; else return "Cancer";
                case 7:
                    if (day <= 22)
                        return "Cancer"; else return "Leo";
                case 8:
                    if (day <= 22)
                        return "Leo"; else return "Virgo";
                case 9:
                    if (day <= 22)
                        return "Virgo"; else return "Libra";
                case 10:
                    if (day <= 22)
                        return "Libra"; else return "Scorpio";
                case 11:
                    if (day <= 21)
                        return "Scorpio"; else return "Sagittarius";
                case 12:
                    if (day <= 21)
                        return "Sagittarius"; else return "Capricorn";
            }
            return "";
        }

        private void GetChineseZodiac()
        {
            switch (_date.Year % 12)
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
            if (_date.Equals(null))
            {
                MessageBox.Show("No date set!");
                return;
            }
        }
	}
}
