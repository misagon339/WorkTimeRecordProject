using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkTimeRecord.Models;


namespace WorkTimeRecord
{
	class id_Check
	{
		private bool is_exist = false;
		private bool is_correct = false;
		private bool is_idpasscheck = false;

		public bool CheckId(string id)
		{
			var EmployeeList = new List<Employee>();
			using (var db = new EmployeeDataBase())
			{
				foreach (var data in db.Employees.Where(s => s.Id.IndexOf(id) == 0))
				{
					var employee = new Employee
					{
						Id = data.Id,
						Password = data.Password,
						FirstNameJP = data.FirstNameJP,
						LastNameJP = data.LastNameJP,
						FirstNameEN = data.FirstNameEN,
						LastNameEN = data.LastNameEN,
						Birth_Day = data.Birth_Day,
					};
					EmployeeList.Add(employee);
				}
			}
			return is_exist = EmployeeList.Exists(s => s.Id == id);
		}

		public bool CheckPass(string pass)
		{
			var EmployeeList = new List<Employee>();
			using (var db = new EmployeeDataBase())
			{
				foreach (var data in db.Employees.Where(s => s.Password.IndexOf(pass) == 0))
				{
					var employee = new Employee
					{
						Id = data.Id,
						Password = data.Password,
						FirstNameJP = data.FirstNameJP,
						LastNameJP = data.LastNameJP,
						FirstNameEN = data.FirstNameEN,
						LastNameEN = data.LastNameEN,
						Birth_Day = data.Birth_Day,
					};
					EmployeeList.Add(employee);
				}
			}
			return EmployeeList.Exists(s => s.Password == pass);
		}

		public bool CheckId_and_Pass(string id, string pass)
		{
			if (CheckId(id) && CheckPass(pass))
			{
				is_idpasscheck = true;
			}
			else
			{
				is_idpasscheck = false;
				MessageBox.Show("入力情報が間違っています。ID,Passwordを確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return is_idpasscheck;
		}

	}
}
