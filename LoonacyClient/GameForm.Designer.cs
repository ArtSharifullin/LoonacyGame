namespace LoonacyClient
{
    partial class GameForm
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

        private void InitializeComponent()
        {
            LabelTitle = new Label();
            PlayersLabel = new Label();
            PlayerListBox = new ListBox();
            ChatPanel = new Panel();
            MessageTextBox = new TextBox();
            SendMessageButton = new Button();
            ChatTextBox = new RichTextBox();
            CardsPanel = new Panel();
            Card7 = new PictureBox();
            Card6 = new PictureBox();
            Card1 = new PictureBox();
            Card5 = new PictureBox();
            Card4 = new PictureBox();
            Card3 = new PictureBox();
            Card2 = new PictureBox();
            pictureBox2 = new PictureBox();
            ButtonsPanel = new Panel();
            PassButton = new Button();
            pictureBox1 = new PictureBox();
            KolodaPanel = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            NicknameLabel = new Label();
            RulesButton = new Button();
            ChatPanel.SuspendLayout();
            CardsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Card7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Card6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Card1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Card5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Card4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Card3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Card2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            KolodaPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.BackColor = Color.Transparent;
            LabelTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LabelTitle.ForeColor = SystemColors.Control;
            LabelTitle.Location = new Point(684, 9);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(124, 31);
            LabelTitle.TabIndex = 0;
            LabelTitle.Text = "Loonacy";
            // 
            // PlayersLabel
            // 
            PlayersLabel.AutoSize = true;
            PlayersLabel.BackColor = Color.Transparent;
            PlayersLabel.ForeColor = SystemColors.ControlLightLight;
            PlayersLabel.Location = new Point(12, 50);
            PlayersLabel.Name = "PlayersLabel";
            PlayersLabel.Size = new Size(58, 20);
            PlayersLabel.TabIndex = 1;
            PlayersLabel.Text = "Players:";
            // 
            // PlayerListBox
            // 
            PlayerListBox.BackColor = Color.DimGray;
            PlayerListBox.BorderStyle = BorderStyle.FixedSingle;
            PlayerListBox.ForeColor = SystemColors.ControlLightLight;
            PlayerListBox.FormattingEnabled = true;
            PlayerListBox.Location = new Point(12, 80);
            PlayerListBox.Margin = new Padding(3, 4, 3, 4);
            PlayerListBox.Name = "PlayerListBox";
            PlayerListBox.Size = new Size(200, 202);
            PlayerListBox.TabIndex = 2;
            PlayerListBox.SelectedIndexChanged += PlayerListBox_SelectedIndexChanged;
            // 
            // ChatPanel
            // 
            ChatPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ChatPanel.BackColor = Color.DimGray;
            ChatPanel.Controls.Add(MessageTextBox);
            ChatPanel.Controls.Add(SendMessageButton);
            ChatPanel.Controls.Add(ChatTextBox);
            ChatPanel.Location = new Point(2, 300);
            ChatPanel.Margin = new Padding(3, 4, 3, 4);
            ChatPanel.Name = "ChatPanel";
            ChatPanel.Size = new Size(222, 200);
            ChatPanel.TabIndex = 4;
            // 
            // MessageTextBox
            // 
            MessageTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MessageTextBox.Location = new Point(10, 160);
            MessageTextBox.Margin = new Padding(3, 4, 3, 4);
            MessageTextBox.Name = "MessageTextBox";
            MessageTextBox.Size = new Size(122, 27);
            MessageTextBox.TabIndex = 2;
            // 
            // SendMessageButton
            // 
            SendMessageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SendMessageButton.Location = new Point(137, 160);
            SendMessageButton.Margin = new Padding(3, 4, 3, 4);
            SendMessageButton.Name = "SendMessageButton";
            SendMessageButton.Size = new Size(80, 29);
            SendMessageButton.TabIndex = 1;
            SendMessageButton.Text = "Send";
            SendMessageButton.UseVisualStyleBackColor = true;
            SendMessageButton.Click += SendMessageButton_Click;
            // 
            // ChatTextBox
            // 
            ChatTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ChatTextBox.BackColor = Color.DarkGray;
            ChatTextBox.BorderStyle = BorderStyle.None;
            ChatTextBox.Location = new Point(10, 10);
            ChatTextBox.Margin = new Padding(3, 4, 3, 4);
            ChatTextBox.Name = "ChatTextBox";
            ChatTextBox.ReadOnly = true;
            ChatTextBox.Size = new Size(202, 140);
            ChatTextBox.TabIndex = 0;
            ChatTextBox.Text = "";
            // 
            // CardsPanel
            // 
            CardsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CardsPanel.BackColor = Color.Transparent;
            CardsPanel.Controls.Add(Card7);
            CardsPanel.Controls.Add(Card6);
            CardsPanel.Controls.Add(Card1);
            CardsPanel.Controls.Add(Card5);
            CardsPanel.Controls.Add(Card4);
            CardsPanel.Controls.Add(Card3);
            CardsPanel.Controls.Add(Card2);
            CardsPanel.Location = new Point(287, 300);
            CardsPanel.Margin = new Padding(3, 4, 3, 4);
            CardsPanel.Name = "CardsPanel";
            CardsPanel.Size = new Size(936, 304);
            CardsPanel.TabIndex = 5;
            CardsPanel.Visible = false;
            // 
            // Card7
            // 
            Card7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Card7.BackColor = Color.LightGray;
            Card7.Location = new Point(809, 10);
            Card7.Margin = new Padding(3, 4, 3, 4);
            Card7.Name = "Card7";
            Card7.Size = new Size(115, 220);
            Card7.TabIndex = 6;
            Card7.TabStop = false;
            Card7.Click += Card7_Click;
            // 
            // Card6
            // 
            Card6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Card6.BackColor = Color.LightGray;
            Card6.Location = new Point(679, 10);
            Card6.Margin = new Padding(3, 4, 3, 4);
            Card6.Name = "Card6";
            Card6.Size = new Size(115, 220);
            Card6.TabIndex = 5;
            Card6.TabStop = false;
            Card6.Click += Card6_Click;
            // 
            // Card1
            // 
            Card1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Card1.BackColor = Color.LightGray;
            Card1.Location = new Point(16, 10);
            Card1.Margin = new Padding(3, 4, 3, 4);
            Card1.Name = "Card1";
            Card1.Size = new Size(115, 220);
            Card1.TabIndex = 0;
            Card1.TabStop = false;
            Card1.Click += Card1_Click;
            // 
            // Card5
            // 
            Card5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Card5.BackColor = Color.LightGray;
            Card5.Location = new Point(547, 10);
            Card5.Margin = new Padding(3, 4, 3, 4);
            Card5.Name = "Card5";
            Card5.Size = new Size(115, 220);
            Card5.TabIndex = 4;
            Card5.TabStop = false;
            Card5.Click += Card5_Click;
            // 
            // Card4
            // 
            Card4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Card4.BackColor = Color.LightGray;
            Card4.Location = new Point(415, 10);
            Card4.Margin = new Padding(3, 4, 3, 4);
            Card4.Name = "Card4";
            Card4.Size = new Size(115, 220);
            Card4.TabIndex = 3;
            Card4.TabStop = false;
            Card4.Click += Card4_Click;
            // 
            // Card3
            // 
            Card3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Card3.BackColor = Color.LightGray;
            Card3.Location = new Point(280, 10);
            Card3.Margin = new Padding(3, 4, 3, 4);
            Card3.Name = "Card3";
            Card3.Size = new Size(115, 220);
            Card3.TabIndex = 2;
            Card3.TabStop = false;
            Card3.Click += Card3_Click;
            // 
            // Card2
            // 
            Card2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Card2.BackColor = Color.LightGray;
            Card2.Location = new Point(149, 10);
            Card2.Margin = new Padding(3, 4, 3, 4);
            Card2.Name = "Card2";
            Card2.Size = new Size(115, 220);
            Card2.TabIndex = 1;
            Card2.TabStop = false;
            Card2.Click += Card2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LightGray;
            pictureBox2.Location = new Point(303, 19);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(115, 220);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonsPanel.BackColor = Color.Transparent;
            ButtonsPanel.Controls.Add(RulesButton);
            ButtonsPanel.Controls.Add(PassButton);
            ButtonsPanel.Location = new Point(2, 508);
            ButtonsPanel.Margin = new Padding(3, 4, 3, 4);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.Size = new Size(222, 91);
            ButtonsPanel.TabIndex = 6;
            ButtonsPanel.Visible = false;
            // 
            // PassButton
            // 
            PassButton.BackColor = Color.MistyRose;
            PassButton.Location = new Point(0, 53);
            PassButton.Margin = new Padding(3, 4, 3, 4);
            PassButton.Name = "PassButton";
            PassButton.Size = new Size(222, 38);
            PassButton.TabIndex = 0;
            PassButton.Text = "Surrende";
            PassButton.UseVisualStyleBackColor = false;
            PassButton.Click += PassButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.Location = new Point(500, 19);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 220);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // KolodaPanel
            // 
            KolodaPanel.BackColor = Color.Transparent;
            KolodaPanel.Controls.Add(pictureBox2);
            KolodaPanel.Controls.Add(pictureBox1);
            KolodaPanel.Location = new Point(287, 50);
            KolodaPanel.Name = "KolodaPanel";
            KolodaPanel.Size = new Size(878, 243);
            KolodaPanel.TabIndex = 9;
            KolodaPanel.Visible = false;
            // 
            // NicknameLabel
            // 
            NicknameLabel.AutoSize = true;
            NicknameLabel.BackColor = Color.Transparent;
            NicknameLabel.Font = new Font("Segoe UI", 15F);
            NicknameLabel.ForeColor = SystemColors.ControlLightLight;
            NicknameLabel.Location = new Point(12, 9);
            NicknameLabel.Name = "NicknameLabel";
            NicknameLabel.Size = new Size(81, 35);
            NicknameLabel.TabIndex = 10;
            NicknameLabel.Text = "label1";
            NicknameLabel.Click += label1_Click;
            // 
            // RulesButton
            // 
            RulesButton.BackColor = Color.MistyRose;
            RulesButton.Location = new Point(0, 0);
            RulesButton.Margin = new Padding(3, 4, 3, 4);
            RulesButton.Name = "RulesButton";
            RulesButton.Size = new Size(222, 38);
            RulesButton.TabIndex = 1;
            RulesButton.Text = "Rules";
            RulesButton.UseVisualStyleBackColor = false;
            RulesButton.Click += RulesButton_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_2025_02_07_10_49_42;
            ClientSize = new Size(1262, 633);
            Controls.Add(NicknameLabel);
            Controls.Add(KolodaPanel);
            Controls.Add(ButtonsPanel);
            Controls.Add(CardsPanel);
            Controls.Add(ChatPanel);
            Controls.Add(PlayerListBox);
            Controls.Add(PlayersLabel);
            Controls.Add(LabelTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GameForm";
            Text = "Loonacy Game";
            ChatPanel.ResumeLayout(false);
            ChatPanel.PerformLayout();
            CardsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Card7).EndInit();
            ((System.ComponentModel.ISupportInitialize)Card6).EndInit();
            ((System.ComponentModel.ISupportInitialize)Card1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Card5).EndInit();
            ((System.ComponentModel.ISupportInitialize)Card4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Card3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Card2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            KolodaPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void Card4_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label PlayersLabel;
        private System.Windows.Forms.Panel ChatPanel;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.RichTextBox ChatTextBox;
        private System.Windows.Forms.Panel CardsPanel;
        private System.Windows.Forms.PictureBox Card7;
        private System.Windows.Forms.PictureBox Card6;
        private System.Windows.Forms.PictureBox Card5;
        private System.Windows.Forms.PictureBox Card4;
        private System.Windows.Forms.PictureBox Card3;
        private System.Windows.Forms.PictureBox Card2;
        private System.Windows.Forms.PictureBox Card1;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button PassButton;
        public ListBox PlayerListBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel KolodaPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label NicknameLabel;
        private Button RulesButton;
    }
}