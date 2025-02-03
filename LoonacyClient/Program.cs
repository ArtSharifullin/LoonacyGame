using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoonacyClient
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Client client = new Client("127.0.0.1", 5000);
                GameForm gameForm = new GameForm(client, loginForm.Nickname);
                Application.Run(gameForm);
            }
        }
    }
}