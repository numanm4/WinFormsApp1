using System;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ChatForm : Form
    {
        private string userName;

        public ChatForm(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            this.Text = $"Awesome Chat - {userName}";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                string message = $"{userName}: {txtMessage.Text}";
                lstMessages.Items.Add(message);

                // Send the message to the server
                string responseMessage = Program.SendMessage(message);

                // Optionally display the response from the server in the list
                if (!string.IsNullOrEmpty(responseMessage))
                {
                    lstMessages.Items.Add($"Server: {responseMessage}");
                }

                // Display the message in the console
                Console.WriteLine(message);

                txtMessage.Clear();
            }
        }
    }
}
