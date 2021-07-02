
namespace WorkTimeRecord
{
	partial class TimeRecordWindow
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
			this.components = new System.ComponentModel.Container();
			this.button_arrive = new System.Windows.Forms.Button();
			this.button_leave = new System.Windows.Forms.Button();
			this.label_nowTime = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label_Datetime = new System.Windows.Forms.Label();
			this.label_UserId = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button_arrive
			// 
			this.button_arrive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.button_arrive.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.button_arrive.ForeColor = System.Drawing.Color.White;
			this.button_arrive.Location = new System.Drawing.Point(42, 205);
			this.button_arrive.Name = "button_arrive";
			this.button_arrive.Size = new System.Drawing.Size(96, 42);
			this.button_arrive.TabIndex = 0;
			this.button_arrive.Text = "出勤";
			this.button_arrive.UseVisualStyleBackColor = false;
			this.button_arrive.Click += new System.EventHandler(this.button_arrive_Click);
			// 
			// button_leave
			// 
			this.button_leave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button_leave.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.button_leave.ForeColor = System.Drawing.Color.White;
			this.button_leave.Location = new System.Drawing.Point(305, 205);
			this.button_leave.Name = "button_leave";
			this.button_leave.Size = new System.Drawing.Size(96, 42);
			this.button_leave.TabIndex = 1;
			this.button_leave.Text = "退勤";
			this.button_leave.UseVisualStyleBackColor = false;
			this.button_leave.Click += new System.EventHandler(this.button_leave_Click);
			// 
			// label_nowTime
			// 
			this.label_nowTime.AutoSize = true;
			this.label_nowTime.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label_nowTime.ForeColor = System.Drawing.Color.DarkGray;
			this.label_nowTime.Location = new System.Drawing.Point(153, 80);
			this.label_nowTime.Name = "label_nowTime";
			this.label_nowTime.Size = new System.Drawing.Size(147, 37);
			this.label_nowTime.TabIndex = 5;
			this.label_nowTime.Text = "00:00:00";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label_Datetime
			// 
			this.label_Datetime.AutoSize = true;
			this.label_Datetime.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label_Datetime.ForeColor = System.Drawing.Color.DarkGray;
			this.label_Datetime.Location = new System.Drawing.Point(38, 34);
			this.label_Datetime.Name = "label_Datetime";
			this.label_Datetime.Size = new System.Drawing.Size(58, 24);
			this.label_Datetime.TabIndex = 6;
			this.label_Datetime.Text = "日付";
			// 
			// label_UserId
			// 
			this.label_UserId.AutoSize = true;
			this.label_UserId.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label_UserId.ForeColor = System.Drawing.Color.DarkGray;
			this.label_UserId.Location = new System.Drawing.Point(302, 9);
			this.label_UserId.Name = "label_UserId";
			this.label_UserId.Size = new System.Drawing.Size(24, 16);
			this.label_UserId.TabIndex = 7;
			this.label_UserId.Text = "--";
			// 
			// TimeRecordWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(449, 278);
			this.Controls.Add(this.label_UserId);
			this.Controls.Add(this.label_Datetime);
			this.Controls.Add(this.label_nowTime);
			this.Controls.Add(this.button_leave);
			this.Controls.Add(this.button_arrive);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TimeRecordWindow";
			this.Text = "出退勤記録画面";
			this.Load += new System.EventHandler(this.TimeRecord_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_arrive;
		private System.Windows.Forms.Button button_leave;
		private System.Windows.Forms.Label label_nowTime;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label_Datetime;
		private System.Windows.Forms.Label label_UserId;
	}
}