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
            this.button5 = new System.Windows.Forms.Button();
            this.sfdInventory = new System.Windows.Forms.SaveFileDialog();
            this.ofdInventory = new System.Windows.Forms.OpenFileDialog();
            this.inventoryBox = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playstation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.xbox = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.physical = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.controllers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.controllerAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.other = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.otherAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            this.playstation,
            this.wii,
            this.xbox,
            this.physical,
            this.controllers,
            this.controllerAmount,
            this.other,
            this.otherAmount});
            this.inventoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.inventoryBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.inventoryBox.Location = new System.Drawing.Point(19, 85);
            this.inventoryBox.MultiSelect = false;
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(613, 240);
            this.inventoryBox.TabIndex = 46;
            this.inventoryBox.UseCompatibleStateImageBehavior = false;
            this.inventoryBox.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 1;
            // 
            // playstation
            // 
            this.playstation.Text = "Playstation";
            this.playstation.Width = 102;
            // 
            // wii
            // 
            this.wii.Text = "Wii";
            this.wii.Width = 83;
            // 
            // xbox
            // 
            this.xbox.Text = "Xbox";
            this.xbox.Width = 85;
            // 
            // physical
            // 
            this.physical.Text = "Physical";
            this.physical.Width = 79;
            // 
            // controllers
            // 
            this.controllers.Text = "Controllers";
            this.controllers.Width = 63;
            // 
            // controllerAmount
            // 
            this.controllerAmount.Text = "Amount";
            this.controllerAmount.Width = 49;
            // 
            // other
            // 
            this.other.Text = "Other";
            // 
            // otherAmount
            // 
            this.otherAmount.Text = "Amount";
            this.otherAmount.Width = 50;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(651, 411);
            this.Controls.Add(this.inventoryBox);
            this.Controls.Add(this.button5);
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.SaveFileDialog sfdInventory;
        private System.Windows.Forms.OpenFileDialog ofdInventory;
        private System.Windows.Forms.ListView inventoryBox;
        private System.Windows.Forms.ColumnHeader playstation;
        private System.Windows.Forms.ColumnHeader xbox;
        private System.Windows.Forms.ColumnHeader wii;
        private System.Windows.Forms.ColumnHeader controllers;
        private System.Windows.Forms.ColumnHeader physical;
        private System.Windows.Forms.ColumnHeader controllerAmount;
        private System.Windows.Forms.ColumnHeader other;
        private System.Windows.Forms.ColumnHeader otherAmount;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}