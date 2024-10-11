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
        public FrmNovaMidia()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            NovaMidia(
                txtTitulo.Text,
                txtAutor.Text,
                txtTitulo.Text,
                cmbGenero.SelectedItem.ToString(),
                cmbClassInd.SelectedItem.ToString(),
                (int)numDuraçao.Value,
                20247
                );
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
                    Duraçao = duracao,
                    Ano = ano

                };
                contexto.Midias.Add(novaMidia);

                contexto.SaveChanges();



            }
        }
    }
}
