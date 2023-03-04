using KhomenkoDateTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhomenkoDateTime.ViewModels
{
    internal class DateViewModel
    {
        private User _user = new User();


		public DateOnly Date
		{
			get { return _user.Date; }
			set { _user.Date = value; }
		}

	}
}
