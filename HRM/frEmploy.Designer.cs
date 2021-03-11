namespace FinalHRM
{
    partial class frEmploy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabemploys = new MetroFramework.Controls.MetroTabControl();
            this.employnowtab = new MetroFramework.Controls.MetroTabPage();
            this.employnowsearchbtt = new MetroFramework.Controls.MetroButton();
            this.employnowsearchtxt = new MetroFramework.Controls.MetroTextBox();
            this.employnoweditbtt = new MetroFramework.Controls.MetroButton();
            this.employnowaddbtt = new MetroFramework.Controls.MetroButton();
            this.employnowmetroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.historyemploytab = new MetroFramework.Controls.MetroTabPage();
            this.employhissearchbtt = new MetroFramework.Controls.MetroButton();
            this.employhissearchtxt = new MetroFramework.Controls.MetroTextBox();
            this.employhismetroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.tabemploys.SuspendLayout();
            this.employnowtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employnowmetroGrid1)).BeginInit();
            this.historyemploytab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employhismetroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabemploys
            // 
            this.tabemploys.Controls.Add(this.employnowtab);
            this.tabemploys.Controls.Add(this.historyemploytab);
            this.tabemploys.Location = new System.Drawing.Point(2, 5);
            this.tabemploys.Name = "tabemploys";
            this.tabemploys.SelectedIndex = 1;
            this.tabemploys.Size = new System.Drawing.Size(718, 449);
            this.tabemploys.TabIndex = 5;
            this.tabemploys.UseSelectable = true;
            // 
            // employnowtab
            // 
            this.employnowtab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.employnowtab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employnowtab.Controls.Add(this.employnowsearchbtt);
            this.employnowtab.Controls.Add(this.employnowsearchtxt);
            this.employnowtab.Controls.Add(this.employnoweditbtt);
            this.employnowtab.Controls.Add(this.employnowaddbtt);
            this.employnowtab.Controls.Add(this.employnowmetroGrid1);
            this.employnowtab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employnowtab.HorizontalScrollbarBarColor = true;
            this.employnowtab.HorizontalScrollbarHighlightOnWheel = false;
            this.employnowtab.HorizontalScrollbarSize = 10;
            this.employnowtab.Location = new System.Drawing.Point(4, 38);
            this.employnowtab.Name = "employnowtab";
            this.employnowtab.Size = new System.Drawing.Size(710, 407);
            this.employnowtab.TabIndex = 0;
            this.employnowtab.Text = "Danh Sách Nhân Viên";
            this.employnowtab.UseCustomBackColor = true;
            this.employnowtab.UseCustomForeColor = true;
            this.employnowtab.VerticalScrollbarBarColor = true;
            this.employnowtab.VerticalScrollbarHighlightOnWheel = false;
            this.employnowtab.VerticalScrollbarSize = 10;
            // 
            // employnowsearchbtt
            // 
            this.employnowsearchbtt.BackColor = System.Drawing.Color.Lavender;
            this.employnowsearchbtt.Location = new System.Drawing.Point(165, 3);
            this.employnowsearchbtt.Name = "employnowsearchbtt";
            this.employnowsearchbtt.Size = new System.Drawing.Size(63, 38);
            this.employnowsearchbtt.TabIndex = 6;
            this.employnowsearchbtt.Text = "Tìm Kiếm";
            this.employnowsearchbtt.UseCustomBackColor = true;
            this.employnowsearchbtt.UseSelectable = true;
            this.employnowsearchbtt.Click += new System.EventHandler(this.employnowsearchbtt_Click);
            // 
            // employnowsearchtxt
            // 
            // 
            // 
            // 
            this.employnowsearchtxt.CustomButton.Image = null;
            this.employnowsearchtxt.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.employnowsearchtxt.CustomButton.Name = "";
            this.employnowsearchtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.employnowsearchtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.employnowsearchtxt.CustomButton.TabIndex = 1;
            this.employnowsearchtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.employnowsearchtxt.CustomButton.UseSelectable = true;
            this.employnowsearchtxt.CustomButton.Visible = false;
            this.employnowsearchtxt.Lines = new string[0];
            this.employnowsearchtxt.Location = new System.Drawing.Point(234, 12);
            this.employnowsearchtxt.MaxLength = 32767;
            this.employnowsearchtxt.Name = "employnowsearchtxt";
            this.employnowsearchtxt.PasswordChar = '\0';
            this.employnowsearchtxt.PromptText = "nhập từ khóa...";
            this.employnowsearchtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.employnowsearchtxt.SelectedText = "";
            this.employnowsearchtxt.SelectionLength = 0;
            this.employnowsearchtxt.SelectionStart = 0;
            this.employnowsearchtxt.ShortcutsEnabled = true;
            this.employnowsearchtxt.Size = new System.Drawing.Size(220, 23);
            this.employnowsearchtxt.TabIndex = 5;
            this.employnowsearchtxt.UseSelectable = true;
            this.employnowsearchtxt.WaterMark = "nhập từ khóa...";
            this.employnowsearchtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.employnowsearchtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // employnoweditbtt
            // 
            this.employnoweditbtt.BackColor = System.Drawing.Color.Lavender;
            this.employnoweditbtt.Location = new System.Drawing.Point(570, 3);
            this.employnoweditbtt.Name = "employnoweditbtt";
            this.employnoweditbtt.Size = new System.Drawing.Size(50, 38);
            this.employnoweditbtt.TabIndex = 4;
            this.employnoweditbtt.Text = "sửa/xóa";
            this.employnoweditbtt.UseCustomBackColor = true;
            this.employnoweditbtt.UseSelectable = true;
            this.employnoweditbtt.Click += new System.EventHandler(this.employnoweditbtt_Click);
            // 
            // employnowaddbtt
            // 
            this.employnowaddbtt.BackColor = System.Drawing.Color.Lavender;
            this.employnowaddbtt.Location = new System.Drawing.Point(481, 2);
            this.employnowaddbtt.Name = "employnowaddbtt";
            this.employnowaddbtt.Size = new System.Drawing.Size(50, 38);
            this.employnowaddbtt.TabIndex = 3;
            this.employnowaddbtt.Text = "Thêm";
            this.employnowaddbtt.UseCustomBackColor = true;
            this.employnowaddbtt.UseSelectable = true;
            this.employnowaddbtt.Click += new System.EventHandler(this.employnowaddbtt_Click);
            // 
            // employnowmetroGrid1
            // 
            this.employnowmetroGrid1.AllowUserToResizeRows = false;
            this.employnowmetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.employnowmetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employnowmetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.employnowmetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employnowmetroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.employnowmetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employnowmetroGrid1.DefaultCellStyle = dataGridViewCellStyle8;
            this.employnowmetroGrid1.EnableHeadersVisualStyles = false;
            this.employnowmetroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.employnowmetroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.employnowmetroGrid1.Location = new System.Drawing.Point(2, 46);
            this.employnowmetroGrid1.Name = "employnowmetroGrid1";
            this.employnowmetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employnowmetroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.employnowmetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.employnowmetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employnowmetroGrid1.Size = new System.Drawing.Size(699, 357);
            this.employnowmetroGrid1.TabIndex = 2;
            // 
            // historyemploytab
            // 
            this.historyemploytab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.historyemploytab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historyemploytab.Controls.Add(this.employhissearchbtt);
            this.historyemploytab.Controls.Add(this.employhissearchtxt);
            this.historyemploytab.Controls.Add(this.employhismetroGrid1);
            this.historyemploytab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyemploytab.HorizontalScrollbarBarColor = true;
            this.historyemploytab.HorizontalScrollbarHighlightOnWheel = false;
            this.historyemploytab.HorizontalScrollbarSize = 10;
            this.historyemploytab.Location = new System.Drawing.Point(4, 38);
            this.historyemploytab.Name = "historyemploytab";
            this.historyemploytab.Size = new System.Drawing.Size(710, 407);
            this.historyemploytab.TabIndex = 1;
            this.historyemploytab.Text = "Lịch Sử";
            this.historyemploytab.UseCustomBackColor = true;
            this.historyemploytab.UseCustomForeColor = true;
            this.historyemploytab.VerticalScrollbarBarColor = true;
            this.historyemploytab.VerticalScrollbarHighlightOnWheel = false;
            this.historyemploytab.VerticalScrollbarSize = 10;
            // 
            // employhissearchbtt
            // 
            this.employhissearchbtt.BackColor = System.Drawing.Color.Lavender;
            this.employhissearchbtt.Location = new System.Drawing.Point(206, 3);
            this.employhissearchbtt.Name = "employhissearchbtt";
            this.employhissearchbtt.Size = new System.Drawing.Size(63, 38);
            this.employhissearchbtt.TabIndex = 8;
            this.employhissearchbtt.Text = "Tìm Kiếm";
            this.employhissearchbtt.UseCustomBackColor = true;
            this.employhissearchbtt.UseSelectable = true;
            this.employhissearchbtt.Click += new System.EventHandler(this.employhissearchbtt_Click);
            // 
            // employhissearchtxt
            // 
            // 
            // 
            // 
            this.employhissearchtxt.CustomButton.Image = null;
            this.employhissearchtxt.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.employhissearchtxt.CustomButton.Name = "";
            this.employhissearchtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.employhissearchtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.employhissearchtxt.CustomButton.TabIndex = 1;
            this.employhissearchtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.employhissearchtxt.CustomButton.UseSelectable = true;
            this.employhissearchtxt.CustomButton.Visible = false;
            this.employhissearchtxt.Lines = new string[0];
            this.employhissearchtxt.Location = new System.Drawing.Point(275, 12);
            this.employhissearchtxt.MaxLength = 32767;
            this.employhissearchtxt.Name = "employhissearchtxt";
            this.employhissearchtxt.PasswordChar = '\0';
            this.employhissearchtxt.PromptText = "nhập từ khóa...";
            this.employhissearchtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.employhissearchtxt.SelectedText = "";
            this.employhissearchtxt.SelectionLength = 0;
            this.employhissearchtxt.SelectionStart = 0;
            this.employhissearchtxt.ShortcutsEnabled = true;
            this.employhissearchtxt.Size = new System.Drawing.Size(220, 23);
            this.employhissearchtxt.TabIndex = 7;
            this.employhissearchtxt.UseSelectable = true;
            this.employhissearchtxt.WaterMark = "nhập từ khóa...";
            this.employhissearchtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.employhissearchtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // employhismetroGrid1
            // 
            this.employhismetroGrid1.AllowUserToResizeRows = false;
            this.employhismetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.employhismetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employhismetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.employhismetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employhismetroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.employhismetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employhismetroGrid1.DefaultCellStyle = dataGridViewCellStyle11;
            this.employhismetroGrid1.EnableHeadersVisualStyles = false;
            this.employhismetroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.employhismetroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.employhismetroGrid1.Location = new System.Drawing.Point(2, 46);
            this.employhismetroGrid1.Name = "employhismetroGrid1";
            this.employhismetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employhismetroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.employhismetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.employhismetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employhismetroGrid1.Size = new System.Drawing.Size(699, 357);
            this.employhismetroGrid1.TabIndex = 3;
            // 
            // frEmploy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 455);
            this.ControlBox = false;
            this.Controls.Add(this.tabemploys);
            this.Movable = false;
            this.Name = "frEmploy";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.tabemploys.ResumeLayout(false);
            this.employnowtab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employnowmetroGrid1)).EndInit();
            this.historyemploytab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employhismetroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabemploys;
        private MetroFramework.Controls.MetroTabPage employnowtab;
        private MetroFramework.Controls.MetroButton employnowsearchbtt;
        private MetroFramework.Controls.MetroTextBox employnowsearchtxt;
        private MetroFramework.Controls.MetroButton employnoweditbtt;
        private MetroFramework.Controls.MetroButton employnowaddbtt;
        private MetroFramework.Controls.MetroGrid employnowmetroGrid1;
        private MetroFramework.Controls.MetroTabPage historyemploytab;
        private MetroFramework.Controls.MetroButton employhissearchbtt;
        private MetroFramework.Controls.MetroTextBox employhissearchtxt;
        private MetroFramework.Controls.MetroGrid employhismetroGrid1;
    }
}