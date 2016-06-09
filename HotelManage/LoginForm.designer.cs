namespace HotelManager
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtLogInId = new System.Windows.Forms.TextBox();
            this.txtLogInPwd = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLogInId
            // 
            this.txtLogInId.Location = new System.Drawing.Point(231, 144);
            this.txtLogInId.Name = "txtLogInId";
            this.txtLogInId.Size = new System.Drawing.Size(122, 21);
            this.txtLogInId.TabIndex = 0;
            // 
            // txtLogInPwd
            // 
            this.txtLogInPwd.Location = new System.Drawing.Point(231, 173);
            this.txtLogInPwd.Name = "txtLogInPwd";
            this.txtLogInPwd.PasswordChar = '*';
            this.txtLogInPwd.Size = new System.Drawing.Size(122, 21);
            this.txtLogInPwd.TabIndex = 1;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogIn.Location = new System.Drawing.Point(216, 222);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "登录";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(321, 222);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(497, 304);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtLogInPwd);
            this.Controls.Add(this.txtLogInId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogInId;
        private System.Windows.Forms.TextBox txtLogInPwd;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnCancel;
    }
}