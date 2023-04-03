namespace MainProgram
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            addContactToolStripMenuItem = new ToolStripMenuItem();
            windowsToolStripMenuItem = new ToolStripMenuItem();
            cascadeMenuItem = new ToolStripMenuItem();
            tileVerticalMenuItem = new ToolStripMenuItem();
            tileHorizontalMenuItem = new ToolStripMenuItem();
            bindingSource1 = new BindingSource(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addContactToolStripMenuItem, windowsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addContactToolStripMenuItem
            // 
            addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            addContactToolStripMenuItem.Size = new Size(138, 24);
            addContactToolStripMenuItem.Text = "Add/Edit Contact";
            addContactToolStripMenuItem.Click += addContactToolStripMenuItem_Click;
            // 
            // windowsToolStripMenuItem
            // 
            windowsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadeMenuItem, tileVerticalMenuItem, tileHorizontalMenuItem });
            windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            windowsToolStripMenuItem.Size = new Size(84, 24);
            windowsToolStripMenuItem.Text = "Windows";
            // 
            // cascadeMenuItem
            // 
            cascadeMenuItem.Name = "cascadeMenuItem";
            cascadeMenuItem.Size = new Size(190, 26);
            cascadeMenuItem.Text = "Cascade";
            cascadeMenuItem.Click += cascadeMenuItem_Click;
            // 
            // tileVerticalMenuItem
            // 
            tileVerticalMenuItem.Name = "tileVerticalMenuItem";
            tileVerticalMenuItem.Size = new Size(190, 26);
            tileVerticalMenuItem.Text = "Tile Vertical";
            tileVerticalMenuItem.Click += tileVerticalToolStripMenuItem_Click;
            // 
            // tileHorizontalMenuItem
            // 
            tileHorizontalMenuItem.Name = "tileHorizontalMenuItem";
            tileHorizontalMenuItem.Size = new Size(190, 26);
            tileHorizontalMenuItem.Text = "Tile Horizontal";
            tileHorizontalMenuItem.Click += tileHorizontalMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            Text = "Form1";
            Load += Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem windowsToolStripMenuItem;
        private ToolStripMenuItem cascadeMenuItem;
        private ToolStripMenuItem tileVerticalMenuItem;
        private ToolStripMenuItem tileHorizontalMenuItem;
        private ToolStripMenuItem addContactToolStripMenuItem;
        private BindingSource bindingSource1;
    }
}