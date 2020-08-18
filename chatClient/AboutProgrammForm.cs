using System;
using System.Windows.Forms;

namespace chatClient
{
    public partial class AboutProgrammForm : Form
    {
        public AboutProgrammForm()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
