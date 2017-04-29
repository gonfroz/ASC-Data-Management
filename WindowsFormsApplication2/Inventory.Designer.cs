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
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sfdInventory = new System.Windows.Forms.SaveFileDialog();
            this.ofdInventory = new System.Windows.Forms.OpenFileDialog();
            this.inventoryBox = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.Items.Location = new System.Drawing.Point(477, 77);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(217, 186);
            this.Items.TabIndex = 4;
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
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
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
            // inventoryBox
            // 
            this.inventoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inventoryBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.inventoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.inventoryBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.inventoryBox.Location = new System.Drawing.Point(207, 95);
            this.inventoryBox.MultiSelect = false;
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(237, 220);
            this.inventoryBox.TabIndex = 46;
            this.inventoryBox.UseCompatibleStateImageBehavior = false;
            this.inventoryBox.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Amount";
            this.columnHeader2.Width = 63;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(651, 411);
            this.Controls.Add(this.inventoryBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog sfdInventory;
        private System.Windows.Forms.OpenFileDialog ofdInventory;
        private System.Windows.Forms.ListView inventoryBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}