using System;
using System.Windows.Forms;

namespace chatClient
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm() 
        {
            InitializeComponent();
        }

        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            string Name;
            string Password;
            string RePassword;
            if (TxtBoxRegName.Text != String.Empty && TxtBoxRegPass.Text != String.Empty
                && TxtBoxRegRePass.Text != String.Empty)
            {
                Name = TxtBoxRegName.Text;
                Password = TxtBoxRegPass.Text;
                RePassword = TxtBoxRegRePass.Text;
                if (Password == RePassword)
                {
                    Registration(Name, Program.Chf.GetHashString(Password));
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Registration(string Name, string HashPassword)
        {
            Program.Chf.Send($"#registr&{Name}~{HashPassword}");
            this.Close();
        }
    }
}
