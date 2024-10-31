using LocadoraApp2.Classes;
using LocadoraApp2.Contexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraApp2
{
    public partial class FrmListaLocacoes : Form
    {
        public FrmListaLocacoes()
        {
            InitializeComponent();
        }

        private void FrmListaLocacoes_Load(object sender, EventArgs e)
        {
            CarregaDadosDGV();
        }
        private List<Locacao> GetLocacoes()
        {
            string StatusFiltro = cmbStatus.Text;

            using (var contexto = new LocadoraAppDbContext())
            {
                return contexto.Locacoes.ToList();
            }
        }

        private void CarregaDadosDGV()
        {

            dgvListaLocacao.DataSource = GetLocacoes();

            dgvListaLocacao.Columns["LocacaoId"].HeaderText = "Código";
            dgvListaLocacao.Columns["Data"].HeaderText = "Data";
            dgvListaLocacao.Columns["Status"].HeaderText = "Status";
            dgvListaLocacao.Columns["ValorTotal"].HeaderText = "Valor total";
            dgvListaLocacao.Columns["Nome"].HeaderText = "Nome do cliente";

            dgvListaLocacao.Columns["ValorTotal"].DefaultCellStyle.Format = "C";

            dgvListaLocacao.Columns["Telefone"].Visible = false;
            dgvListaLocacao.Columns["Cpf"].Visible = false;

            dgvListaLocacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvListaLocacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Pega a linha selecionada pelo usuário
                DataGridViewRow linha = dgvListaLocacao.Rows[e.RowIndex];

                int LocacaoId = (int)linha.Cells["LocacaoId"].Value;

                Novalocacao novalocacao = new Novalocacao(LocacaoId);
                novalocacao.ShowDialog();


                CarregaDadosDGV();
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaDadosDGV();
        }
    }
}


