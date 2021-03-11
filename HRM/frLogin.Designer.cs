namespace FinalHRM
{
    partial class frLogin
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
            this.login = new MetroFramework.Controls.MetroTile();
            this.loginbtt = new MetroFramework.Controls.MetroLabel();
            this.usertxt = new MetroFramework.Controls.MetroTextBox();
            this.passtxt = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.errortk = new System.Windows.Forms.ErrorProvider(this.components);
            this.login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortk)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.ActiveControl = null;
            this.login.Controls.Add(this.loginbtt);
            this.login.Location = new System.Drawing.Point(360, 147);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 0;
            this.login.Text = "metroTile1";
            this.login.UseSelectable = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // loginbtt
            // 
            this.loginbtt.AutoSize = true;
            this.loginbtt.Location = new System.Drawing.Point(17, 0);
            this.loginbtt.Name = "loginbtt";
            this.loginbtt.Size = new System.Drawing.Size(41, 19);
            this.loginbtt.TabIndex = 2;
            this.loginbtt.Text = "Login";
            this.loginbtt.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // usertxt
            // 
            // 
            // 
            // 
            this.usertxt.CustomButton.Image = null;
            this.usertxt.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.usertxt.CustomButton.Name = "";
            this.usertxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.usertxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usertxt.CustomButton.TabIndex = 1;
            this.usertxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usertxt.CustomButton.UseSelectable = true;
            this.usertxt.CustomButton.Visible = false;
            this.usertxt.DisplayIcon = true;
            this.usertxt.Icon = global::FinalHRM.Properties.Resources.user;
            this.usertxt.IconRight = true;
            this.usertxt.Lines = new string[0];
            this.usertxt.Location = new System.Drawing.Point(220, 54);
            this.usertxt.MaxLength = 32767;
            this.usertxt.Name = "usertxt";
            this.usertxt.PasswordChar = '\0';
            this.usertxt.PromptText = "Tên đăng nhập...";
            this.usertxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usertxt.SelectedText = "";
            this.usertxt.SelectionLength = 0;
            this.usertxt.SelectionStart = 0;
            this.usertxt.ShortcutsEnabled = true;
            this.usertxt.Size = new System.Drawing.Size(215, 23);
            this.usertxt.TabIndex = 1;
            this.usertxt.UseSelectable = true;
            this.usertxt.WaterMark = "Tên đăng nhập...";
            this.usertxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usertxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passtxt
            // 
            // 
            // 
            // 
            this.passtxt.CustomButton.Image = null;
            this.passtxt.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.passtxt.CustomButton.Name = "";
            this.passtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passtxt.CustomButton.TabIndex = 1;
            this.passtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passtxt.CustomButton.UseSelectable = true;
            this.passtxt.CustomButton.Visible = false;
            this.passtxt.DisplayIcon = true;
            this.passtxt.Icon = global::FinalHRM.Properties.Resources.icons_password_512;
            this.passtxt.IconRight = true;
            this.passtxt.Lines = new string[0];
            this.passtxt.Location = new System.Drawing.Point(220, 103);
            this.passtxt.MaxLength = 32767;
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '\0';
            this.passtxt.PromptText = "mật khẩu...";
            this.passtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passtxt.SelectedText = "";
            this.passtxt.SelectionLength = 0;
            this.passtxt.SelectionStart = 0;
            this.passtxt.ShortcutsEnabled = true;
            this.passtxt.Size = new System.Drawing.Size(215, 23);
            this.passtxt.TabIndex = 2;
            this.passtxt.UseSelectable = true;
            this.passtxt.WaterMark = "mật khẩu...";
            this.passtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FinalHRM.Properties.Resources.login_logo_png_wwwpixsharkcom_images_galleries_with_154260;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(37, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 131);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel2.Location = new System.Drawing.Point(275, 25);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "ĐĂNG NHẬP";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // errortk
            // 
            this.errortk.ContainerControl = this;
            // 
            // frLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalHRM.Properties.Resources.mainPage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(454, 179);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.login);
            this.Name = "frLogin";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile login;
        private MetroFramework.Controls.MetroLabel loginbtt;
        private MetroFramework.Controls.MetroTextBox usertxt;
        private MetroFramework.Controls.MetroTextBox passtxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ErrorProvider errortk;
    }
}

