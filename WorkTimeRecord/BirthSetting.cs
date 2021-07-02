using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTimeRecord
{
	class BirthSetting
	{

		public void SettingBirth(ComboBox comboBox_BirthYear, ComboBox comboBox_BirthMonth, ComboBox comboBox_BirthDay)
		{
			var today = DateTime.Today;
			var day = DateTime.DaysInMonth(today.Year, today.Month);

			for (int i = 1900; i <= DateTime.Now.Year; i++)
				comboBox_BirthYear.Items.Add(i);

			for (int i = 1; i <= 12; i++)
				comboBox_BirthMonth.Items.Add(i);

			for (int i = 2; i <= day; i++)
			{
				comboBox_BirthDay.Items.Add(i);
			}
		}


	}
}
