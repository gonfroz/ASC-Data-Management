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
            this.AddButton = new System.Windows.Forms.Button();
            this.Items = new System.Windows.Forms.ListBox();
            this.Owned = new System.Windows.Forms.ListBox();
            this.Available = new System.Windows.Forms.ListBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.AvailableLabel = new System.Windows.Forms.Label();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(113, 269);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(97, 48);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add Item";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // Items
            // 
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
            this.Items.Location = new System.Drawing.Point(113, 56);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(217, 186);
            this.Items.TabIndex = 4;
            // 
            // Owned
            // 
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
            this.Owned.Location = new System.Drawing.Point(383, 56);
            this.Owned.Name = "Owned";
            this.Owned.Size = new System.Drawing.Size(51, 186);
            this.Owned.TabIndex = 5;
            // 
            // Available
            // 
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
            this.Available.Location = new System.Drawing.Point(487, 56);
            this.Available.Name = "Available";
            this.Available.Size = new System.Drawing.Size(51, 186);
            this.Available.TabIndex = 6;
            this.Available.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(233, 269);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(97, 48);
            this.RemoveButton.TabIndex = 7;
            this.RemoveButton.Text = "Remove Item";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton.Location = new System.Drawing.Point(55, 352);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(80, 40);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ReloadButton.Location = new System.Drawing.Point(521, 352);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(94, 40);
            this.ReloadButton.TabIndex = 9;
            this.ReloadButton.Text = "Reload List";
            this.ReloadButton.UseVisualStyleBackColor = true;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(380, 40);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(51, 13);
            this.QuantityLabel.TabIndex = 10;
            this.QuantityLabel.Text = "# Owned";
            // 
            // AvailableLabel
            // 
            this.AvailableLabel.AutoSize = true;
            this.AvailableLabel.Location = new System.Drawing.Point(484, 40);
            this.AvailableLabel.Name = "AvailableLabel";
            this.AvailableLabel.Size = new System.Drawing.Size(60, 13);
            this.AvailableLabel.TabIndex = 11;
            this.AvailableLabel.Text = "# Available";
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Location = new System.Drawing.Point(110, 40);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(46, 13);
            this.ItemsLabel.TabIndex = 12;
            this.ItemsLabel.Text = "Item List";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(651, 411);
            this.Controls.Add(this.ItemsLabel);
            this.Controls.Add(this.AvailableLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.Available);
            this.Controls.Add(this.Owned);
            this.Controls.Add(this.Items);
            this.Controls.Add(this.AddButton);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox Items;
        private System.Windows.Forms.ListBox Owned;
        private System.Windows.Forms.ListBox Available;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label AvailableLabel;
        private System.Windows.Forms.Label ItemsLabel;
    }
}