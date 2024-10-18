namespace LocadoraApp2
{
    partial class FrmMenu
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
            stripMenu = new MenuStrip();
            midiasToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            listaToolStripMenuItem = new ToolStripMenuItem();
            locaçõesToolStripMenuItem = new ToolStripMenuItem();
            novaToolStripMenuItem = new ToolStripMenuItem();
            listaToolStripMenuItem1 = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            stripMenu.SuspendLayout();
            SuspendLayout();
            // 
            // stripMenu
            // 
            stripMenu.ImageScalingSize = new Size(24, 24);
            stripMenu.Items.AddRange(new ToolStripItem[] { midiasToolStripMenuItem, locaçõesToolStripMenuItem, sairToolStripMenuItem });
            stripMenu.Location = new Point(0, 0);
            stripMenu.Name = "stripMenu";
            stripMenu.Size = new Size(804, 33);
            stripMenu.TabIndex = 0;
            stripMenu.Text = "stripMenu";
            // 
            // midiasToolStripMenuItem
            // 
            midiasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, listaToolStripMenuItem });
            midiasToolStripMenuItem.Name = "midiasToolStripMenuItem";
            midiasToolStripMenuItem.Size = new Size(80, 29);
            midiasToolStripMenuItem.Text = "Midias";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(156, 34);
            novoToolStripMenuItem.Text = "Nova";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // listaToolStripMenuItem
            // 
            listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            listaToolStripMenuItem.Size = new Size(156, 34);
            listaToolStripMenuItem.Text = "Lista";
            // 
            // locaçõesToolStripMenuItem
            // 
            locaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novaToolStripMenuItem, listaToolStripMenuItem1 });
            locaçõesToolStripMenuItem.Name = "locaçõesToolStripMenuItem";
            locaçõesToolStripMenuItem.Size = new Size(100, 29);
            locaçõesToolStripMenuItem.Text = "Locações";
            // 
            // novaToolStripMenuItem
            // 
            novaToolStripMenuItem.Name = "novaToolStripMenuItem";
            novaToolStripMenuItem.Size = new Size(156, 34);
            novaToolStripMenuItem.Text = "Nova";
            // 
            // listaToolStripMenuItem1
            // 
            listaToolStripMenuItem1.Name = "listaToolStripMenuItem1";
            listaToolStripMenuItem1.Size = new Size(156, 34);
            listaToolStripMenuItem1.Text = "Lista";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(57, 29);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 450);
            Controls.Add(stripMenu);
            MainMenuStrip = stripMenu;
            Name = "FrmMenu";
            Text = "Form1";
            Load += FrmMenu_Load;
            stripMenu.ResumeLayout(false);
            stripMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip stripMenu;
        private ToolStripMenuItem midiasToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem listaToolStripMenuItem;
        private ToolStripMenuItem locaçõesToolStripMenuItem;
        private ToolStripMenuItem novaToolStripMenuItem;
        private ToolStripMenuItem listaToolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}