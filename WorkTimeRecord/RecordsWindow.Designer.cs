
namespace WorkTimeRecord
{
	partial class RecordsWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.list_Records = new System.Windows.Forms.ListView();
			this.label_RecordsTitle = new System.Windows.Forms.Label();
			this.label_UserId = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// list_Records
			// 
			this.list_Records.HideSelection = false;
			this.list_Records.Location = new System.Drawing.Point(12, 39);
			this.list_Records.Name = "list_Records";
			this.list_Records.Size = new System.Drawing.Size(323, 374);
			this.list_Records.TabIndex = 0;
			this.list_Records.UseCompatibleStateImageBehavior = false;
			// 
			// label_RecordsTitle
			// 
			this.label_RecordsTitle.AutoSize = true;
			this.label_RecordsTitle.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label_RecordsTitle.ForeColor = System.Drawing.Color.DarkGray;
			this.label_RecordsTitle.Location = new System.Drawing.Point(111, 9);
			this.label_RecordsTitle.Name = "label_RecordsTitle";
			this.label_RecordsTitle.Size = new System.Drawing.Size(120, 27);
			this.label_RecordsTitle.TabIndex = 4;
			this.label_RecordsTitle.Text = "勤怠記録";
			// 
			// label_UserId
			// 
			this.label_UserId.AutoSize = true;
			this.label_UserId.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label_UserId.ForeColor = System.Drawing.Color.DarkGray;
			this.label_UserId.Location = new System.Drawing.Point(237, 9);
			this.label_UserId.Name = "label_UserId";
			this.label_UserId.Size = new System.Drawing.Size(17, 12);
			this.label_UserId.TabIndex = 8;
			this.label_UserId.Text = "--";
			// 
			// RecordsWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(347, 425);
			this.Controls.Add(this.label_UserId);
			this.Controls.Add(this.label_RecordsTitle);
			this.Controls.Add(this.list_Records);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RecordsWindow";
			this.Text = "勤怠記録画面";
			this.Load += new System.EventHandler(this.RecordsWindow_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView list_Records;
		private System.Windows.Forms.Label label_RecordsTitle;
		private System.Windows.Forms.Label label_UserId;
	}
}