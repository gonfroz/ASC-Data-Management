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
            this.BackButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.GroupBox();
            this.games = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.hdmi = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chargers = new System.Windows.Forms.CheckBox();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.ControllersNum)).BeginInit();
            this.console.SuspendLayout();
            this.games.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameBox.Location = new System.Drawing.Point(342, 59);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(117, 20);
            this.NameBox.TabIndex = 20;
            // 
            // IDBox
            // 
            this.IDBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDBox.Location = new System.Drawing.Point(342, 88);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(117, 20);
            this.IDBox.TabIndex = 21;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(261, 62);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(75, 13);
            this.NameLabel.TabIndex = 22;
            this.NameLabel.Text = "Student Name";
            // 
            // IDLabel
            // 
            this.IDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(278, 91);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(58, 13);
            this.IDLabel.TabIndex = 23;
            this.IDLabel.Text = "ID Number";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitButton.Location = new System.Drawing.Point(384, 136);
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
            this.XBoxRadio.Location = new System.Drawing.Point(9, 19);
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
            this.WiiRadio.Location = new System.Drawing.Point(9, 42);
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
            this.PSRadio.Location = new System.Drawing.Point(9, 65);
            this.PSRadio.Name = "PSRadio";
            this.PSRadio.Size = new System.Drawing.Size(76, 17);
            this.PSRadio.TabIndex = 27;
            this.PSRadio.TabStop = true;
            this.PSRadio.Text = "Playstation";
            this.PSRadio.UseVisualStyleBackColor = true;
            // 
            // ControllersNum
            // 
            this.ControllersNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ControllersNum.Location = new System.Drawing.Point(264, 146);
            this.ControllersNum.Name = "ControllersNum";
            this.ControllersNum.Size = new System.Drawing.Size(54, 20);
            this.ControllersNum.TabIndex = 28;
            // 
            // ControllersLabel
            // 
            this.ControllersLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ControllersLabel.AutoSize = true;
            this.ControllersLabel.Location = new System.Drawing.Point(261, 127);
            this.ControllersLabel.Name = "ControllersLabel";
            this.ControllersLabel.Size = new System.Drawing.Size(78, 13);
            this.ControllersLabel.TabIndex = 29;
            this.ControllersLabel.Text = "# of Controllers";
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton.Location = new System.Drawing.Point(22, 333);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(80, 42);
            this.BackButton.TabIndex = 32;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.returnButton.Location = new System.Drawing.Point(404, 333);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(80, 42);
            this.returnButton.TabIndex = 33;
            this.returnButton.Text = "Return Item";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // console
            // 
            this.console.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.console.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.console.Controls.Add(this.XBoxRadio);
            this.console.Controls.Add(this.WiiRadio);
            this.console.Controls.Add(this.PSRadio);
            this.console.Location = new System.Drawing.Point(15, 16);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(92, 92);
            this.console.TabIndex = 40;
            this.console.TabStop = false;
            this.console.Text = "Console";
            // 
            // games
            // 
            this.games.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.games.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.games.Controls.Add(this.radioButton7);
            this.games.Controls.Add(this.radioButton8);
            this.games.Controls.Add(this.radioButton4);
            this.games.Controls.Add(this.radioButton5);
            this.games.Controls.Add(this.radioButton6);
            this.games.Controls.Add(this.radioButton1);
            this.games.Controls.Add(this.radioButton2);
            this.games.Controls.Add(this.radioButton3);
            this.games.Location = new System.Drawing.Point(127, 16);
            this.games.Name = "games";
            this.games.Size = new System.Drawing.Size(98, 155);
            this.games.TabIndex = 41;
            this.games.TabStop = false;
            this.games.Text = "Games";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(5, 109);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(73, 17);
            this.radioButton7.TabIndex = 31;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Mario Kart";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(5, 124);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(85, 17);
            this.radioButton8.TabIndex = 32;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Battle Toads";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(5, 64);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(87, 17);
            this.radioButton4.TabIndex = 28;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Madden NFL";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(5, 79);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(71, 17);
            this.radioButton5.TabIndex = 29;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Battlefield";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(5, 94);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(79, 17);
            this.radioButton6.TabIndex = 30;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Call of Duty";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 17);
            this.radioButton1.TabIndex = 25;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Donkey Kong";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(5, 34);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(42, 17);
            this.radioButton2.TabIndex = 26;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Fifa";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(5, 49);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(81, 17);
            this.radioButton3.TabIndex = 27;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Smash Bros";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // hdmi
            // 
            this.hdmi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hdmi.AutoSize = true;
            this.hdmi.Location = new System.Drawing.Point(262, 16);
            this.hdmi.Name = "hdmi";
            this.hdmi.Size = new System.Drawing.Size(84, 17);
            this.hdmi.TabIndex = 44;
            this.hdmi.Text = "HDMI Cable";
            this.hdmi.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.listView1.Location = new System.Drawing.Point(15, 190);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(483, 112);
            this.listView1.TabIndex = 45;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Student Name";
            this.columnHeader1.Width = 79;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Student ID";
            this.columnHeader2.Width = 63;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 3;
            this.columnHeader3.Text = "Controllers";
            this.columnHeader3.Width = 61;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 2;
            this.columnHeader4.Text = "Game";
            this.columnHeader4.Width = 91;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "HDMI";
            this.columnHeader5.Width = 40;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Worker Name";
            this.columnHeader7.Width = 90;
            // 
            // chargers
            // 
            this.chargers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chargers.AutoSize = true;
            this.chargers.Location = new System.Drawing.Point(362, 16);
            this.chargers.Name = "chargers";
            this.chargers.Size = new System.Drawing.Size(97, 17);
            this.chargers.TabIndex = 46;
            this.chargers.Text = "Phone Charger";
            this.chargers.UseVisualStyleBackColor = true;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Chargers";
            this.columnHeader6.Width = 55;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(513, 391);
            this.Controls.Add(this.chargers);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.hdmi);
            this.Controls.Add(this.games);
            this.Controls.Add(this.console);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ControllersLabel);
            this.Controls.Add(this.ControllersNum);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.NameBox);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Checkout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ControllersNum)).EndInit();
            this.console.ResumeLayout(false);
            this.console.PerformLayout();
            this.games.ResumeLayout(false);
            this.games.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.GroupBox console;
        private System.Windows.Forms.GroupBox games;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.CheckBox hdmi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.CheckBox chargers;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
