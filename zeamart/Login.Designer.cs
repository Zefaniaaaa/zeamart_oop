namespace zeamart
{
    partial class Login
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
            t_username = new TextBox();
            t_password = new TextBox();
            b_login = new Button();
            SuspendLayout();
            // 
            // t_username
            // 
            t_username.Location = new Point(263, 146);
            t_username.Name = "t_username";
            t_username.Size = new Size(267, 31);
            t_username.TabIndex = 0;
            // 
            // t_password
            // 
            t_password.Location = new Point(263, 209);
            t_password.Name = "t_password";
            t_password.PasswordChar = '*';
            t_password.Size = new Size(267, 31);
            t_password.TabIndex = 1;
            // 
            // b_login
            // 
            b_login.Location = new Point(401, 273);
            b_login.Name = "b_login";
            b_login.Size = new Size(129, 39);
            b_login.TabIndex = 2;
            b_login.Text = "login";
            b_login.UseVisualStyleBackColor = true;
            b_login.Click += b_login_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(b_login);
            Controls.Add(t_password);
            Controls.Add(t_username);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox t_username;
        private TextBox t_password;
        private Button b_login;
    }
}