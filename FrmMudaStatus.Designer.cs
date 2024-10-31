namespace LocadoraApp2
{
    partial class FrmMudaStatus
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
            lblMidiaAlocada = new Label();
            txtMidiaAlocada = new TextBox();
            lblStatusAtual = new Label();
            lblPrazoDevolucao = new Label();
            txtStatusAtual = new TextBox();
            datePrazoDevolucao = new DateTimePicker();
            groupBox1 = new GroupBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            cmbNovoStatus = new ComboBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMidiaAlocada
            // 
            lblMidiaAlocada.AutoSize = true;
            lblMidiaAlocada.Location = new Point(12, 17);
            lblMidiaAlocada.Name = "lblMidiaAlocada";
            lblMidiaAlocada.Size = new Size(125, 25);
            lblMidiaAlocada.TabIndex = 0;
            lblMidiaAlocada.Text = "Midia Alocada";
            // 
            // txtMidiaAlocada
            // 
            txtMidiaAlocada.Location = new Point(12, 45);
            txtMidiaAlocada.Name = "txtMidiaAlocada";
            txtMidiaAlocada.Size = new Size(654, 31);
            txtMidiaAlocada.TabIndex = 1;
            // 
            // lblStatusAtual
            // 
            lblStatusAtual.AutoSize = true;
            lblStatusAtual.Location = new Point(12, 98);
            lblStatusAtual.Name = "lblStatusAtual";
            lblStatusAtual.Size = new Size(106, 25);
            lblStatusAtual.TabIndex = 2;
            lblStatusAtual.Text = "Status Atual";
            // 
            // lblPrazoDevolucao
            // 
            lblPrazoDevolucao.AutoSize = true;
            lblPrazoDevolucao.Location = new Point(344, 98);
            lblPrazoDevolucao.Name = "lblPrazoDevolucao";
            lblPrazoDevolucao.Size = new Size(145, 25);
            lblPrazoDevolucao.TabIndex = 4;
            lblPrazoDevolucao.Text = "Prazo Devolucao";
            // 
            // txtStatusAtual
            // 
            txtStatusAtual.Location = new Point(12, 126);
            txtStatusAtual.Name = "txtStatusAtual";
            txtStatusAtual.Size = new Size(326, 31);
            txtStatusAtual.TabIndex = 5;
            // 
            // datePrazoDevolucao
            // 
            datePrazoDevolucao.Format = DateTimePickerFormat.Short;
            datePrazoDevolucao.Location = new Point(344, 126);
            datePrazoDevolucao.Name = "datePrazoDevolucao";
            datePrazoDevolucao.Size = new Size(300, 31);
            datePrazoDevolucao.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Red;
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(cmbNovoStatus);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 177);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(654, 246);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "   ";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(520, 206);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(365, 206);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cmbNovoStatus
            // 
            cmbNovoStatus.FormattingEnabled = true;
            cmbNovoStatus.Items.AddRange(new object[] { "Atrasado", "Danificado", "Devolução", "Pendente" });
            cmbNovoStatus.Location = new Point(6, 68);
            cmbNovoStatus.Name = "cmbNovoStatus";
            cmbNovoStatus.Size = new Size(626, 33);
            cmbNovoStatus.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 40);
            label3.Name = "label3";
            label3.Size = new Size(443, 25);
            label3.TabIndex = 1;
            label3.Text = "Selecione abaixo o novo status para o item da locação";
            // 
            // FrmMudaStatus
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 450);
            Controls.Add(groupBox1);
            Controls.Add(datePrazoDevolucao);
            Controls.Add(txtStatusAtual);
            Controls.Add(lblPrazoDevolucao);
            Controls.Add(lblStatusAtual);
            Controls.Add(txtMidiaAlocada);
            Controls.Add(lblMidiaAlocada);
            Name = "FrmMudaStatus";
            Text = "FrmMudaStatus";
            Load += FrmMudaStatus_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMidiaAlocada;
        private TextBox txtMidiaAlocada;
        private Label lblStatusAtual;
        private Label lblPrazoDevolucao;
        private TextBox txtStatusAtual;
        private DateTimePicker datePrazoDevolucao;
        private GroupBox groupBox1;
        private Label label3;
        private Button btnSalvar;
        private Button btnCancelar;
        private ComboBox cmbNovoStatus;
    }
}