
namespace WorkTimeRecord
{
	partial class Main
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
			this.button_IDGeneration = new System.Windows.Forms.Button();
			this.textBox_Id = new System.Windows.Forms.TextBox();
			this.button_timerecord = new System.Windows.Forms.Button();
			this.label_login = new System.Windows.Forms.Label();
			this.label_id = new System.Windows.Forms.Label();
			this.textBox_password = new System.Windows.Forms.TextBox();
			this.label_password = new System.Windows.Forms.Label();
			this.button_ShowRecordWindow = new System.Windows.Forms.Button();
			this.label_reconfirmation = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button_IDGeneration
			// 
			this.button_IDGeneration.Location = new System.Drawing.Point(368, 369);
			this.button_IDGeneration.Name = "button_IDGeneration";
			this.button_IDGeneration.Size = new System.Drawing.Size(100, 23);
			this.button_IDGeneration.TabIndex = 4;
			this.button_IDGeneration.Text = "ユーザー登録";
			this.button_IDGeneration.UseVisualStyleBackColor = true;
			this.button_IDGeneration.Click += new System.EventHandler(this.button_Id_GenerationClick);
			// 
			// textBox_Id
			// 
			this.textBox_Id.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox_Id.Location = new System.Drawing.Point(153, 87);
			this.textBox_Id.Name = "textBox_Id";
			this.textBox_Id.Size = new System.Drawing.Size(177, 28);
			this.textBox_Id.TabIndex = 0;
			// 
			// button_timerecord
			// 
			this.button_timerecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.button_timerecord.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.button_timerecord.ForeColor = System.Drawing.Color.White;
			this.button_timerecord.Location = new System.Drawing.Point(153, 239);
			this.button_timerecord.Name = "button_timerecord";
			this.button_timerecord.Size = new System.Drawing.Size(177, 42);
			this.button_timerecord.TabIndex = 2;
			this.button_timerecord.Text = "出退勤記録";
			this.button_timerecord.UseVisualStyleBackColor = false;
			this.button_timerecord.Click += new System.EventHandler(this.button_timerecord_Click);
			// 
			// label_login
			// 
			this.label_login.AutoSize = true;
			this.label_login.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label_login.ForeColor = System.Drawing.Color.DarkGray;
			this.label_login.Location = new System.Drawing.Point(178, 21);
			this.label_login.Name = "label_login";
			this.label_login.Size = new System.Drawing.Size(127, 37);
			this.label_login.TabIndex = 3;
			this.label_login.Text = "ログイン";
			// 
			// label_id
			// 
			this.label_id.AutoSize = true;
			this.label_id.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label_id.Location = new System.Drawing.Point(99, 94);
			this.label_id.Name = "label_id";
			this.label_id.Size = new System.Drawing.Size(22, 16);
			this.label_id.TabIndex = 4;
			this.label_id.Text = "ID";
			// 
			// textBox_password
			// 
			this.textBox_password.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox_password.Location = new System.Drawing.Point(153, 149);
			this.textBox_password.Name = "textBox_password";
			this.textBox_password.Size = new System.Drawing.Size(177, 28);
			this.textBox_password.TabIndex = 1;
			// 
			// label_password
			// 
			this.label_password.AutoSize = true;
			this.label_password.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label_password.Location = new System.Drawing.Point(99, 156);
			this.label_password.Name = "label_password";
			this.label_password.Size = new System.Drawing.Size(48, 16);
			this.label_password.TabIndex = 6;
			this.label_password.Text = "PASS";
			// 
			// button_ShowRecordWindow
			// 
			this.button_ShowRecordWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.button_ShowRecordWindow.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.button_ShowRecordWindow.ForeColor = System.Drawing.Color.White;
			this.button_ShowRecordWindow.Location = new System.Drawing.Point(153, 316);
			this.button_ShowRecordWindow.Name = "button_ShowRecordWindow";
			this.button_ShowRecordWindow.Size = new System.Drawing.Size(177, 42);
			this.button_ShowRecordWindow.TabIndex = 3;
			this.button_ShowRecordWindow.Text = "記録閲覧";
			this.button_ShowRecordWindow.UseVisualStyleBackColor = false;
			this.button_ShowRecordWindow.Click += new System.EventHandler(this.button_ShowRecordWindow_Click);
			// 
			// label_reconfirmation
			// 
			this.label_reconfirmation.AutoSize = true;
			this.label_reconfirmation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.label_reconfirmation.Location = new System.Drawing.Point(269, 184);
			this.label_reconfirmation.Name = "label_reconfirmation";
			this.label_reconfirmation.Size = new System.Drawing.Size(136, 12);
			this.label_reconfirmation.TabIndex = 5;
			this.label_reconfirmation.Text = "ID/Passwordを忘れた場合";
			this.label_reconfirmation.Click += new System.EventHandler(this.label_reconfirmation_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 404);
			this.Controls.Add(this.label_reconfirmation);
			this.Controls.Add(this.button_ShowRecordWindow);
			this.Controls.Add(this.label_password);
			this.Controls.Add(this.textBox_password);
			this.Controls.Add(this.label_id);
			this.Controls.Add(this.label_login);
			this.Controls.Add(this.button_timerecord);
			this.Controls.Add(this.textBox_Id);
			this.Controls.Add(this.button_IDGeneration);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Main";
			this.Text = "ログイン画面";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_IDGeneration;
		private System.Windows.Forms.TextBox textBox_Id;
		private System.Windows.Forms.Button button_timerecord;
		private System.Windows.Forms.Label label_login;
		private System.Windows.Forms.Label label_id;
		private System.Windows.Forms.TextBox textBox_password;
		private System.Windows.Forms.Label label_password;
		private System.Windows.Forms.Button button_ShowRecordWindow;
		private System.Windows.Forms.Label label_reconfirmation;
	}
}