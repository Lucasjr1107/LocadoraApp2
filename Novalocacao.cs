using LocadoraApp2.Classes;
using LocadoraApp2.Contexto;
using Microsoft.EntityFrameworkCore;
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

    public partial class Novalocacao : Form
    {
        private Locacao LocacaoAtual;
        public Novalocacao()
        {
            InitializeComponent();
        }

        private Novalocacao(int LocacaoId)
        {
            InitializeComponent();
            CamposApenasLeitura(true);
            LocacaoAtual = GetLocacaoById(LocacaoId);

        }

        private void CarregarDadoslocacaoCampos()
        {
            txtNome.Text = LocacaoAtual.Nome;
            mtxtCPf.Text = LocacaoAtual.Cpf;
            mtxtTelefone.Text = LocacaoAtual.Telefone;

            dateDataLocacao.Value = LocacaoAtual.Data;
            numValorTotal.Value = LocacaoAtual.ValorTotal;
            txtStatus.Text = LocacaoAtual.Status;

            CarregaDadosDGV();
        }
        private Locacao GetLocacaoById(int id)
        {
            using (var Contexto = new LocadoraAppDbContext())
            {
                return Contexto
                        .Locacoes
                        .Include(l => l.Itens)
                        .ThenInclude(i => i.Midia)
                        .FirstOrDefault(l => l.LocacaoId == id);
            }
        }
        private void Novalocacao_Load(object sender, EventArgs e)
        {
            if (LocacaoAtual == null)
            {
                cmbMidias.CarregarMidias();

                LocacaoAtual = new Locacao();

                CarregaDadosDGV();
            }
        }

        private bool ValidaDadositem()
        {
            if (cmbMidias.MidiaSelecionada == null)
            {
                MessageBox.Show("Selecione uma midia!");
                cmbMidias.Focus();
                return false;
            }

            if (numQuantidade.Value < 1)
            {
                MessageBox.Show("A quantidade não pode ser meor que um");
                numQuantidade.Focus();
                return false;
            }

            if (numPrazo.Value < 1)
            {
                MessageBox.Show("O prazo de devolução não pode ser menor que 1 dia");
                numPrazo.Focus();
                return false;
            }

            if (numValor.Value == 0)
            {
                MessageBox.Show("O campo do valor não deve ser zero");
                numValor.Focus();
                return false;
            }

            return true;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!ValidaDadositem())
            {
                return;
            }
            Item NovoItem = new Item()
            {
                PrazoDevolucao = (int)numPrazo.Value,
                Valor = numValor.Value,
                Quantidade = (int)numQuantidade.Value,
                Status = "Pendente",
                MidiaId = cmbMidias.MidiaSelecionada.MidiaId,
                Midia = cmbMidias.MidiaSelecionada
            };
            LocacaoAtual.Itens.Add(NovoItem);

            LimpaCamposItens();

            MessageBox.Show("Item adicionado com sucesso!");
        }

        private void LimparCamposUsuarios()
        {
            txtNome.Clear();
            mtxtCPf.Clear();
            mtxtTelefone.Clear();

            LocacaoAtual = new Locacao();
        }
        private void LimpaCamposItens()
        {
            numValor.Value = 0;

            cmbMidias.SelectedIndex = 0;

            numQuantidade.Value = 1;

            numPrazo.Value = 0;


        }


        private void CarregaDadosDGV()
        {
            dgvItenslocacao.DataSource = LocacaoAtual.Itens;

            dgvItenslocacao.Columns["ItemId"].HeaderText = "Codigo";
            dgvItenslocacao.Columns["MidiaTitulo"].HeaderText = "Titulo";
            dgvItenslocacao.Columns["PrazoDevolucao"].HeaderText = "Devolução";
            dgvItenslocacao.Columns["Valor"].HeaderText = "Valor";
            dgvItenslocacao.Columns["Quantidade"].HeaderText = "Quantidade";
            dgvItenslocacao.Columns["ValorTotal"].HeaderText = "Total";

            dgvItenslocacao.Columns["Valor"].DefaultCellStyle.Format = "C";
            dgvItenslocacao.Columns["ValorTotal"].DefaultCellStyle.Format = "C";


            dgvItenslocacao.Columns["ItemId"].DisplayIndex = 0;
            dgvItenslocacao.Columns["MidiaTitulo"].DisplayIndex = 1;
            dgvItenslocacao.Columns["PrazoDevolucao"].DisplayIndex = 2;
            dgvItenslocacao.Columns["Valor"].DisplayIndex = 3;
            dgvItenslocacao.Columns["Quantidade"].DisplayIndex = 4;
            dgvItenslocacao.Columns["DataDevolucao"].DisplayIndex = 5;
            dgvItenslocacao.Columns["Status"].DisplayIndex = 7;
            dgvItenslocacao.Columns["Status"].DisplayIndex = 7;
            dgvItenslocacao.Columns["ValorTotal"].DisplayIndex = 6;
            dgvItenslocacao.Columns["Status"].DisplayIndex = 7;

            dgvItenslocacao.Columns["MidiaId"].Visible = false;
            dgvItenslocacao.Columns["Midia"].Visible = false;
            dgvItenslocacao.Columns["Locacao"].Visible = false;
            dgvItenslocacao.Columns["LocacaoId"].Visible = false;
            dgvItenslocacao.Columns["Status"].Visible = false;

            dgvItenslocacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (!ValidaDadosLocacao())
            {
                return;
            }

            LocacaoAtual.Cpf = mtxtCPf.Text;
            LocacaoAtual.Nome = txtNome.Text;
            LocacaoAtual.Telefone = mtxtTelefone.Text;
            LocacaoAtual.Status = "Fechado";
            LocacaoAtual.Data = DateTime.Now;

            using (var contexto = new LocadoraAppDbContext())
            {
                foreach (var item in LocacaoAtual.Itens)
                {
                    contexto.Midias.Attach(item.Midia);
                    LocacaoAtual.ValorTotal += item.ValorTotal;
                }

                contexto.Locacoes.Add(LocacaoAtual);
                int resutado = contexto.SaveChanges();

                if (resutado > 0)
                {
                    var opcao = MessageBox.Show(
                        "Locação criada com sucesso! Deseja criar outra?",
                        "Locação criada",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1
                        );

                    if (opcao == DialogResult.Yes)
                    {
                        LimparCamposUsuarios();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }
        private bool ValidaDadosLocacao()
        {
            if (txtNome == null)
            {
                MessageBox.Show("O nome do cliente e invalido!");
                txtNome.Focus();
                return false;
            }

            if (mtxtCPf.Text.Length != 11)
            {
                MessageBox.Show("O CPF do cliente e invalido!");
                mtxtCPf.Focus();
                return false;
            }
            if (mtxtTelefone.Text.Length < 11)
            {
                MessageBox.Show("O telefpne do cliente e invalido!");
                mtxtTelefone.Focus();
                return false;
            }


            return true;
        }


        private void CamposApenasLeitura(bool status)
        {
            txtNome.ReadOnly = status;
            mtxtCPf.ReadOnly = status;
            mtxtTelefone.ReadOnly = status;

            grbNovoItem.Visible = !status;

            btnCancelar.Visible = !status;

            btnFechar.Visible = !status;

            grbDadosLocacao.Visible = !status;

            dgvItenslocacao.ReadOnly = !status;

        }

        private void dgvItenslocacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               DataGridViewRow linha = dgvItenslocacao.Rows[e.RowIndex];
               int ItemId = (int)linha.Cells["ItemId"].Value;

                using (var contexto = new LocadoraAppDbContext())
                {
                    var Item = contexto.Itens
                        .Include(i => i.Midia)
                        .Include(i => i.Locacao)
                        .FirstOrDefault(i => i.ItemId == ItemId);


                    if (Item == null)
                    {
                        FrmMudaStatus frmMudaStatus = new FrmMudaStatus(Item);
                        frmMudaStatus.ShowDialog();
                    }
                }


            }
        }
    }

}
