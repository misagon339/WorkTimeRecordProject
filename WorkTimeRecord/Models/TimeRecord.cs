using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTimeRecord.Models
{
	public class TimeRecord
	{
		public int Id { get; set; }
		public string userId { get; set; }
		public DateTime StampTime { get; set; }
		public string Status { get; set; }
	}
}
