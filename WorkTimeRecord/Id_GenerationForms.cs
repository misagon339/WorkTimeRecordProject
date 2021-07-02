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
	public partial class Id_GenerationForms : Form
	{
		public Id_GenerationForms()
		{
			InitializeComponent();
			SetBirth();
		}

		private void IdGeneration_Click(object sender, EventArgs e)
		{
			TextCheck textCheck = new TextCheck();
			if (textCheck.CheckTextReturnMessage(textBox_FirstNameEN.Text, textBox_LastNameEN.Text) || textCheck.CheckTextReturnMessage(textBox_password.Text))
				return;
			if (textCheck.CheckTextContainsNumber(textBox_FirstName.Text) || textCheck.CheckTextContainsNumber(textBox_LastName.Text))
				return;

			var employeenum = 0;
			using (var db = new EmployeeDataBase())
			{
				employeenum = db.Employees.Count();

				var id = DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString() + employeenum.ToString() + textBox_FirstNameEN.Text + textBox_LastNameEN.Text;

				var employee = new Employee
				{
					Id = id,
					Password = textBox_password.Text,
					FirstNameJP = textBox_FirstName.Text,
					LastNameJP = textBox_LastName.Text,
					FirstNameEN = textBox_FirstNameEN.Text,
					LastNameEN = textBox_LastNameEN.Text,
					Birth_Day = new DateTime(int.Parse(comboBox_BirthYear.Text), int.Parse(comboBox_BirthMonth.Text), int.Parse(comboBox_BirthDay.Text)),
				};

				db.Employees.Add(employee);
				db.SaveChanges();

				label_Id.Text = id;
				MessageBox.Show("登録が完了しました。", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			};
		}

		private void SetBirth()
		{
			BirthSetting birthSetting = new BirthSetting();
			birthSetting.SettingBirth(comboBox_BirthYear, comboBox_BirthMonth, comboBox_BirthDay);
		}
	}
}
