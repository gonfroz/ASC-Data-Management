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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ControllersNum)).BeginInit();
            this.SuspendLayout();
            // 
            // GamesLabel
            // 
            this.GamesLabel.BackColor = System.Drawing.Color.White;
            this.GamesLabel.Location = new System.Drawing.Point(25, 20);
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
            this.listBox2.Items.AddRange(new object[] {
            "Hayley Davis\t2121212\t           xBox\tCall of Duty\t2\tJames"});
            this.listBox2.Location = new System.Drawing.Point(18, 210);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(476, 121);
            this.listBox2.TabIndex = 19;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(255, 118);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(117, 20);
            this.NameBox.TabIndex = 20;
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(255, 147);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(117, 20);
            this.IDBox.TabIndex = 21;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(174, 121);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(75, 13);
            this.NameLabel.TabIndex = 22;
            this.NameLabel.Text = "Student Name";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(191, 150);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(58, 13);
            this.IDLabel.TabIndex = 23;
            this.IDLabel.Text = "ID Number";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(407, 135);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 32);
            this.SubmitButton.TabIndex = 24;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // XBoxRadio
            // 
            this.XBoxRadio.AutoSize = true;
            this.XBoxRadio.Location = new System.Drawing.Point(191, 39);
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
            this.WiiRadio.Location = new System.Drawing.Point(191, 62);
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
            this.PSRadio.Location = new System.Drawing.Point(191, 85);
            this.PSRadio.Name = "PSRadio";
            this.PSRadio.Size = new System.Drawing.Size(76, 17);
            this.PSRadio.TabIndex = 27;
            this.PSRadio.TabStop = true;
            this.PSRadio.Text = "Playstation";
            this.PSRadio.UseVisualStyleBackColor = true;
            // 
            // ControllersNum
            // 
            this.ControllersNum.Location = new System.Drawing.Point(296, 36);
            this.ControllersNum.Name = "ControllersNum";
            this.ControllersNum.Size = new System.Drawing.Size(54, 20);
            this.ControllersNum.TabIndex = 28;
            // 
            // ControllersLabel
            // 
            this.ControllersLabel.AutoSize = true;
            this.ControllersLabel.Location = new System.Drawing.Point(284, 20);
            this.ControllersLabel.Name = "ControllersLabel";
            this.ControllersLabel.Size = new System.Drawing.Size(78, 13);
            this.ControllersLabel.TabIndex = 29;
            this.ControllersLabel.Text = "# of Controllers";
            // 
            // ConsoleLabel
            // 
            this.ConsoleLabel.AutoSize = true;
            this.ConsoleLabel.Location = new System.Drawing.Point(188, 20);
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
            this.GamesList.Location = new System.Drawing.Point(25, 43);
            this.GamesList.Name = "GamesList";
            this.GamesList.Size = new System.Drawing.Size(137, 124);
            this.GamesList.TabIndex = 31;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton.Location = new System.Drawing.Point(25, 337);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(80, 42);
            this.BackButton.TabIndex = 32;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(407, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 42);
            this.button1.TabIndex = 33;
            this.button1.Text = "Return to Inventory";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Console";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Item Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "# of Items";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Student Worker";
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(513, 391);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
