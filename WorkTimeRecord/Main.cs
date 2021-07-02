using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTimeRecord
{
	public partial class Main : Form
	{
		id_Check id_Check = new id_Check();
		public Main()
		{
			InitializeComponent();
		}
		private void button_Id_GenerationClick(object sender, EventArgs e)
		{
			Id_GenerationForms idForm = new Id_GenerationForms();
			idForm.Show();
		}
		private void button_timerecord_Click(object sender, EventArgs e)
		{
			TimeRecordWindow timeRecordWindow = new TimeRecordWindow();
			TextCheck textCheck = new TextCheck();

			//入力文字に日本語が含まれていないか確認
			if (!textCheck.CheckTextReturnMessage(textBox_Id.Text, textBox_password.Text))
			{
				if (id_Check.CheckId_and_Pass(textBox_Id.Text, textBox_password.Text))
				{
					timeRecordWindow._userId = textBox_Id.Text;
					timeRecordWindow.Show();
				}
				else
					return;
			}
			else
				return;
		}

		private void button_ShowRecordWindow_Click(object sender, EventArgs e)
		{
			RecordsWindow recordsWindow = new RecordsWindow();
			TextCheck textCheck = new TextCheck();

			//入力文字に日本語が含まれていないか確認
			if (!textCheck.CheckTextReturnMessage(textBox_Id.Text, textBox_password.Text))
			{
				if (id_Check.CheckId_and_Pass(textBox_Id.Text, textBox_password.Text))
				{
					recordsWindow._userId = textBox_Id.Text;
					recordsWindow.Show();
				}
				else
					return;
			}
			else
				return;
		}

		private void label_reconfirmation_Click(object sender, EventArgs e)
		{
			ReconfirmationWindow reconfirmationWindow = new ReconfirmationWindow();
			reconfirmationWindow.Show();
		}
	}
}
