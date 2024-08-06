namespace WinFormsApp1
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
            txtName = new TextBox();
            chkRememberMe = new CheckBox();
            btnEnterChat = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(70, 157);
            txtName.Name = "txtName";
            txtName.Size = new Size(193, 27);
            txtName.TabIndex = 0;
            txtName.Text = "User Name";
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Location = new Point(106, 275);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(129, 24);
            chkRememberMe.TabIndex = 1;
            chkRememberMe.Text = "Remember Me";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // btnEnterChat
            // 
            btnEnterChat.Location = new Point(93, 211);
            btnEnterChat.Name = "btnEnterChat";
            btnEnterChat.Size = new Size(142, 29);
            btnEnterChat.TabIndex = 2;
            btnEnterChat.Text = "Enter Chat";
            btnEnterChat.UseVisualStyleBackColor = true;
            btnEnterChat.Click += btnEnterChat_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 442);
            Controls.Add(btnEnterChat);
            Controls.Add(chkRememberMe);
            Controls.Add(txtName);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private CheckBox chkRememberMe;
        private Button btnEnterChat;
    }
}