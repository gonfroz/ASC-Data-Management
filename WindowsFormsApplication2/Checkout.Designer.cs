namespace WindowsFormsApplication2
{
    partial class Checkout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GamesLabel = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.XBoxRadio = new System.Windows.Forms.RadioButton();
            this.WiiRadio = new System.Windows.Forms.RadioButton();
            this.PSRadio = new System.Windows.Forms.RadioButton();
            this.ControllersNum = new System.Windows.Forms.NumericUpDown();
            this.ControllersLabel = new System.Windows.Forms.Label();
            this.ConsoleLabel = new System.Windows.Forms.Label();
            this.GamesList = new System.Windows.Forms.CheckedListBox();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ControllersNum)).BeginInit();
            this.SuspendLayout();
            // 
            // GamesLabel
            // 
            this.GamesLabel.BackColor = System.Drawing.Color.White;
            this.GamesLabel.Location = new System.Drawing.Point(350, 22);
            this.GamesLabel.MinimumSize = new System.Drawing.Size(50, 0);
            this.GamesLabel.Name = "GamesLabel";
            this.GamesLabel.Size = new System.Drawing.Size(137, 20);
            this.GamesLabel.TabIndex = 16;
            this.GamesLabel.Text = "Items Ready For Checkout";
            this.GamesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(25, 210);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(462, 121);
            this.listBox2.TabIndex = 19;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(131, 121);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(117, 20);
            this.NameBox.TabIndex = 20;
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(131, 150);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(117, 20);
            this.IDBox.TabIndex = 21;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(50, 124);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(75, 13);
            this.NameLabel.TabIndex = 22;
            this.NameLabel.Text = "Student Name";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(67, 153);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(58, 13);
            this.IDLabel.TabIndex = 23;
            this.IDLabel.Text = "ID Number";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(412, 172);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 24;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // XBoxRadio
            // 
            this.XBoxRadio.AutoSize = true;
            this.XBoxRadio.Location = new System.Drawing.Point(53, 45);
            this.XBoxRadio.Name = "XBoxRadio";
            this.XBoxRadio.Size = new System.Drawing.Size(48, 17);
            this.XBoxRadio.TabIndex = 25;
            this.XBoxRadio.TabStop = true;
            this.XBoxRadio.Text = "xBox";
            this.XBoxRadio.UseVisualStyleBackColor = true;
            // 
            // WiiRadio
            // 
            this.WiiRadio.AutoSize = true;
            this.WiiRadio.Location = new System.Drawing.Point(53, 68);
            this.WiiRadio.Name = "WiiRadio";
            this.WiiRadio.Size = new System.Drawing.Size(40, 17);
            this.WiiRadio.TabIndex = 26;
            this.WiiRadio.TabStop = true;
            this.WiiRadio.Text = "Wii";
            this.WiiRadio.UseVisualStyleBackColor = true;
            // 
            // PSRadio
            // 
            this.PSRadio.AutoSize = true;
            this.PSRadio.Location = new System.Drawing.Point(53, 91);
            this.PSRadio.Name = "PSRadio";
            this.PSRadio.Size = new System.Drawing.Size(76, 17);
            this.PSRadio.TabIndex = 27;
            this.PSRadio.TabStop = true;
            this.PSRadio.Text = "Playstation";
            this.PSRadio.UseVisualStyleBackColor = true;
            // 
            // ControllersNum
            // 
            this.ControllersNum.Location = new System.Drawing.Point(158, 42);
            this.ControllersNum.Name = "ControllersNum";
            this.ControllersNum.Size = new System.Drawing.Size(54, 20);
            this.ControllersNum.TabIndex = 28;
            // 
            // ControllersLabel
            // 
            this.ControllersLabel.AutoSize = true;
            this.ControllersLabel.Location = new System.Drawing.Point(146, 26);
            this.ControllersLabel.Name = "ControllersLabel";
            this.ControllersLabel.Size = new System.Drawing.Size(78, 13);
            this.ControllersLabel.TabIndex = 29;
            this.ControllersLabel.Text = "# of Controllers";
            // 
            // ConsoleLabel
            // 
            this.ConsoleLabel.AutoSize = true;
            this.ConsoleLabel.Location = new System.Drawing.Point(50, 26);
            this.ConsoleLabel.Name = "ConsoleLabel";
            this.ConsoleLabel.Size = new System.Drawing.Size(45, 13);
            this.ConsoleLabel.TabIndex = 30;
            this.ConsoleLabel.Text = "Console";
            // 
            // GamesList
            // 
            this.GamesList.FormattingEnabled = true;
            this.GamesList.Items.AddRange(new object[] {
            "Donkey Kong",
            "Fifa",
            "Smash Bros",
            "Madden NFL",
            "Battlefield",
            "Call of Duty",
            "Mario Kart",
            "Battle Toads"});
            this.GamesList.Location = new System.Drawing.Point(350, 47);
            this.GamesList.Name = "GamesList";
            this.GamesList.Size = new System.Drawing.Size(137, 124);
            this.GamesList.TabIndex = 31;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton.Location = new System.Drawing.Point(12, 356);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 32;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(513, 391);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.GamesList);
            this.Controls.Add(this.ConsoleLabel);
            this.Controls.Add(this.ControllersLabel);
            this.Controls.Add(this.ControllersNum);
            this.Controls.Add(this.PSRadio);
            this.Controls.Add(this.WiiRadio);
            this.Controls.Add(this.XBoxRadio);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.GamesLabel);
            this.Name = "Checkout";
            this.Text = "Checkout";
            ((System.ComponentModel.ISupportInitialize)(this.ControllersNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label GamesLabel;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.RadioButton XBoxRadio;
        private System.Windows.Forms.RadioButton WiiRadio;
        private System.Windows.Forms.RadioButton PSRadio;
        private System.Windows.Forms.NumericUpDown ControllersNum;
        private System.Windows.Forms.Label ControllersLabel;
        private System.Windows.Forms.Label ConsoleLabel;
        private System.Windows.Forms.CheckedListBox GamesList;
        private System.Windows.Forms.Button BackButton;
    }
}
