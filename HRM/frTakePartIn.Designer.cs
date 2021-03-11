namespace FinalHRM
{
    partial class frTakePartIn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabtpi = new MetroFramework.Controls.MetroTabControl();
            this.tpintab = new MetroFramework.Controls.MetroTabPage();
            this.tpinowsearchbtt = new MetroFramework.Controls.MetroButton();
            this.tpinowsearchtxt = new MetroFramework.Controls.MetroTextBox();
            this.tpinowaddbtt = new MetroFramework.Controls.MetroButton();
            this.tpinowmetroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.histpitab = new MetroFramework.Controls.MetroTabPage();
            this.tpihissearchbtt = new MetroFramework.Controls.MetroButton();
            this.tpihissearchtxt = new MetroFramework.Controls.MetroTextBox();
            this.tpihismetroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.tpinoweditbtt = new MetroFramework.Controls.MetroButton();
            this.tabtpi.SuspendLayout();
            this.tpintab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tpinowmetroGrid1)).BeginInit();
            this.histpitab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tpihismetroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabtpi
            // 
            this.tabtpi.Controls.Add(this.tpintab);
            this.tabtpi.Controls.Add(this.histpitab);
            this.tabtpi.Location = new System.Drawing.Point(0, 3);
            this.tabtpi.Name = "tabtpi";
            this.tabtpi.SelectedIndex = 0;
            this.tabtpi.Size = new System.Drawing.Size(718, 449);
            this.tabtpi.TabIndex = 6;
            this.tabtpi.UseSelectable = true;
            // 
            // tpintab
            // 
            this.tpintab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpintab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpintab.Controls.Add(this.tpinowsearchbtt);
            this.tpintab.Controls.Add(this.tpinowsearchtxt);
            this.tpintab.Controls.Add(this.tpinoweditbtt);
            this.tpintab.Controls.Add(this.tpinowaddbtt);
            this.tpintab.Controls.Add(this.tpinowmetroGrid1);
            this.tpintab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpintab.HorizontalScrollbarBarColor = true;
            this.tpintab.HorizontalScrollbarHighlightOnWheel = false;
            this.tpintab.HorizontalScrollbarSize = 10;
            this.tpintab.Location = new System.Drawing.Point(4, 38);
            this.tpintab.Name = "tpintab";
            this.tpintab.Size = new System.Drawing.Size(710, 407);
            this.tpintab.TabIndex = 0;
            this.tpintab.Text = "Danh Sách Tham Gia Dự Án";
            this.tpintab.UseCustomBackColor = true;
            this.tpintab.UseCustomForeColor = true;
            this.tpintab.VerticalScrollbarBarColor = true;
            this.tpintab.VerticalScrollbarHighlightOnWheel = false;
            this.tpintab.VerticalScrollbarSize = 10;
            // 
            // tpinowsearchbtt
            // 
            this.tpinowsearchbtt.BackColor = System.Drawing.Color.Lavender;
            this.tpinowsearchbtt.Location = new System.Drawing.Point(165, 3);
            this.tpinowsearchbtt.Name = "tpinowsearchbtt";
            this.tpinowsearchbtt.Size = new System.Drawing.Size(63, 38);
            this.tpinowsearchbtt.TabIndex = 6;
            this.tpinowsearchbtt.Text = "Tìm Kiếm";
            this.tpinowsearchbtt.UseCustomBackColor = true;
            this.tpinowsearchbtt.UseSelectable = true;
            this.tpinowsearchbtt.Click += new System.EventHandler(this.tpinowsearchbtt_Click);
            // 
            // tpinowsearchtxt
            // 
            // 
            // 
            // 
            this.tpinowsearchtxt.CustomButton.Image = null;
            this.tpinowsearchtxt.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.tpinowsearchtxt.CustomButton.Name = "";
            this.tpinowsearchtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tpinowsearchtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tpinowsearchtxt.CustomButton.TabIndex = 1;
            this.tpinowsearchtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tpinowsearchtxt.CustomButton.UseSelectable = true;
            this.tpinowsearchtxt.CustomButton.Visible = false;
            this.tpinowsearchtxt.Lines = new string[0];
            this.tpinowsearchtxt.Location = new System.Drawing.Point(234, 12);
            this.tpinowsearchtxt.MaxLength = 32767;
            this.tpinowsearchtxt.Name = "tpinowsearchtxt";
            this.tpinowsearchtxt.PasswordChar = '\0';
            this.tpinowsearchtxt.PromptText = "nhập từ khóa...";
            this.tpinowsearchtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tpinowsearchtxt.SelectedText = "";
            this.tpinowsearchtxt.SelectionLength = 0;
            this.tpinowsearchtxt.SelectionStart = 0;
            this.tpinowsearchtxt.ShortcutsEnabled = true;
            this.tpinowsearchtxt.Size = new System.Drawing.Size(220, 23);
            this.tpinowsearchtxt.TabIndex = 5;
            this.tpinowsearchtxt.UseSelectable = true;
            this.tpinowsearchtxt.WaterMark = "nhập từ khóa...";
            this.tpinowsearchtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tpinowsearchtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tpinowaddbtt
            // 
            this.tpinowaddbtt.BackColor = System.Drawing.Color.Lavender;
            this.tpinowaddbtt.Location = new System.Drawing.Point(481, 2);
            this.tpinowaddbtt.Name = "tpinowaddbtt";
            this.tpinowaddbtt.Size = new System.Drawing.Size(50, 38);
            this.tpinowaddbtt.TabIndex = 3;
            this.tpinowaddbtt.Text = "Thêm";
            this.tpinowaddbtt.UseCustomBackColor = true;
            this.tpinowaddbtt.UseSelectable = true;
            this.tpinowaddbtt.Click += new System.EventHandler(this.tpinowaddbtt_Click);
            // 
            // tpinowmetroGrid1
            // 
            this.tpinowmetroGrid1.AllowUserToResizeRows = false;
            this.tpinowmetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tpinowmetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tpinowmetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tpinowmetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tpinowmetroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.tpinowmetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tpinowmetroGrid1.DefaultCellStyle = dataGridViewCellStyle14;
            this.tpinowmetroGrid1.EnableHeadersVisualStyles = false;
            this.tpinowmetroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tpinowmetroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tpinowmetroGrid1.Location = new System.Drawing.Point(2, 46);
            this.tpinowmetroGrid1.Name = "tpinowmetroGrid1";
            this.tpinowmetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tpinowmetroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.tpinowmetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tpinowmetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tpinowmetroGrid1.Size = new System.Drawing.Size(699, 357);
            this.tpinowmetroGrid1.TabIndex = 2;
            // 
            // histpitab
            // 
            this.histpitab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.histpitab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.histpitab.Controls.Add(this.tpihissearchbtt);
            this.histpitab.Controls.Add(this.tpihissearchtxt);
            this.histpitab.Controls.Add(this.tpihismetroGrid1);
            this.histpitab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histpitab.HorizontalScrollbarBarColor = true;
            this.histpitab.HorizontalScrollbarHighlightOnWheel = false;
            this.histpitab.HorizontalScrollbarSize = 10;
            this.histpitab.Location = new System.Drawing.Point(4, 38);
            this.histpitab.Name = "histpitab";
            this.histpitab.Size = new System.Drawing.Size(710, 407);
            this.histpitab.TabIndex = 1;
            this.histpitab.Text = "Lịch Sử";
            this.histpitab.UseCustomBackColor = true;
            this.histpitab.UseCustomForeColor = true;
            this.histpitab.VerticalScrollbarBarColor = true;
            this.histpitab.VerticalScrollbarHighlightOnWheel = false;
            this.histpitab.VerticalScrollbarSize = 10;
            // 
            // tpihissearchbtt
            // 
            this.tpihissearchbtt.BackColor = System.Drawing.Color.Lavender;
            this.tpihissearchbtt.Location = new System.Drawing.Point(206, 3);
            this.tpihissearchbtt.Name = "tpihissearchbtt";
            this.tpihissearchbtt.Size = new System.Drawing.Size(63, 38);
            this.tpihissearchbtt.TabIndex = 8;
            this.tpihissearchbtt.Text = "Tìm Kiếm";
            this.tpihissearchbtt.UseCustomBackColor = true;
            this.tpihissearchbtt.UseSelectable = true;
            this.tpihissearchbtt.Click += new System.EventHandler(this.tpihissearchbtt_Click);
            // 
            // tpihissearchtxt
            // 
            // 
            // 
            // 
            this.tpihissearchtxt.CustomButton.Image = null;
            this.tpihissearchtxt.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.tpihissearchtxt.CustomButton.Name = "";
            this.tpihissearchtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tpihissearchtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tpihissearchtxt.CustomButton.TabIndex = 1;
            this.tpihissearchtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tpihissearchtxt.CustomButton.UseSelectable = true;
            this.tpihissearchtxt.CustomButton.Visible = false;
            this.tpihissearchtxt.Lines = new string[0];
            this.tpihissearchtxt.Location = new System.Drawing.Point(275, 12);
            this.tpihissearchtxt.MaxLength = 32767;
            this.tpihissearchtxt.Name = "tpihissearchtxt";
            this.tpihissearchtxt.PasswordChar = '\0';
            this.tpihissearchtxt.PromptText = "nhập từ khóa...";
            this.tpihissearchtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tpihissearchtxt.SelectedText = "";
            this.tpihissearchtxt.SelectionLength = 0;
            this.tpihissearchtxt.SelectionStart = 0;
            this.tpihissearchtxt.ShortcutsEnabled = true;
            this.tpihissearchtxt.Size = new System.Drawing.Size(220, 23);
            this.tpihissearchtxt.TabIndex = 7;
            this.tpihissearchtxt.UseSelectable = true;
            this.tpihissearchtxt.WaterMark = "nhập từ khóa...";
            this.tpihissearchtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tpihissearchtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tpihismetroGrid1
            // 
            this.tpihismetroGrid1.AllowUserToResizeRows = false;
            this.tpihismetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tpihismetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tpihismetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tpihismetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tpihismetroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.tpihismetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tpihismetroGrid1.DefaultCellStyle = dataGridViewCellStyle17;
            this.tpihismetroGrid1.EnableHeadersVisualStyles = false;
            this.tpihismetroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tpihismetroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tpihismetroGrid1.Location = new System.Drawing.Point(2, 46);
            this.tpihismetroGrid1.Name = "tpihismetroGrid1";
            this.tpihismetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tpihismetroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.tpihismetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tpihismetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tpihismetroGrid1.Size = new System.Drawing.Size(699, 357);
            this.tpihismetroGrid1.TabIndex = 3;
            // 
            // tpinoweditbtt
            // 
            this.tpinoweditbtt.BackColor = System.Drawing.Color.Lavender;
            this.tpinoweditbtt.Location = new System.Drawing.Point(570, 3);
            this.tpinoweditbtt.Name = "tpinoweditbtt";
            this.tpinoweditbtt.Size = new System.Drawing.Size(50, 38);
            this.tpinoweditbtt.TabIndex = 4;
            this.tpinoweditbtt.Text = "sửa/xóa";
            this.tpinoweditbtt.UseCustomBackColor = true;
            this.tpinoweditbtt.UseSelectable = true;
            this.tpinoweditbtt.Click += new System.EventHandler(this.tpinoweditbtt_Click);
            // 
            // frTakePartIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 455);
            this.Controls.Add(this.tabtpi);
            this.Name = "frTakePartIn";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.tabtpi.ResumeLayout(false);
            this.tpintab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tpinowmetroGrid1)).EndInit();
            this.histpitab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tpihismetroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabtpi;
        private MetroFramework.Controls.MetroTabPage tpintab;
        private MetroFramework.Controls.MetroButton tpinowsearchbtt;
        private MetroFramework.Controls.MetroTextBox tpinowsearchtxt;
        private MetroFramework.Controls.MetroButton tpinowaddbtt;
        private MetroFramework.Controls.MetroGrid tpinowmetroGrid1;
        private MetroFramework.Controls.MetroTabPage histpitab;
        private MetroFramework.Controls.MetroButton tpihissearchbtt;
        private MetroFramework.Controls.MetroTextBox tpihissearchtxt;
        private MetroFramework.Controls.MetroGrid tpihismetroGrid1;
        private MetroFramework.Controls.MetroButton tpinoweditbtt;
    }
}