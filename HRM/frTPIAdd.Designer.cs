namespace FinalHRM
{
    partial class frTPIAdd
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tpiaddcancelbtt = new MetroFramework.Controls.MetroButton();
            this.tpiaddyesbtt = new MetroFramework.Controls.MetroButton();
            this.projmetroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.employmetroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.emnametxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.joindate = new MetroFramework.Controls.MetroDateTime();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(43, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Dự Án:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(43, 158);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Nhân viên:";
            // 
            // tpiaddcancelbtt
            // 
            this.tpiaddcancelbtt.Location = new System.Drawing.Point(23, 254);
            this.tpiaddcancelbtt.Name = "tpiaddcancelbtt";
            this.tpiaddcancelbtt.Size = new System.Drawing.Size(75, 23);
            this.tpiaddcancelbtt.TabIndex = 2;
            this.tpiaddcancelbtt.Text = "hủy";
            this.tpiaddcancelbtt.UseSelectable = true;
            this.tpiaddcancelbtt.Click += new System.EventHandler(this.tpiaddcancelbtt_Click);
            // 
            // tpiaddyesbtt
            // 
            this.tpiaddyesbtt.Location = new System.Drawing.Point(385, 254);
            this.tpiaddyesbtt.Name = "tpiaddyesbtt";
            this.tpiaddyesbtt.Size = new System.Drawing.Size(75, 23);
            this.tpiaddyesbtt.TabIndex = 3;
            this.tpiaddyesbtt.Text = "Đồng Ý";
            this.tpiaddyesbtt.UseSelectable = true;
            this.tpiaddyesbtt.Click += new System.EventHandler(this.tpiaddyesbtt_Click);
            // 
            // projmetroComboBox1
            // 
            this.projmetroComboBox1.FormattingEnabled = true;
            this.projmetroComboBox1.ItemHeight = 23;
            this.projmetroComboBox1.Location = new System.Drawing.Point(153, 80);
            this.projmetroComboBox1.Name = "projmetroComboBox1";
            this.projmetroComboBox1.Size = new System.Drawing.Size(213, 29);
            this.projmetroComboBox1.TabIndex = 4;
            this.projmetroComboBox1.UseSelectable = true;
            // 
            // employmetroComboBox2
            // 
            this.employmetroComboBox2.FormattingEnabled = true;
            this.employmetroComboBox2.ItemHeight = 23;
            this.employmetroComboBox2.Location = new System.Drawing.Point(153, 155);
            this.employmetroComboBox2.Name = "employmetroComboBox2";
            this.employmetroComboBox2.Size = new System.Drawing.Size(97, 29);
            this.employmetroComboBox2.TabIndex = 5;
            this.employmetroComboBox2.UseSelectable = true;
            this.employmetroComboBox2.SelectedIndexChanged += new System.EventHandler(this.employmetroComboBox2_SelectedIndexChanged);
            // 
            // emnametxt
            // 
            // 
            // 
            // 
            this.emnametxt.CustomButton.Image = null;
            this.emnametxt.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.emnametxt.CustomButton.Name = "";
            this.emnametxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.emnametxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emnametxt.CustomButton.TabIndex = 1;
            this.emnametxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emnametxt.CustomButton.UseSelectable = true;
            this.emnametxt.CustomButton.Visible = false;
            this.emnametxt.Enabled = false;
            this.emnametxt.Lines = new string[0];
            this.emnametxt.Location = new System.Drawing.Point(256, 157);
            this.emnametxt.MaxLength = 32767;
            this.emnametxt.Name = "emnametxt";
            this.emnametxt.PasswordChar = '\0';
            this.emnametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emnametxt.SelectedText = "";
            this.emnametxt.SelectionLength = 0;
            this.emnametxt.SelectionStart = 0;
            this.emnametxt.ShortcutsEnabled = true;
            this.emnametxt.Size = new System.Drawing.Size(204, 23);
            this.emnametxt.TabIndex = 7;
            this.emnametxt.UseSelectable = true;
            this.emnametxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emnametxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(43, 214);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(103, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Ngày Tham Gia:";
            // 
            // joindate
            // 
            this.joindate.Location = new System.Drawing.Point(153, 212);
            this.joindate.MaxDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.joindate.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.joindate.MinimumSize = new System.Drawing.Size(0, 29);
            this.joindate.Name = "joindate";
            this.joindate.Size = new System.Drawing.Size(240, 29);
            this.joindate.TabIndex = 9;
            // 
            // frTPIAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 291);
            this.ControlBox = false;
            this.Controls.Add(this.joindate);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.emnametxt);
            this.Controls.Add(this.employmetroComboBox2);
            this.Controls.Add(this.projmetroComboBox1);
            this.Controls.Add(this.tpiaddyesbtt);
            this.Controls.Add(this.tpiaddcancelbtt);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frTPIAdd";
            this.Text = "                   Tham Gia Dự Án";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton tpiaddcancelbtt;
        private MetroFramework.Controls.MetroButton tpiaddyesbtt;
        private MetroFramework.Controls.MetroComboBox projmetroComboBox1;
        private MetroFramework.Controls.MetroComboBox employmetroComboBox2;
        private MetroFramework.Controls.MetroTextBox emnametxt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime joindate;
    }
}