using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        private const string FilePath = "user.json";

        public Login()
        {
            InitializeComponent();
            LoadUserName();
        }

        private void LoadUserName()
        {
            if (File.Exists(FilePath))
            {
                var jsonData = File.ReadAllText(FilePath);
                var savedUser = JsonConvert.DeserializeObject<User>(jsonData);
                if (savedUser != null)
                {
                    txtName.Text = savedUser.Name;
                    chkRememberMe.Checked = true;
                }
            }
        }

        private void btnEnterChat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chkRememberMe.Checked)
            {
                var user = new User { Name = txtName.Text };
                var jsonData = JsonConvert.SerializeObject(user);
                File.WriteAllText(FilePath, jsonData);
            }
            else
            {
                if (File.Exists(FilePath))
                {
                    File.Delete(FilePath);
                }
            }

            var chatForm = new ChatForm(txtName.Text);
            chatForm.Show();
            this.Hide();
        }
    }

    public class User
    {
        public string Name { get; set; }
    }
}

//"C:\Users\Numan\Downloads\BVC_App_Dev-Task_2_Initial_code\BVC_App_Dev-Task_2_Initial_code\Code\Preparations\Forms\WinFormsApp1\WinFormsApp1\bin\Debug\net6.0-windows\user.json"