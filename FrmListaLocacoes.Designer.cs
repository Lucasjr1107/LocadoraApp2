namespace LocadoraApp2
{
    partial class FrmListaLocacoes
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
            label1 = new Label();
            dgvListaLocacao = new DataGridView();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvListaLocacao).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 41);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 1;
            // 
            // dgvListaLocacao
            // 
            dgvListaLocacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaLocacao.Location = new Point(12, 110);
            dgvListaLocacao.Name = "dgvListaLocacao";
            dgvListaLocacao.RowHeadersWidth = 62;
            dgvListaLocacao.RowTemplate.Height = 33;
            dgvListaLocacao.Size = new Size(762, 307);
            dgvListaLocacao.TabIndex = 0;
            dgvListaLocacao.CellDoubleClick += dgvListaLocacao_CellDoubleClick;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(33, 9);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Fechado ", "Concluido" });
            cmbStatus.Location = new Point(33, 41);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(320, 33);
            cmbStatus.TabIndex = 3;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // FrmListaLocacoes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(label1);
            Controls.Add(dgvListaLocacao);
            Name = "FrmListaLocacoes";
            Text = "FrmListaLocacoes";
            Load += FrmListaLocacoes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaLocacao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dgvListaLocacao;
        private Label lblStatus;
        private ComboBox cmbStatus;
    }
}