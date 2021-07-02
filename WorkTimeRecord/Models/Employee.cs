using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTimeRecord.Models
{
	public class Employee
	{
		public string Id { get; set; }
		public string Password { get; set; }
		public string FirstNameJP { get; set; }
		public string LastNameJP { get; set; }

		public string FirstNameEN { get; set; }
		public string LastNameEN { get; set; }
		public DateTime Birth_Day { get; set; }

	}
}
