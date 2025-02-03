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
            Card5 = new PictureBox();
            Card4 = new PictureBox();
            Card3 = new PictureBox();
            Card2 = new PictureBox();
            Card1 = new PictureBox();
            ButtonsPanel = new Panel();
            PassButton = new Button();
            SurrenderButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            KolodaPanel = new Panel();
            ChatPanel.SuspendLayout();
            CardsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Card7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Card6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Card5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Card4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Card3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Card2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Card1).BeginInit();
            ButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            KolodaPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LabelTitle.Location = new Point(699, 9);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(124, 31);
            LabelTitle.TabIndex = 0;
            LabelTitle.Text = "Loonacy";
            // 
            // PlayersLabel
            // 
            PlayersLabel.AutoSize = true;
            PlayersLabel.Location = new Point(1271, 42);
            PlayersLabel.Name = "PlayersLabel";
            PlayersLabel.Size = new Size(58, 20);
            PlayersLabel.TabIndex = 1;
            PlayersLabel.Text = "Players:";
            // 
            // PlayerListBox
            // 
            PlayerListBox.FormattingEnabled = true;
            PlayerListBox.Location = new Point(1271, 71);
            PlayerListBox.Margin = new Padding(3, 4, 3, 4);
            PlayerListBox.Name = "PlayerListBox";
            PlayerListBox.Size = new Size(150, 204);
            PlayerListBox.TabIndex = 2;
            PlayerListBox.SelectedIndexChanged += PlayerListBox_SelectedIndexChanged;
            // 
            // ChatPanel
            // 
            ChatPanel.Controls.Add(MessageTextBox);
            ChatPanel.Controls.Add(SendMessageButton);
            ChatPanel.Controls.Add(ChatTextBox);
            ChatPanel.Location = new Point(22, 25);
            ChatPanel.Margin = new Padding(3, 4, 3, 4);
            ChatPanel.Name = "ChatPanel";
            ChatPanel.Size = new Size(458, 188);
            ChatPanel.TabIndex = 4;
            // 
            // MessageTextBox
            // 
            MessageTextBox.Location = new Point(12, 144);
            MessageTextBox.Margin = new Padding(3, 4, 3, 4);
            MessageTextBox.Name = "MessageTextBox";
            MessageTextBox.Size = new Size(350, 27);
            MessageTextBox.TabIndex = 2;
            // 
            // SendMessageButton
            // 
            SendMessageButton.Location = new Point(370, 144);
            SendMessageButton.Margin = new Padding(3, 4, 3, 4);
            SendMessageButton.Name = "SendMessageButton";
            SendMessageButton.Size = new Size(75, 29);
            SendMessageButton.TabIndex = 1;
            SendMessageButton.Text = "Send";
            SendMessageButton.UseVisualStyleBackColor = true;
            SendMessageButton.Click += SendMessageButton_Click;
            // 
            // ChatTextBox
            // 
            ChatTextBox.Location = new Point(12, 17);
            ChatTextBox.Margin = new Padding(3, 4, 3, 4);
            ChatTextBox.Name = "ChatTextBox";
            ChatTextBox.ReadOnly = true;
            ChatTextBox.Size = new Size(433, 119);
            ChatTextBox.TabIndex = 0;
            ChatTextBox.Text = "";
            // 
            // CardsPanel
            // 
            CardsPanel.Controls.Add(Card7);
            CardsPanel.Controls.Add(Card6);
            CardsPanel.Controls.Add(Card5);
            CardsPanel.Controls.Add(Card4);
            CardsPanel.Controls.Add(Card3);
            CardsPanel.Controls.Add(Card2);
            CardsPanel.Controls.Add(Card1);
            CardsPanel.Location = new Point(352, 475);
            CardsPanel.Margin = new Padding(3, 4, 3, 4);
            CardsPanel.Name = "CardsPanel";
            CardsPanel.Size = new Size(843, 176);
            CardsPanel.TabIndex = 5;
            CardsPanel.Visible = false;
            // 
            // Card7
            // 
            Card7.BackColor = Color.LightGray;
            Card7.Location = new Point(484, 0);
            Card7.Margin = new Padding(3, 4, 3, 4);
            Card7.Name = "Card7";
            Card7.Size = new Size(115, 176);
            Card7.TabIndex = 6;
            Card7.TabStop = false;
            // 
            // Card6
            // 
            Card6.BackColor = Color.LightGray;
            Card6.Location = new Point(363, 0);
            Card6.Margin = new Padding(3, 4, 3, 4);
            Card6.Name = "Card6";
            Card6.Size = new Size(115, 176);
            Card6.TabIndex = 5;
            Card6.TabStop = false;
            // 
            // Card5
            // 
            Card5.BackColor = Color.LightGray;
            Card5.Location = new Point(242, 0);
            Card5.Margin = new Padding(3, 4, 3, 4);
            Card5.Name = "Card5";
            Card5.Size = new Size(115, 176);
            Card5.TabIndex = 4;
            Card5.TabStop = false;
            // 
            // Card4
            // 
            Card4.BackColor = Color.LightGray;
            Card4.Location = new Point(121, 0);
            Card4.Margin = new Padding(3, 4, 3, 4);
            Card4.Name = "Card4";
            Card4.Size = new Size(115, 176);
            Card4.TabIndex = 3;
            Card4.TabStop = false;
            // 
            // Card3
            // 
            Card3.BackColor = Color.LightGray;
            Card3.Location = new Point(0, 0);
            Card3.Margin = new Padding(3, 4, 3, 4);
            Card3.Name = "Card3";
            Card3.Size = new Size(115, 176);
            Card3.TabIndex = 2;
            Card3.TabStop = false;
            // 
            // Card2
            // 
            Card2.BackColor = Color.LightGray;
            Card2.Location = new Point(726, 0);
            Card2.Margin = new Padding(3, 4, 3, 4);
            Card2.Name = "Card2";
            Card2.Size = new Size(115, 176);
            Card2.TabIndex = 1;
            Card2.TabStop = false;
            Card2.Click += Card2_Click;
            // 
            // Card1
            // 
            Card1.BackColor = Color.LightGray;
            Card1.Location = new Point(605, 0);
            Card1.Margin = new Padding(3, 4, 3, 4);
            Card1.Name = "Card1";
            Card1.Size = new Size(115, 176);
            Card1.TabIndex = 0;
            Card1.TabStop = false;
            Card1.Click += Card1_Click;
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.Controls.Add(PassButton);
            ButtonsPanel.Controls.Add(SurrenderButton);
            ButtonsPanel.Location = new Point(22, 526);
            ButtonsPanel.Margin = new Padding(3, 4, 3, 4);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.Size = new Size(100, 114);
            ButtonsPanel.TabIndex = 6;
            ButtonsPanel.Visible = false;
            // 
            // PassButton
            // 
            PassButton.Location = new Point(10, 12);
            PassButton.Margin = new Padding(3, 4, 3, 4);
            PassButton.Name = "PassButton";
            PassButton.Size = new Size(80, 38);
            PassButton.TabIndex = 0;
            PassButton.Text = "Pass";
            PassButton.UseVisualStyleBackColor = true;
            PassButton.Click += PassButton_Click;
            // 
            // SurrenderButton
            // 
            SurrenderButton.Location = new Point(10, 62);
            SurrenderButton.Margin = new Padding(3, 4, 3, 4);
            SurrenderButton.Name = "SurrenderButton";
            SurrenderButton.Size = new Size(80, 38);
            SurrenderButton.TabIndex = 1;
            SurrenderButton.Text = "Surrender";
            SurrenderButton.UseVisualStyleBackColor = true;
            SurrenderButton.Click += SurrenderButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.Location = new Point(242, 17);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 176);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LightGray;
            pictureBox2.Location = new Point(0, 17);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(115, 176);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // KolodaPanel
            // 
            KolodaPanel.Controls.Add(pictureBox2);
            KolodaPanel.Controls.Add(pictureBox1);
            KolodaPanel.Location = new Point(594, 183);
            KolodaPanel.Name = "KolodaPanel";
            KolodaPanel.Size = new Size(357, 193);
            KolodaPanel.TabIndex = 9;
            KolodaPanel.Visible = false;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 664);
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
            ((System.ComponentModel.ISupportInitialize)Card5).EndInit();
            ((System.ComponentModel.ISupportInitialize)Card4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Card3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Card2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Card1).EndInit();
            ButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            KolodaPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Button SurrenderButton;
        public ListBox PlayerListBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel KolodaPanel;
    }
}