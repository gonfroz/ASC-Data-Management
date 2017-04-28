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
            this.Items = new System.Windows.Forms.ListBox();
            this.Owned = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sfdInventory = new System.Windows.Forms.SaveFileDialog();
            this.ofdInventory = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
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
            this.Items.Location = new System.Drawing.Point(166, 120);
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
            this.Owned.Location = new System.Drawing.Point(436, 120);
            this.Owned.Name = "Owned";
            this.Owned.Size = new System.Drawing.Size(51, 186);
            this.Owned.TabIndex = 5;
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
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.label1.Location = new System.Drawing.Point(433, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "# Owned";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Item List";
            // 
            // sfdInventory
            // 
            this.sfdInventory.Filter = "CSV File|*.csv|All Files|*.*";
            this.sfdInventory.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdInventory_FileOk);
            // 
            // ofdInventory
            // 
            this.ofdInventory.Filter = "CSV File|*.csv|All Files|*.*";
            this.ofdInventory.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdInventory_FileOk);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(651, 411);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Owned);
            this.Controls.Add(this.Items);
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox Items;
        private System.Windows.Forms.ListBox Owned;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog sfdInventory;
        private System.Windows.Forms.OpenFileDialog ofdInventory;
    }
}