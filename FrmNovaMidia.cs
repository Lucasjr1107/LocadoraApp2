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
    public partial class FrmNovaMidia : Form
    {
        private Midia MidiaAtual;

        public FrmNovaMidia()
        {
            InitializeComponent();
        }

        public FrmNovaMidia(int idMidia)
        {
            InitializeComponent();

            MidiaAtual = GetMidiaById(idMidia);
            CamposApenasLeitura(true);
            CarregarDadosFormulario();
        }

        private void CarregarDadosFormulario()
        {
            numCodigo.Value = MidiaAtual.MidiaId;
            txtTitulo.Text = MidiaAtual.Titulo;
            txtAutor.Text = MidiaAtual.Autor;
            txtSinopse.Text = MidiaAtual.Sinopse;
            cmbGenero.Text = MidiaAtual.Genero;
            cmbClassInd.Text = MidiaAtual.ClassificacaoIndicativa;
            numAnoLancamento.Value = MidiaAtual.Ano;
        }
        private Midia GetMidiaById(int id)
        {
            using (var contexto = new LocadoraAppDbContext())
            {
                return contexto.Midias.Find(id);
            }
        }
        private void CamposApenasLeitura(bool status)
        {
            txtTitulo.ReadOnly = status;
            txtAutor.ReadOnly = status;
            txtSinopse.ReadOnly = status;
            numDuracao.ReadOnly = status;
            numAnoLancamento.ReadOnly = status;
            cmbGenero.Enabled = status;
            cmbClassInd.Enabled = !status;
            btnSalvar.Enabled = !status;
            btnEditar.Visible = status;

        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MidiaAtual != null)
            {
                using (var contexto = new LocadoraAppDbContext())
                {
                    MidiaAtual.Titulo = txtTitulo.Text;
                    MidiaAtual.Sinopse = txtSinopse.Text;
                    MidiaAtual.Autor = txtAutor.Text;
                    MidiaAtual.Duracao = (int)numDuracao.Value;
                    MidiaAtual.ClassificacaoIndicativa = cmbClassInd.SelectedItem.ToString();
                    MidiaAtual.Genero = cmbGenero.SelectedItem.ToString();
                    MidiaAtual.Ano = 2024;

                    int resultado = contexto.SaveChanges();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Midia editada com sucesso!");
                    }
                }
                CamposApenasLeitura(true);

            }
            else
            {
                NovaMidia(
                    txtTitulo.Text,
                    txtSinopse.Text,
                    txtAutor.Text,
                    cmbClassInd.SelectedItem.ToString(),
                    cmbGenero.SelectedItem.ToString(),
                    (int)numDuracao.Value,
                    2024
                    );

            }
        }

        private void NovaMidia(string titulo, string autor, string sinopse, string genero, string classificacaoIndicativa, int duracao, int ano)
        {
            using (var contexto = new LocadoraAppDbContext())
            {
                Midia novaMidia = new Midia
                {
                    Titulo = titulo,
                    Autor = autor,
                    Sinopse = sinopse,
                    Genero = genero,
                    ClassificacaoIndicativa = classificacaoIndicativa,
                    Duracao = duracao,
                    Ano = ano

                };
                contexto.Midias.Add(novaMidia);
                int res = contexto.SaveChanges();

                if (res == 0)
                {
                    MessageBox.Show("Erro ao salvar a midia!");
                }
                else
                {
                    MessageBox.Show("Midia criada com sucesso.");
                    txtTitulo.Clear();
                    txtAutor.Clear();
                    txtSinopse.Clear();
                    cmbGenero.SelectedItem = null;
                    cmbClassInd.SelectedItem = null;
                    numDuracao.Value = 0;
                }



            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CamposApenasLeitura(false);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(
            $"Deseja realmente apagar a midia {MidiaAtual.Titulo}?",
            "Confirmaçao de deleçao",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2
            );
            if (res == DialogResult.Yes)
            {
                using (var contexto = new LocadoraAppDbContext())
                {
                    MidiaAtual = contexto.Midias.Find(MidiaAtual.MidiaId);
                    if (MidiaAtual != null)
                    {
                        contexto.Midias.Remove(MidiaAtual);
                        int resultado = contexto.SaveChanges();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Midia Removida com sucesso");
                            this.Close();
                        }
                    }
                }
            }
        }

     
    }
}
