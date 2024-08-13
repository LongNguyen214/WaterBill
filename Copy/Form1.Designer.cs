namespace Copy
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            manageInvoices = new ManageInvoices();
            addInvoice = new AddInvoice();
            addToolStripMenuItem = new ToolStripMenuItem();
            manageInvoiceToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // manageInvoices
            // 
            manageInvoices.Location = new Point(0, 31);
            manageInvoices.Name = "manageInvoices";
            manageInvoices.Size = new Size(871, 500);
            manageInvoices.TabIndex = 1;
            manageInvoices.Load += manageInvoices_Load;
            // 
            // addInvoice
            // 
            addInvoice.Location = new Point(0, 31);
            addInvoice.Name = "addInvoice";
            addInvoice.Size = new Size(883, 661);
            addInvoice.TabIndex = 2;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(102, 24);
            addToolStripMenuItem.Text = "Add Invoice";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // manageInvoiceToolStripMenuItem
            // 
            manageInvoiceToolStripMenuItem.Name = "manageInvoiceToolStripMenuItem";
            manageInvoiceToolStripMenuItem.Size = new Size(128, 24);
            manageInvoiceToolStripMenuItem.Text = "Manage Invoice";
            manageInvoiceToolStripMenuItem.Click += manageInvoiceToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, manageInvoiceToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(883, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 708);
            Controls.Add(addInvoice);
            Controls.Add(manageInvoices);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Water Bills";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ManageInvoices manageInvoices;
        private AddInvoice addInvoice;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem manageInvoiceToolStripMenuItem;
        private MenuStrip menuStrip1;
    }
}
