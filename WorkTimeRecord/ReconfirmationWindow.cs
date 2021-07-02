using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkTimeRecord.Models;

namespace WorkTimeRecord
{
	public partial class ReconfirmationWindow : Form
	{
		public ReconfirmationWindow()
		{
			InitializeComponent();
			SetBirth();
		}

		private void button_Idreconfirmation_Click(object sender, EventArgs e)
		{
			var BirthDay = new DateTime(int.Parse(comboBox_BirthYear.Text), int.Parse(comboBox_BirthMonth.Text), int.Parse(comboBox_BirthDay.Text));
			TextCheck textCheck = new TextCheck();
			
			if (textCheck.CheckTextContainsNumber(textBox_FirstName.Text) || textCheck.CheckTextContainsNumber(textBox_LastName.Text))
				return;

			using (var db = new EmployeeDataBase())
			{
				foreach (var data in db.Employees.Where(s => s.FirstNameJP.IndexOf(textBox_FirstName.Text) == 0 && s.LastNameJP.IndexOf(textBox_LastName.Text) == 0 && s.Birth_Day == BirthDay))
				{
					MessageBox.Show($"ID:{data.Id} PASS:{data.Password}", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

			}
		}
		private void SetBirth()
		{
			BirthSetting birthSetting = new BirthSetting();
			birthSetting.SettingBirth(comboBox_BirthYear, comboBox_BirthMonth, comboBox_BirthDay);
		}
	}
}
