namespace FinalHRM
{
    partial class frJob
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabjob = new MetroFramework.Controls.MetroTabControl();
            this.historyemploytab = new MetroFramework.Controls.MetroTabPage();
            this.jobsearchbtt = new MetroFramework.Controls.MetroButton();
            this.jobsearchtxt = new MetroFramework.Controls.MetroTextBox();
            this.jobmetroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.tabjob.SuspendLayout();
            this.historyemploytab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobmetroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabjob
            // 
            this.tabjob.Controls.Add(this.historyemploytab);
            this.tabjob.Location = new System.Drawing.Point(2, 5);
            this.tabjob.Name = "tabjob";
            this.tabjob.SelectedIndex = 0;
            this.tabjob.Size = new System.Drawing.Size(718, 449);
            this.tabjob.TabIndex = 6;
            this.tabjob.UseSelectable = true;
            // 
            // historyemploytab
            // 
            this.historyemploytab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.historyemploytab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historyemploytab.Controls.Add(this.jobsearchbtt);
            this.historyemploytab.Controls.Add(this.jobsearchtxt);
            this.historyemploytab.Controls.Add(this.jobmetroGrid1);
            this.historyemploytab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyemploytab.HorizontalScrollbarBarColor = true;
            this.historyemploytab.HorizontalScrollbarHighlightOnWheel = false;
            this.historyemploytab.HorizontalScrollbarSize = 10;
            this.historyemploytab.Location = new System.Drawing.Point(4, 38);
            this.historyemploytab.Name = "historyemploytab";
            this.historyemploytab.Size = new System.Drawing.Size(710, 407);
            this.historyemploytab.TabIndex = 1;
            this.historyemploytab.Text = "Hồ Sơ Công Việc";
            this.historyemploytab.UseCustomBackColor = true;
            this.historyemploytab.UseCustomForeColor = true;
            this.historyemploytab.VerticalScrollbarBarColor = true;
            this.historyemploytab.VerticalScrollbarHighlightOnWheel = false;
            this.historyemploytab.VerticalScrollbarSize = 10;
            // 
            // jobsearchbtt
            // 
            this.jobsearchbtt.BackColor = System.Drawing.Color.Lavender;
            this.jobsearchbtt.Location = new System.Drawing.Point(206, 3);
            this.jobsearchbtt.Name = "jobsearchbtt";
            this.jobsearchbtt.Size = new System.Drawing.Size(63, 38);
            this.jobsearchbtt.TabIndex = 8;
            this.jobsearchbtt.Text = "Tìm Kiếm";
            this.jobsearchbtt.UseCustomBackColor = true;
            this.jobsearchbtt.UseSelectable = true;
            this.jobsearchbtt.Click += new System.EventHandler(this.jobsearchbtt_Click);
            // 
            // jobsearchtxt
            // 
            // 
            // 
            // 
            this.jobsearchtxt.CustomButton.Image = null;
            this.jobsearchtxt.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.jobsearchtxt.CustomButton.Name = "";
            this.jobsearchtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.jobsearchtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.jobsearchtxt.CustomButton.TabIndex = 1;
            this.jobsearchtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.jobsearchtxt.CustomButton.UseSelectable = true;
            this.jobsearchtxt.CustomButton.Visible = false;
            this.jobsearchtxt.Lines = new string[0];
            this.jobsearchtxt.Location = new System.Drawing.Point(275, 12);
            this.jobsearchtxt.MaxLength = 32767;
            this.jobsearchtxt.Name = "jobsearchtxt";
            this.jobsearchtxt.PasswordChar = '\0';
            this.jobsearchtxt.PromptText = "nhập từ khóa...";
            this.jobsearchtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.jobsearchtxt.SelectedText = "";
            this.jobsearchtxt.SelectionLength = 0;
            this.jobsearchtxt.SelectionStart = 0;
            this.jobsearchtxt.ShortcutsEnabled = true;
            this.jobsearchtxt.Size = new System.Drawing.Size(220, 23);
            this.jobsearchtxt.TabIndex = 7;
            this.jobsearchtxt.UseSelectable = true;
            this.jobsearchtxt.WaterMark = "nhập từ khóa...";
            this.jobsearchtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.jobsearchtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // jobmetroGrid1
            // 
            this.jobmetroGrid1.AllowUserToResizeRows = false;
            this.jobmetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.jobmetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jobmetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.jobmetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jobmetroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.jobmetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.jobmetroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.jobmetroGrid1.EnableHeadersVisualStyles = false;
            this.jobmetroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.jobmetroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.jobmetroGrid1.Location = new System.Drawing.Point(2, 46);
            this.jobmetroGrid1.Name = "jobmetroGrid1";
            this.jobmetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jobmetroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.jobmetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.jobmetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.jobmetroGrid1.Size = new System.Drawing.Size(699, 357);
            this.jobmetroGrid1.TabIndex = 3;
            // 
            // frJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 455);
            this.ControlBox = false;
            this.Controls.Add(this.tabjob);
            this.Name = "frJob";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "frJob";
            this.tabjob.ResumeLayout(false);
            this.historyemploytab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jobmetroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabjob;
        private MetroFramework.Controls.MetroTabPage historyemploytab;
        private MetroFramework.Controls.MetroButton jobsearchbtt;
        private MetroFramework.Controls.MetroTextBox jobsearchtxt;
        private MetroFramework.Controls.MetroGrid jobmetroGrid1;
    }
}