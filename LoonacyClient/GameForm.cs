

using System;
using System.Linq;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace LoonacyClient
{
    public partial class GameForm : Form
    {
        private Client _client;
        private string _nickname;
        private string _firstKolodaSbrosa;
        private string _secondKolodaSbrosa;
        private List<string> _MyKoloda;
        private List<string> _additionalKoloda;
        private string _query;



        private void AnimateCardMove(PictureBox card, PictureBox targetPile)
        {
            if (card == null || targetPile == null) return;

            this.Invoke((MethodInvoker)delegate
            {
                PictureBox animatedCard = new PictureBox
                {
                    Image = card.Image,
                    Size = card.Size,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(card.Location.X + KolodaPanel.Location.X, card.Location.Y),
                    BackColor = Color.Transparent
                };

                this.Controls.Add(animatedCard);
                animatedCard.BringToFront();

                var targX = targetPile.Location.X + KolodaPanel.Location.X;
                var targY = targetPile.Location.Y + KolodaPanel.Location.Y;

                Timer animationTimer = new Timer { Interval = 15 };
                double step = 10.0;
                double dx = (targX - animatedCard.Location.X) / step;
                double dy = (targY - animatedCard.Location.Y) / step;

                animationTimer.Tick += (sender, e) =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        // Обновляем позицию карты
                        animatedCard.Left += (int)Math.Round(dx);
                        animatedCard.Top += (int)Math.Round(dy);

                        // Проверяем, достигли ли мы целевой позиции
                        if (Math.Abs(animatedCard.Left - targX) <= Math.Abs(dx) &&
                            Math.Abs(animatedCard.Top - targY) <= Math.Abs(dy))
                        {
                            // Останавливаем таймер и завершаем анимацию
                            animatedCard.Location = targetPile.Location;
                            animationTimer.Stop();
                            animationTimer.Dispose();
                            animatedCard.Visible = false;
                            this.Controls.Remove(animatedCard);
                            animatedCard.Dispose();

                            // Устанавливаем точную позицию для целевой колоды
                            targetPile.Image = card.Image;
                            card.Visible = false;
                        }
                    });
                };

                animationTimer.Start();
            });
        }


        private void CardMove(string card, string target)
        {
            var cardImage = GetCardImage(card);
            var koloda = string.Join("&&", _additionalKoloda);
            PictureBox targetPile = null;
            PictureBox selectedCard = null;

            switch (card)
            {
                case "Card1": selectedCard = Card1; break;
                case "Card2": selectedCard = Card2; break;
                case "Card3": selectedCard = Card3; break;
                case "Card4": selectedCard = Card4; break;
                case "Card5": selectedCard = Card5; break;
                case "Card6": selectedCard = Card6; break;
                case "Card7": selectedCard = Card7; break;
            }

            switch (target)
            {
                case "pictureBox1":
                    _firstKolodaSbrosa = cardImage;
                    targetPile = pictureBox1;
                    break;
                case "pictureBox2":
                    _secondKolodaSbrosa = cardImage;
                    targetPile = pictureBox2;
                    break;
            }

            if (selectedCard != null && targetPile != null)
            {
                AnimateCardMove(selectedCard, targetPile);
            }

            _client.SendMessage($"UPDATE|{_nickname}|{_firstKolodaSbrosa}|{_secondKolodaSbrosa}|{koloda}|KSBROSA");
            DeleteCard(card);
        }















        private void DeleteCard(string card)
        {
            int cardIndex = -1;
            switch (card)
            {
                case "Card1":
                    cardIndex = 0;
                    HideCard(Card1);
                    break;
                case "Card2":
                    cardIndex = 1;
                    HideCard(Card2);
                    break;
                case "Card3":
                    cardIndex = 2;
                    HideCard(Card3);
                    break;
                case "Card4":
                    cardIndex = 3;
                    HideCard(Card4);
                    break;
                case "Card5":
                    cardIndex = 4;
                    HideCard(Card5);
                    break;
                case "Card6":
                    cardIndex = 5;
                    HideCard(Card6);
                    break;
                case "Card7":
                    cardIndex = 6;
                    HideCard(Card7);
                    break;
            }
        }

        private void HideCard(PictureBox card)
        {
            if (card.InvokeRequired)
            {
                card.Invoke(new Action(() => card.Visible = false));
            }
            else
            {
                card.Visible = false;
            }
        }







        private void UpdateKolodaSbrosa(string first, string second)
        {
            Image cardImage = Image.FromFile($"Cards/{second}.jpg");
            var targetLocation = new Point(100, 100);
            if (_firstKolodaSbrosa == first)
            {
                cardImage = Image.FromFile($"Cards/{second}.jpg");
                targetLocation = pictureBox2.Location;
            }
            else if (_secondKolodaSbrosa == second)
            {
                cardImage = Image.FromFile($"Cards/{first}.jpg");
                targetLocation = pictureBox1.Location;
            }


            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    CreateAndAddAnimatedCard(cardImage, targetLocation, first, second);
                });
            }
            else
            {
                CreateAndAddAnimatedCard(cardImage, targetLocation, first, second);
            }
        }

        private void CreateAndAddAnimatedCard(Image cardImage, Point targetLocation, string first, string second)
        {
            PictureBox animatedCard = new PictureBox
            {
                Image = cardImage,
                Size = new Size(pictureBox1.Width, pictureBox1.Height),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent,
                Location = new Point(targetLocation.X + KolodaPanel.Location.X, 0)
            };

            this.Controls.Add(animatedCard);
            animatedCard.BringToFront();

            Timer animationTimer = new Timer();
            animationTimer.Interval = 50;
            int step = 5;

            animationTimer.Tick += (sender, e) =>
            {
                if (animatedCard.Location.Y < targetLocation.Y)
                {
                    animatedCard.Top += step;
                }
                else
                {
                    animationTimer.Stop();
                    animationTimer.Dispose();
                    this.Controls.Remove(animatedCard);
                    animatedCard.Dispose();


                    SimpleUpdate(first, second);

                }
            };

            animationTimer.Start();
        }



        private void SimpleUpdate(string first, string second)
        {
            if (_firstKolodaSbrosa == first)
            {

                _secondKolodaSbrosa = second;
                pictureBox2.Image = Image.FromFile($"Cards/{second}.jpg");
            }
            else if (_secondKolodaSbrosa == second)
            {

                _firstKolodaSbrosa = first;
                pictureBox1.Image = Image.FromFile($"Cards/{first}.jpg");
            }
        }



        public GameForm(Client client, string nickname)
        {
            InitializeComponent();
            _client = client;
            _nickname = nickname;
            _client.OnMessageReceived += Client_OnMessageReceived;
            _client.SendMessage($"JOIN|{_nickname}");

            InitializeCardEvents();
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
                        NicknameLabel.Text = parts[1];
                    }
                    _MyKoloda = parts[2].Split("&&").ToList();
                    _additionalKoloda = _MyKoloda.ToList();
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
                case "PLAYERS":
                    PlayerListBox.Invoke((MethodInvoker)delegate
                    {
                        PlayerListBox.Items.Clear();
                        PlayerListBox.Items.AddRange(parts[1].Split("&&"));
                    });
                    break;
                case "UPDATE":
                    if (parts[5] == "KSBROSA")
                    {
                        if (parts[1] == _nickname)
                            SimpleUpdate(parts[2], parts[3]);
                        else
                            UpdateKolodaSbrosa(parts[2], parts[3]);
                    }
                    break;
                case "MOVE":
                    var card = GetCardImage(parts[2]);
                    var target = GetCardImage(parts[3]);
                    _additionalKoloda.Remove(card);
                    var cardList = card.Split("_").ToList();
                    var targetList = target.Split("_").ToList();

                    if (targetList.Contains(cardList[0]) || targetList.Contains(cardList[1]))
                    {
                        ChatTextBox.Invoke((MethodInvoker)delegate
                        {
                            ChatTextBox.AppendText($"Console: {parts[1]} moved card {card} on {target}.\n");
                        });
                        CardMove(parts[2], parts[3]);
                    }
                    _query = "";
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

        private string GetCardImage(string card)
        {
            var result = "";
            switch (card)
            {
                case "Card1":
                    result = _MyKoloda[0];
                    break;
                case "Card2":
                    result = _MyKoloda[1];
                    break;
                case "Card3":
                    result = _MyKoloda[2];
                    break;
                case "Card4":
                    result = _MyKoloda[3];
                    break;
                case "Card5":
                    result = _MyKoloda[4];
                    break;
                case "Card6":
                    result = _MyKoloda[5];
                    break;
                case "Card7":
                    result = _MyKoloda[6];
                    break;
                case "pictureBox1":
                    result = _firstKolodaSbrosa;
                    break;
                case "pictureBox2":
                    result = _secondKolodaSbrosa;
                    break;
            }
            return result;
        }




        private PictureBox currentlyEnlargedCard = null;
        private int enlargeSize = 10;

        private void SetupCardEvents(PictureBox card)
        {
            card.Click += Card_Click;
        }

        private void Card_Click(object sender, EventArgs e)
        {
            PictureBox card = sender as PictureBox;

            if (currentlyEnlargedCard != null && currentlyEnlargedCard != card)
            {
                ResizeCardFromCenter(currentlyEnlargedCard, -enlargeSize);
            }

            ResizeCardFromCenter(card, enlargeSize);
            currentlyEnlargedCard = card;

            string cardName = card.Name;
            GetCardFromHands(cardName);
        }

        private void ResizeCardFromCenter(PictureBox card, int sizeChange)
        {
            int newWidth = card.Width + sizeChange;
            int newHeight = card.Height + sizeChange;

            int left = card.Left - sizeChange / 2;
            int top = card.Top - sizeChange / 2;

            card.Size = new Size(newWidth, newHeight);
            card.Location = new Point(left, top);
        }

        private void InitializeCardEvents()
        {
            SetupCardEvents(Card1);
            SetupCardEvents(Card2);
            SetupCardEvents(Card3);
            SetupCardEvents(Card4);
            SetupCardEvents(Card5);
            SetupCardEvents(Card6);
            SetupCardEvents(Card7);
        }






        private void PassButton_Click(object sender, EventArgs e)
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
                KolodaPanel.Visible = true;
            }
        }


        private void KrupieNasral()
        {
            pictureBox1.Image = Image.FromFile($"Cards/{_firstKolodaSbrosa}.jpg");
            pictureBox2.Image = Image.FromFile($"Cards/{_secondKolodaSbrosa}.jpg");

            Card1.Image = Image.FromFile($"Cards/{_MyKoloda[0]}.jpg");
            Card2.Image = Image.FromFile($"Cards/{_MyKoloda[1]}.jpg");
            Card3.Image = Image.FromFile($"Cards/{_MyKoloda[2]}.jpg");
            Card4.Image = Image.FromFile($"Cards/{_MyKoloda[3]}.jpg");
            Card5.Image = Image.FromFile($"Cards/{_MyKoloda[4]}.jpg");
            Card6.Image = Image.FromFile($"Cards/{_MyKoloda[5]}.jpg");
            Card7.Image = Image.FromFile($"Cards/{_MyKoloda[6]}.jpg");


        }
        private void Card1_Click(object sender, EventArgs e)
        {
            GetCardFromHands("Card1");
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            GetCardFromHands("Card2");
        }

        private void Card3_Click(object sender, EventArgs e)
        {
            GetCardFromHands("Card3");
        }

        private void Card4_Click(object sender, EventArgs e)
        {
            GetCardFromHands("Card4");
        }

        private void Card5_Click(object sender, EventArgs e)
        {
            GetCardFromHands("Card5");
        }

        private void Card6_Click(object sender, EventArgs e)
        {
            GetCardFromHands("Card6");
        }

        private void Card7_Click(object sender, EventArgs e)
        {
            GetCardFromHands("Card7");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (_query != "")
            {
                _query += $"pictureBox1";
                _client.SendMessage(_query);
            }


        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (_query != "")
            {
                _query += $"pictureBox2";
                _client.SendMessage(_query);
            }
        }

        private void GetCardFromHands(string cardName)
        {
            _query = $"MOVE|{_nickname}|{cardName}|";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}