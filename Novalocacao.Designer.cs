namespace LocadoraApp2
{
    partial class Novalocacao
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
            groupBox1 = new GroupBox();
            lblTelefone = new Label();
            mtxtTelefone = new MaskedTextBox();
            lblCPF = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            mtxtCPf = new MaskedTextBox();
            grbNovoItem = new GroupBox();
            grbDadosLocacao = new GroupBox();
            lblStatus = new Label();
            lblDataLocacao = new Label();
            dateDataLocacao = new DateTimePicker();
            txtStatus = new TextBox();
            numValorTotal = new NumericUpDown();
            label3 = new Label();
            btnAdicionar = new Button();
            numPrazo = new NumericUpDown();
            lblPrazoDevoluçao = new Label();
            numQuantidade = new NumericUpDown();
            lblQuantidade = new Label();
            numValor = new NumericUpDown();
            lblValor = new Label();
            cmbMidias = new Componentes.MidiasComboBox();
            dgvItenslocacao = new DataGridView();
            btnCancelar = new Button();
            btnFechar = new Button();
            groupBox1.SuspendLayout();
            grbNovoItem.SuspendLayout();
            grbDadosLocacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numValorTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrazo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItenslocacao).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTelefone);
            groupBox1.Controls.Add(mtxtTelefone);
            groupBox1.Controls.Add(lblCPF);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(lblNome);
            groupBox1.Controls.Add(mtxtCPf);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(870, 161);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Cliente";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(362, 89);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(77, 25);
            lblTelefone.TabIndex = 5;
            lblTelefone.Text = "Telefone";
            // 
            // mtxtTelefone
            // 
            mtxtTelefone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            mtxtTelefone.Location = new Point(362, 117);
            mtxtTelefone.Mask = "(00)00000-0000";
            mtxtTelefone.Name = "mtxtTelefone";
            mtxtTelefone.Size = new Size(369, 34);
            mtxtTelefone.TabIndex = 3;
            mtxtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(6, 89);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(42, 25);
            lblCPF.TabIndex = 3;
            lblCPF.Text = "CPF";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 55);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(725, 31);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(6, 27);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 25);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // mtxtCPf
            // 
            mtxtCPf.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            mtxtCPf.Location = new Point(6, 117);
            mtxtCPf.Mask = "999.999.999-99";
            mtxtCPf.Name = "mtxtCPf";
            mtxtCPf.Size = new Size(277, 34);
            mtxtCPf.TabIndex = 2;
            mtxtCPf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // grbNovoItem
            // 
            grbNovoItem.Controls.Add(grbDadosLocacao);
            grbNovoItem.Controls.Add(btnAdicionar);
            grbNovoItem.Controls.Add(numPrazo);
            grbNovoItem.Controls.Add(lblPrazoDevoluçao);
            grbNovoItem.Controls.Add(numQuantidade);
            grbNovoItem.Controls.Add(lblQuantidade);
            grbNovoItem.Controls.Add(numValor);
            grbNovoItem.Controls.Add(lblValor);
            grbNovoItem.Controls.Add(cmbMidias);
            grbNovoItem.Location = new Point(18, 188);
            grbNovoItem.Name = "grbNovoItem";
            grbNovoItem.Size = new Size(891, 203);
            grbNovoItem.TabIndex = 1;
            grbNovoItem.TabStop = false;
            grbNovoItem.Text = "Itens da locação";
            grbNovoItem.UseWaitCursor = true;
            // 
            // grbDadosLocacao
            // 
            grbDadosLocacao.BackColor = Color.Cyan;
            grbDadosLocacao.Controls.Add(lblStatus);
            grbDadosLocacao.Controls.Add(lblDataLocacao);
            grbDadosLocacao.Controls.Add(dateDataLocacao);
            grbDadosLocacao.Controls.Add(txtStatus);
            grbDadosLocacao.Controls.Add(numValorTotal);
            grbDadosLocacao.Controls.Add(label3);
            grbDadosLocacao.Location = new Point(0, 0);
            grbDadosLocacao.Name = "grbDadosLocacao";
            grbDadosLocacao.Size = new Size(891, 203);
            grbDadosLocacao.TabIndex = 11;
            grbDadosLocacao.TabStop = false;
            grbDadosLocacao.Text = "Itens da locação";
            grbDadosLocacao.UseWaitCursor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(539, 39);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Status";
            lblStatus.UseWaitCursor = true;
            // 
            // lblDataLocacao
            // 
            lblDataLocacao.AutoSize = true;
            lblDataLocacao.Location = new Point(17, 33);
            lblDataLocacao.Name = "lblDataLocacao";
            lblDataLocacao.Size = new Size(118, 25);
            lblDataLocacao.TabIndex = 8;
            lblDataLocacao.Text = "Data Locação";
            lblDataLocacao.UseWaitCursor = true;
            // 
            // dateDataLocacao
            // 
            dateDataLocacao.Format = DateTimePickerFormat.Short;
            dateDataLocacao.Location = new Point(17, 65);
            dateDataLocacao.Name = "dateDataLocacao";
            dateDataLocacao.Size = new Size(372, 31);
            dateDataLocacao.TabIndex = 7;
            dateDataLocacao.UseWaitCursor = true;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(539, 67);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(342, 31);
            txtStatus.TabIndex = 6;
            txtStatus.UseWaitCursor = true;
            // 
            // numValorTotal
            // 
            numValorTotal.DecimalPlaces = 2;
            numValorTotal.Location = new Point(539, 141);
            numValorTotal.Name = "numValorTotal";
            numValorTotal.Size = new Size(342, 31);
            numValorTotal.TabIndex = 5;
            numValorTotal.TextAlign = HorizontalAlignment.Right;
            numValorTotal.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(539, 110);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 4;
            label3.Text = "Valor";
            label3.UseWaitCursor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(730, 154);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(112, 34);
            btnAdicionar.TabIndex = 10;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.UseWaitCursor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // numPrazo
            // 
            numPrazo.Location = new Point(623, 104);
            numPrazo.Name = "numPrazo";
            numPrazo.Size = new Size(219, 31);
            numPrazo.TabIndex = 9;
            numPrazo.UseWaitCursor = true;
            // 
            // lblPrazoDevoluçao
            // 
            lblPrazoDevoluçao.AutoSize = true;
            lblPrazoDevoluçao.Location = new Point(644, 76);
            lblPrazoDevoluçao.Name = "lblPrazoDevoluçao";
            lblPrazoDevoluçao.Size = new Size(145, 25);
            lblPrazoDevoluçao.TabIndex = 8;
            lblPrazoDevoluçao.Text = "Prazo Devoluçao";
            lblPrazoDevoluçao.UseWaitCursor = true;
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(303, 104);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(219, 31);
            numQuantidade.TabIndex = 7;
            numQuantidade.UseWaitCursor = true;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(303, 76);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(105, 25);
            lblQuantidade.TabIndex = 6;
            lblQuantidade.Text = "Quantidade";
            lblQuantidade.UseWaitCursor = true;
            // 
            // numValor
            // 
            numValor.DecimalPlaces = 2;
            numValor.Location = new Point(6, 104);
            numValor.Name = "numValor";
            numValor.Size = new Size(219, 31);
            numValor.TabIndex = 5;
            numValor.TextAlign = HorizontalAlignment.Right;
            numValor.UseWaitCursor = true;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(6, 76);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(52, 25);
            lblValor.TabIndex = 4;
            lblValor.Text = "Valor";
            lblValor.UseWaitCursor = true;
            // 
            // cmbMidias
            // 
            cmbMidias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMidias.FormattingEnabled = true;
            cmbMidias.Location = new Point(6, 30);
            cmbMidias.Name = "cmbMidias";
            cmbMidias.Size = new Size(793, 33);
            cmbMidias.TabIndex = 0;
            cmbMidias.UseWaitCursor = true;
            // 
            // dgvItenslocacao
            // 
            dgvItenslocacao.BackgroundColor = Color.Moccasin;
            dgvItenslocacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItenslocacao.Location = new Point(12, 418);
            dgvItenslocacao.Name = "dgvItenslocacao";
            dgvItenslocacao.RowHeadersWidth = 62;
            dgvItenslocacao.RowTemplate.Height = 33;
            dgvItenslocacao.Size = new Size(887, 160);
            dgvItenslocacao.TabIndex = 2;
            dgvItenslocacao.CellDoubleClick += dgvItenslocacao_CellDoubleClick;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(630, 582);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(755, 582);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(144, 34);
            btnFechar.TabIndex = 12;
            btnFechar.Text = "Fechar Locação";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // Novalocacao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 628);
            Controls.Add(btnFechar);
            Controls.Add(btnCancelar);
            Controls.Add(dgvItenslocacao);
            Controls.Add(grbNovoItem);
            Controls.Add(groupBox1);
            Name = "Novalocacao";
            Load += Novalocacao_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grbNovoItem.ResumeLayout(false);
            grbNovoItem.PerformLayout();
            grbDadosLocacao.ResumeLayout(false);
            grbDadosLocacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numValorTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrazo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItenslocacao).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblCPF;
        private TextBox txtNome;
        private Label lblNome;
        private MaskedTextBox mtxtCPf;
        private Label lblTelefone;
        private MaskedTextBox mtxtTelefone;
        private GroupBox grbNovoItem;
        private Componentes.MidiasComboBox cmbMidias;
        private Label lblPrazoDevoluçao;
        private NumericUpDown numQuantidade;
        private Label lblQuantidade;
        private NumericUpDown numValor;
        private Label lblValor;
        private Button btnAdicionar;
        private NumericUpDown numPrazo;
        private DataGridView dgvItenslocacao;
        private Button btnCancelar;
        private Button btnFechar;
        private GroupBox grbDadosLocacao;
        private TextBox txtStatus;
        private NumericUpDown numValorTotal;
        private Label label3;
        private Label lblStatus;
        private Label lblDataLocacao;
        private DateTimePicker dateDataLocacao;
    }
}