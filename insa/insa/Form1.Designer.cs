namespace insa
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginbtn = new MetroFramework.Controls.MetroButton();
            this.Id = new MetroFramework.Controls.MetroTextBox();
            this.Password = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.saveid = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(343, 123);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(104, 60);
            this.loginbtn.TabIndex = 3;
            this.loginbtn.Text = "로그인";
            this.loginbtn.UseSelectable = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click_1);
            // 
            // Id
            // 
            // 
            // 
            // 
            this.Id.CustomButton.Image = null;
            this.Id.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.Id.CustomButton.Name = "";
            this.Id.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Id.CustomButton.TabIndex = 1;
            this.Id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Id.CustomButton.UseSelectable = true;
            this.Id.CustomButton.Visible = false;
            this.Id.Lines = new string[0];
            this.Id.Location = new System.Drawing.Point(181, 123);
            this.Id.MaxLength = 32767;
            this.Id.Name = "Id";
            this.Id.PasswordChar = '\0';
            this.Id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Id.SelectedText = "";
            this.Id.SelectionLength = 0;
            this.Id.SelectionStart = 0;
            this.Id.ShortcutsEnabled = true;
            this.Id.Size = new System.Drawing.Size(139, 23);
            this.Id.TabIndex = 1;
            this.Id.UseSelectable = true;
            this.Id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Password
            // 
            // 
            // 
            // 
            this.Password.CustomButton.Image = null;
            this.Password.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.Password.CustomButton.Name = "";
            this.Password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Password.CustomButton.TabIndex = 1;
            this.Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Password.CustomButton.UseSelectable = true;
            this.Password.CustomButton.Visible = false;
            this.Password.Lines = new string[0];
            this.Password.Location = new System.Drawing.Point(181, 160);
            this.Password.MaxLength = 32767;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Password.SelectedText = "";
            this.Password.SelectionLength = 0;
            this.Password.SelectionStart = 0;
            this.Password.ShortcutsEnabled = true;
            this.Password.Size = new System.Drawing.Size(139, 23);
            this.Password.TabIndex = 2;
            this.Password.UseSelectable = true;
            this.Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_KeyDown);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(154, 127);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(112, 164);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Password";
            // 
            // saveid
            // 
            this.saveid.AutoSize = true;
            this.saveid.Location = new System.Drawing.Point(201, 212);
            this.saveid.Name = "saveid";
            this.saveid.Size = new System.Drawing.Size(86, 15);
            this.saveid.TabIndex = 4;
            this.saveid.Text = "아이디 저장";
            this.saveid.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 296);
            this.Controls.Add(this.saveid);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.loginbtn);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Login";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton loginbtn;
        private MetroFramework.Controls.MetroTextBox Id;
        private MetroFramework.Controls.MetroTextBox Password;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox saveid;
    }
}

