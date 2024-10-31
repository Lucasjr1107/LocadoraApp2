namespace LocadoraApp2
{
    partial class FrmNovaMidia
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
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            lblAutor = new Label();
            txtAutor = new TextBox();
            lblSinopse = new Label();
            txtSinopse = new TextBox();
            lblGenero = new Label();
            lblCodigo = new Label();
            numCodigo = new NumericUpDown();
            cmbGenero = new ComboBox();
            cmbClassInd = new ComboBox();
            lblClasseInd = new Label();
            lblAnoLançado = new Label();
            label1 = new Label();
            numDuracao = new NumericUpDown();
            btnSalvar = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnApagar = new Button();
            numAnoLancamento = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numCodigo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuracao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAnoLancamento).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(3, 71);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(56, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(1, 99);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(383, 31);
            txtTitulo.TabIndex = 1;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(427, 71);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(57, 25);
            lblAutor.TabIndex = 2;
            lblAutor.Text = "Autor";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(427, 99);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(439, 31);
            txtAutor.TabIndex = 2;
            // 
            // lblSinopse
            // 
            lblSinopse.AutoSize = true;
            lblSinopse.Location = new Point(3, 265);
            lblSinopse.Name = "lblSinopse";
            lblSinopse.Size = new Size(75, 25);
            lblSinopse.TabIndex = 5;
            lblSinopse.Text = "Sinopse";
            // 
            // txtSinopse
            // 
            txtSinopse.Location = new Point(1, 293);
            txtSinopse.Multiline = true;
            txtSinopse.Name = "txtSinopse";
            txtSinopse.Size = new Size(865, 158);
            txtSinopse.TabIndex = 7;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(3, 133);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(69, 25);
            lblGenero.TabIndex = 7;
            lblGenero.Text = "Genero";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(1, 9);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(71, 25);
            lblCodigo.TabIndex = 8;
            lblCodigo.Text = "Codigo";
            // 
            // numCodigo
            // 
            numCodigo.Hexadecimal = true;
            numCodigo.Location = new Point(3, 37);
            numCodigo.Name = "numCodigo";
            numCodigo.ReadOnly = true;
            numCodigo.Size = new Size(383, 31);
            numCodigo.TabIndex = 9;
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Animação", "Terror", "Comedia", "Ação", "Suspense", "Ficçao" });
            cmbGenero.Location = new Point(3, 161);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(383, 33);
            cmbGenero.TabIndex = 3;
            // 
            // cmbClassInd
            // 
            cmbClassInd.FormattingEnabled = true;
            cmbClassInd.Items.AddRange(new object[] { "+10", "+14", "+16", "18", "L" });
            cmbClassInd.Location = new Point(427, 161);
            cmbClassInd.Name = "cmbClassInd";
            cmbClassInd.Size = new Size(439, 33);
            cmbClassInd.TabIndex = 4;
            // 
            // lblClasseInd
            // 
            lblClasseInd.AutoSize = true;
            lblClasseInd.Location = new Point(427, 133);
            lblClasseInd.Name = "lblClasseInd";
            lblClasseInd.Size = new Size(191, 25);
            lblClasseInd.TabIndex = 12;
            lblClasseInd.Text = "Classificaçao Indicativa";
            // 
            // lblAnoLançado
            // 
            lblAnoLançado.AutoSize = true;
            lblAnoLançado.Location = new Point(3, 203);
            lblAnoLançado.Name = "lblAnoLançado";
            lblAnoLançado.Size = new Size(146, 25);
            lblAnoLançado.TabIndex = 13;
            lblAnoLançado.Text = "Ano Lançamento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(427, 203);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 15;
            label1.Text = "Duraçao (Minutos)";
            // 
            // numDuracao
            // 
            numDuracao.Location = new Point(427, 231);
            numDuracao.Name = "numDuracao";
            numDuracao.Size = new Size(439, 31);
            numDuracao.TabIndex = 6;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(602, 479);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 17;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(735, 479);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(473, 479);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(337, 479);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(112, 34);
            btnApagar.TabIndex = 20;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // numAnoLancamento
            // 
            numAnoLancamento.Location = new Point(3, 231);
            numAnoLancamento.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numAnoLancamento.Name = "numAnoLancamento";
            numAnoLancamento.Size = new Size(383, 31);
            numAnoLancamento.TabIndex = 21;
            // 
            // FrmNovaMidia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 535);
            Controls.Add(numAnoLancamento);
            Controls.Add(btnApagar);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(numDuracao);
            Controls.Add(label1);
            Controls.Add(lblAnoLançado);
            Controls.Add(lblClasseInd);
            Controls.Add(cmbClassInd);
            Controls.Add(cmbGenero);
            Controls.Add(numCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(lblGenero);
            Controls.Add(txtSinopse);
            Controls.Add(lblSinopse);
            Controls.Add(txtAutor);
            Controls.Add(lblAutor);
            Controls.Add(txtTitulo);
            Controls.Add(lblTitulo);
            Name = "FrmNovaMidia";
            Text = "FrmNovaMidia";
           
            ((System.ComponentModel.ISupportInitialize)numCodigo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDuracao).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAnoLancamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtTitulo;
        private Label lblAutor;
        private TextBox txtAutor;
        private Label lblSinopse;
        private TextBox txtSinopse;
        private Label lblGenero;
        private Label lblCodigo;
        private NumericUpDown numCodigo;
        private ComboBox cmbGenero;
        private ComboBox cmbClassInd;
        private Label lblClasseInd;
        private Label lblAnoLançado;
        private Label label1;
        private NumericUpDown numDuracao;
        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnApagar;
        private NumericUpDown numAnoLancamento;
    }
}