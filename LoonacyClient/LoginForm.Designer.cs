namespace LoonacyClient
{
    partial class LoginForm
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
            NicknameTextBox = new TextBox();
            LoginButton = new Button();
            LabelNickname = new Label();
            SuspendLayout();
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LabelTitle.ForeColor = Color.White;
            LabelTitle.Location = new Point(75, 20);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(124, 31);
            LabelTitle.TabIndex = 0;
            LabelTitle.Text = "Loonacy";
            // 
            // NicknameTextBox
            // 
            NicknameTextBox.Location = new Point(12, 116);
            NicknameTextBox.Margin = new Padding(3, 4, 3, 4);
            NicknameTextBox.Name = "NicknameTextBox";
            NicknameTextBox.Size = new Size(260, 27);
            NicknameTextBox.TabIndex = 1;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(95, 169);
            LoginButton.Margin = new Padding(3, 4, 3, 4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(90, 38);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LabelNickname
            // 
            LabelNickname.AutoSize = true;
            LabelNickname.ForeColor = Color.White;
            LabelNickname.Location = new Point(12, 91);
            LabelNickname.Name = "LabelNickname";
            LabelNickname.Size = new Size(78, 20);
            LabelNickname.TabIndex = 4;
            LabelNickname.Text = "Nickname:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumVioletRed;
            ClientSize = new Size(284, 250);
            Controls.Add(LabelNickname);
            Controls.Add(LoginButton);
            Controls.Add(NicknameTextBox);
            Controls.Add(LabelTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TextBox NicknameTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label LabelNickname;
    }
}