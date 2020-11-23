namespace Projet231120.Vues
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.villeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compartimentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livreurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.villeToolStripMenuItem,
            this.boxToolStripMenuItem,
            this.compartimentToolStripMenuItem,
            this.colisToolStripMenuItem,
            this.livreurToolStripMenuItem,
            this.clientToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // villeToolStripMenuItem
            // 
            this.villeToolStripMenuItem.Name = "villeToolStripMenuItem";
            this.villeToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.villeToolStripMenuItem.Text = "Ville";
            this.villeToolStripMenuItem.Click += new System.EventHandler(this.villeToolStripMenuItem_Click);
            // 
            // boxToolStripMenuItem
            // 
            this.boxToolStripMenuItem.Name = "boxToolStripMenuItem";
            this.boxToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.boxToolStripMenuItem.Text = "Box";
            this.boxToolStripMenuItem.Click += new System.EventHandler(this.boxToolStripMenuItem_Click);
            // 
            // compartimentToolStripMenuItem
            // 
            this.compartimentToolStripMenuItem.Name = "compartimentToolStripMenuItem";
            this.compartimentToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.compartimentToolStripMenuItem.Text = "Compartiment";
            this.compartimentToolStripMenuItem.Click += new System.EventHandler(this.compartimentToolStripMenuItem_Click);
            // 
            // colisToolStripMenuItem
            // 
            this.colisToolStripMenuItem.Name = "colisToolStripMenuItem";
            this.colisToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.colisToolStripMenuItem.Text = "Colis";
            this.colisToolStripMenuItem.Click += new System.EventHandler(this.colisToolStripMenuItem_Click);
            // 
            // livreurToolStripMenuItem
            // 
            this.livreurToolStripMenuItem.Name = "livreurToolStripMenuItem";
            this.livreurToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.livreurToolStripMenuItem.Text = "Livreur";
            this.livreurToolStripMenuItem.Click += new System.EventHandler(this.livreurToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem villeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compartimentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livreurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
    }
}