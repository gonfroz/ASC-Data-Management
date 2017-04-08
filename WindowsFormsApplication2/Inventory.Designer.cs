namespace WindowsFormsApplication2
{
    partial class Inventory
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
            this.button1 = new System.Windows.Forms.Button();
            this.Items = new System.Windows.Forms.ListBox();
            this.Owned = new System.Windows.Forms.ListBox();
            this.Available = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(111, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Items
            // 
            this.Items.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Items.FormattingEnabled = true;
            this.Items.Items.AddRange(new object[] {
            "Mario Kart",
            "Donkey Kong",
            "Fifa",
            "Madden NFL",
            "Call of Duty (Playstation)",
            "Call of Duty (xBox)",
            "Wii Sports",
            "Battlefield",
            "Battle Toads",
            "Smash Bros",
            "xBox Controllers",
            "Wii Controllers",
            "Playstation Controllers",
            "HDMI Cables"});
            this.Items.Location = new System.Drawing.Point(111, 83);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(217, 186);
            this.Items.TabIndex = 4;
            // 
            // Owned
            // 
            this.Owned.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Owned.FormattingEnabled = true;
            this.Owned.Items.AddRange(new object[] {
            "1",
            "1",
            "1",
            "1",
            "1",
            "1",
            "1",
            "1",
            "1",
            "1",
            "8",
            "4",
            "8",
            "15"});
            this.Owned.Location = new System.Drawing.Point(381, 83);
            this.Owned.Name = "Owned";
            this.Owned.Size = new System.Drawing.Size(51, 186);
            this.Owned.TabIndex = 5;
            // 
            // Available
            // 
            this.Available.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Available.FormattingEnabled = true;
            this.Available.Items.AddRange(new object[] {
            "0",
            "1",
            "0",
            "1",
            "1",
            "1",
            "0",
            "1",
            "1",
            "1",
            "4",
            "2",
            "2",
            "13"});
            this.Available.Location = new System.Drawing.Point(485, 83);
            this.Available.Name = "Available";
            this.Available.Size = new System.Drawing.Size(51, 186);
            this.Available.TabIndex = 6;
            this.Available.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Location = new System.Drawing.Point(231, 296);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 48);
            this.button4.TabIndex = 7;
            this.button4.Text = "Remove Item";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Location = new System.Drawing.Point(12, 359);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 40);
            this.button5.TabIndex = 8;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(545, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 40);
            this.button3.TabIndex = 9;
            this.button3.Text = "Reload List";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "# Owned";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "# Available";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Item List";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(651, 411);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Available);
            this.Controls.Add(this.Owned);
            this.Controls.Add(this.Items);
            this.Controls.Add(this.button1);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox Items;
        private System.Windows.Forms.ListBox Owned;
        private System.Windows.Forms.ListBox Available;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}