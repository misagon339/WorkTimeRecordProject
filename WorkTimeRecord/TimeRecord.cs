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
	public partial class TimeRecordWindow : Form
	{

		public string _userId;
		public TimeRecordWindow()
		{
			InitializeComponent();
			label_Datetime.Text = DateTime.Today.ToString("d");
		}

		private void TimeRecord_Load(object sender, EventArgs e)
		{
			timer1.Interval = 1000;
			timer1.Enabled = true;
			label_UserId.Text = _userId;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			label_nowTime.Text = DateTime.Now.ToString("T");
		}

		private void button_arrive_Click(object sender, EventArgs e)
		{
			using (var db = new TimeRecData())
			{
				var cnt = DataCount();

				var timeRecordData = new TimeRecord
				{
					Id = cnt,
					userId = _userId,
					StampTime = DateTime.Now,
					Status = "arrived",
				};

				db.TimeRecords.Add(timeRecordData);
				db.SaveChanges();

				MessageBox.Show("登録が完了しました。", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			};
		}

		private void button_leave_Click(object sender, EventArgs e)
		{
			using (var db = new TimeRecData())
			{
				var cnt = DataCount();
				try
				{
					cnt = db.TimeRecords.Count();
				}
				catch
				{
					cnt = 0;
				}
				var timeRecordData = new TimeRecord
				{
					Id = cnt,
					userId = _userId,
					StampTime = DateTime.Now,
					Status = "leave",
				};

				db.TimeRecords.Add(timeRecordData);
				db.SaveChanges();

				MessageBox.Show("登録が完了しました。", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			};
		}

		public int DataCount()
		{
			var cnt = 0;
			using (var db = new TimeRecData())
			{
				try
				{
					cnt = db.TimeRecords.Count();
				}
				catch
				{
					cnt = 0;
				}
			}
			return cnt;
		}
	}
}

