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
	public partial class RecordsWindow : Form
	{
		public string _userId;
		public RecordsWindow()
		{
			InitializeComponent();
			InitializeListView();
		}
		private void InitializeListView()
		{
			// ListViewコントロールのプロパティを設定
			list_Records.FullRowSelect = true;
			list_Records.GridLines = true;
			list_Records.Sorting = SortOrder.Ascending;
			list_Records.View = View.Details;

			var columnName = new ColumnHeader();
			var columnType = new ColumnHeader();
			var columnData = new ColumnHeader();
			columnName.Text = "ID";
			columnName.Width = 130;
			columnType.Text = "種類";
			columnType.Width = 60;
			columnData.Text = "時刻";
			columnData.Width = 150;
			ColumnHeader[] colHeaderRegValue = { columnName, columnType, columnData };
			list_Records.Columns.AddRange(colHeaderRegValue);
		}

		private void LoadRecordsData()
		{
			using (var db = new TimeRecData())
			{
				string statustext;
				foreach (var record in db.TimeRecords.Where(s => s.userId.IndexOf(_userId) == 0))
				{
					if (record.Status == "arrived")
						statustext = "出勤";
					else
						statustext = "退勤";

					string[] item = { record.userId, statustext, record.StampTime.ToString() };
					list_Records.Items.Add(new ListViewItem(item));
				}
			};
		}

		private void RecordsWindow_Load(object sender, EventArgs e)
		{
			label_UserId.Text = _userId;
			LoadRecordsData();
		}
	}
}
