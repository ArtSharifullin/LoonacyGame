using System;
using System.Windows.Forms;

namespace LoonacyClient
{
    public partial class LoginForm : Form
    {
        public string Nickname { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Nickname = NicknameTextBox.Text;

            if (string.IsNullOrWhiteSpace(Nickname))
            {
                MessageBox.Show("Please enter both nickname and email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            DialogResult = DialogResult.OK;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}