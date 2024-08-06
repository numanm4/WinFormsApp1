namespace WinFormsApp1
{
    partial class ChatForm
    {
        private System.ComponentModel.IContainer components = null;

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
            lstMessages = new ListBox();
            txtMessage = new TextBox();
            btnSend = new Button();
            SuspendLayout();
             
            // Textbox (lstMessages) 
            
            lstMessages.FormattingEnabled = true;
            lstMessages.ItemHeight = 20;
            lstMessages.Location = new Point(12, 15);
            lstMessages.Margin = new Padding(3, 4, 3, 4);
            lstMessages.Name = "lstMessages";
            lstMessages.Size = new Size(776, 444);
            lstMessages.TabIndex = 0;
            //
            // Listbox (txtMessage)
            // 
            txtMessage.Location = new Point(12, 468);
            txtMessage.Margin = new Padding(3, 4, 3, 4);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(666, 90);
            txtMessage.TabIndex = 1;
            // 
            // Send Button (btnSend
            //  
            btnSend.Location = new Point(684, 466);
            btnSend.Margin = new Padding(3, 4, 3, 4);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(104, 29);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            //
            // Chat User-Interface
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(lstMessages);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChatForm";
            Text = "Awesome Chat";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ListBox lstMessages;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
    }
}
#endregion