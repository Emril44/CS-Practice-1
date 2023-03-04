using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhomenkoDateTime.Models
{
    internal class User
    {
		private DateOnly dateTime;

		public DateOnly Date
		{
			get { return dateTime; }
			set { dateTime = value; }
		}
	}
}
