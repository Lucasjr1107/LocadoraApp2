namespace LocadoraApp2
{
    partial class FrmListaMidia
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
            dgvListaMidias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListaMidias).BeginInit();
            SuspendLayout();
            // 
            // dgvListaMidias
            // 
            dgvListaMidias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaMidias.Location = new Point(35, 38);
            dgvListaMidias.Name = "dgvListaMidias";
            dgvListaMidias.RowHeadersWidth = 62;
            dgvListaMidias.RowTemplate.Height = 33;
            dgvListaMidias.Size = new Size(732, 357);
            dgvListaMidias.TabIndex = 0;
            dgvListaMidias.CellDoubleClick += dgvListaMidias_CellDoubleClick;
            // 
            // FrmListaMidia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvListaMidias);
            Name = "FrmListaMidia";
            Text = "FrmListaMidia";
            Load += FrmListaMidia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaMidias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaMidias;
    }
}