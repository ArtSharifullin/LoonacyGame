using System;
using System.Linq;
using System.Windows.Forms;

namespace LoonacyClient
{
    public partial class GameForm : Form
    {
        private Client _client;
        private string _nickname;
        private string _firstKolodaSbrosa;
        private string _secondKolodaSbrosa;
        private List<string> _MyKoloda;


        public GameForm(Client client, string nickname)
        {
            InitializeComponent();
            _client = client;
            _nickname = nickname;
            _client.OnMessageReceived += Client_OnMessageReceived;
            _client.SendMessage($"JOIN|{_nickname}");
        }

        private void Client_OnMessageReceived(object sender, string message)
        {
            string[] parts = message.Split('|');
            switch (parts[0])
            {
                case "JOIN":
                    if (parts[1] == "ERROR")
                    {
                        Error();
                        MessageBox.Show(parts[2], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        ChatTextBox.Invoke((MethodInvoker)delegate
                        {
                            ChatTextBox.AppendText($"Console: Player {parts[1]} joined the game.\n");
                        });
                    }
                    _MyKoloda = parts[2].Split("&&").ToList();
                    break;
                case "LEAVE":
                    ChatTextBox.Invoke((MethodInvoker)delegate
                    {
                        ChatTextBox.AppendText($"Console: Player {parts[1]} left the game.\n");
                    });
                    break;
                case "CHAT":
                    ChatTextBox.Invoke((MethodInvoker)delegate
                    {
                        ChatTextBox.AppendText($"{parts[1]}: {parts[2]}\n");
                    });
                    break;
                case "START_GAME":
                    var KolodaSbrosaList = parts[1].Split("&&");
                    _firstKolodaSbrosa = KolodaSbrosaList[0];
                    _secondKolodaSbrosa = KolodaSbrosaList[1];
                    StartGame();
                    ChatTextBox.AppendText("Console: Game was started !\n");
                    break;
                /*case "KOLODA":
                    if (parts[1] == "SBROS")
                    {
                        var KolodaSbrosaList = parts[2].Split("&&");
                        _firstKolodaSbrosa = KolodaSbrosaList[0];
                        _secondKolodaSbrosa = KolodaSbrosaList[1];
                        //(_firstKolodaSbrosa,_secondtKolodaSbrosa)=parts[2].Split("&&");
                    }
                    if (parts[1] == "PLAYER")
                    {
                        if (parts[2] == _nickname)
                        {
                            _MyKoloda = parts[3].Split("&&").ToList();
                        }
                    }
                    break;*/
                case "PLAYERS":
                    PlayerListBox.Invoke((MethodInvoker)delegate
                    {
                        PlayerListBox.Items.Clear();
                        PlayerListBox.Items.AddRange(parts[1].Split("&&"));
                    });
                    break;
                case "MOVE":
                    ChatTextBox.Invoke((MethodInvoker)delegate
                    {
                        ChatTextBox.AppendText($"{parts[1]} played card {parts[2]} on {parts[3]}.\n");
                    });
                    break;
                case "WIN":
                    ChatTextBox.Invoke((MethodInvoker)delegate
                    {
                        ChatTextBox.AppendText($"Console: Player {parts[1]} won the game!\n");
                    });
                    Win(parts[1]);
                    Close();
                    break;
            }
        }

        private void PassButton_Click(object sender, EventArgs e)
        {
            // Логика для кнопки Пасс
        }

        private void SurrenderButton_Click(object sender, EventArgs e)
        {
            _client.SendMessage($"LEAVE|{_nickname}");
            Close();
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            string message = MessageTextBox.Text;
            _client.SendMessage($"CHAT|{_nickname}|{message}");
            MessageTextBox.Clear();
        }

        private void PlayerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Error()
        {
            foreach (Control control in this.Controls)
            {
                control.Visible = false;

                // Если элемент является контейнером, скрываем все его дочерние элементы
                if (control is Panel panel)
                {
                    foreach (Control childControl in panel.Controls)
                    {
                        childControl.Visible = false;
                    }
                }
            }
        }

        private void Win(string nickname)
        {
            MessageBox.Show($"игрок {nickname} одержал победу !", "WIN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }



        private void StartGame()
        {
            KrupieNasral();
            if (CardsPanel.InvokeRequired || ButtonsPanel.InvokeRequired || KolodaPanel.InvokeRequired)
            {
                CardsPanel.Invoke(new Action(() => CardsPanel.Visible = true));
                ButtonsPanel.Invoke(new Action(() => ButtonsPanel.Visible = true));
                KolodaPanel.Invoke(new Action(() => KolodaPanel.Visible = true));
            }
            else
            {
                CardsPanel.Visible = true;
                ButtonsPanel.Visible = true;
                KolodaPanel.Visible= true;
            }
        }


        private void KrupieNasral()
        {
            pictureBox1.Image = Image.FromFile($"Cards/{_firstKolodaSbrosa}");
            pictureBox2.Image = Image.FromFile($"Cards/{_secondKolodaSbrosa}");

            Card1.Image = Image.FromFile($"Cards/{_MyKoloda[0]}");
            Card2.Image = Image.FromFile($"Cards/{_MyKoloda[1]}");
            Card3.Image = Image.FromFile($"Cards/{_MyKoloda[2]}");
            Card4.Image = Image.FromFile($"Cards/{_MyKoloda[3]}");
            Card5.Image = Image.FromFile($"Cards/{_MyKoloda[4]}");
            Card6.Image = Image.FromFile($"Cards/{_MyKoloda[5]}");
            Card7.Image = Image.FromFile($"Cards/{_MyKoloda[6]}");


        }

        private void Card2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Card1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}