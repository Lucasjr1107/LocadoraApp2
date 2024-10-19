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
            maskedTextBox2 = new MaskedTextBox();
            lblCPF = new Label();
            textBox1 = new TextBox();
            lblNome = new Label();
            maskedTextBox1 = new MaskedTextBox();
            groupBox2 = new GroupBox();
            cmbMidias = new Componentes.MidiasComboBox();
            lblValor = new Label();
            numericUpDown1 = new NumericUpDown();
            lblQuantidade = new Label();
            numericUpDown2 = new NumericUpDown();
            lblPrazoDevoluçao = new Label();
            numericUpDown3 = new NumericUpDown();
            btnAdicionar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTelefone);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(lblCPF);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(lblNome);
            groupBox1.Controls.Add(maskedTextBox1);
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
            // maskedTextBox2
            // 
            maskedTextBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox2.Location = new Point(362, 117);
            maskedTextBox2.Mask = "(00)00000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(369, 34);
            maskedTextBox2.TabIndex = 3;
            maskedTextBox2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
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
            // textBox1
            // 
            textBox1.Location = new Point(6, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(725, 31);
            textBox1.TabIndex = 1;
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
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(6, 117);
            maskedTextBox1.Mask = "999.999.999-99";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(277, 34);
            maskedTextBox1.TabIndex = 2;
            maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAdicionar);
            groupBox2.Controls.Add(numericUpDown3);
            groupBox2.Controls.Add(lblPrazoDevoluçao);
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(lblQuantidade);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(lblValor);
            groupBox2.Controls.Add(cmbMidias);
            groupBox2.Location = new Point(18, 188);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(891, 203);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Itens da locação";
            // 
            // cmbMidias
            // 
            cmbMidias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMidias.FormattingEnabled = true;
            cmbMidias.Location = new Point(6, 30);
            cmbMidias.Name = "cmbMidias";
            cmbMidias.Size = new Size(793, 33);
            cmbMidias.TabIndex = 0;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(6, 76);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(52, 25);
            lblValor.TabIndex = 4;
            lblValor.Text = "Valor";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(6, 104);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(219, 31);
            numericUpDown1.TabIndex = 5;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(303, 76);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(105, 25);
            lblQuantidade.TabIndex = 6;
            lblQuantidade.Text = "Quantidade";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(303, 104);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(219, 31);
            numericUpDown2.TabIndex = 7;
            // 
            // lblPrazoDevoluçao
            // 
            lblPrazoDevoluçao.AutoSize = true;
            lblPrazoDevoluçao.Location = new Point(644, 76);
            lblPrazoDevoluçao.Name = "lblPrazoDevoluçao";
            lblPrazoDevoluçao.Size = new Size(145, 25);
            lblPrazoDevoluçao.TabIndex = 8;
            lblPrazoDevoluçao.Text = "Prazo Devoluçao";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(623, 104);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(219, 31);
            numericUpDown3.TabIndex = 9;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(730, 154);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(112, 34);
            btnAdicionar.TabIndex = 10;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // Novalocacao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Novalocacao";
            Text = "Novalocacao";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblCPF;
        private TextBox textBox1;
        private Label lblNome;
        private MaskedTextBox maskedTextBox1;
        private Label lblTelefone;
        private MaskedTextBox maskedTextBox2;
        private GroupBox groupBox2;
        private Componentes.MidiasComboBox cmbMidias;
        private Label lblPrazoDevoluçao;
        private NumericUpDown numericUpDown2;
        private Label lblQuantidade;
        private NumericUpDown numericUpDown1;
        private Label lblValor;
        private Button btnAdicionar;
        private NumericUpDown numericUpDown3;
    }
}