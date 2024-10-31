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
    public partial class FrmMudaStatus : Form
    {

        Item ItemAtual;
        public FrmMudaStatus(Item item)
        {
            InitializeComponent();
            ItemAtual = item;
            CarregarDadosMudaStatus();
        }
        private void CarregarDadosMudaStatus()
        {
            txtMidiaAlocada.Text = ItemAtual.Midia.Titulo;
            txtStatusAtual.Text = ItemAtual.Status;
            datePrazoDevolucao.Value = ItemAtual.DataDevolucao;

            if (ItemAtual.DataDevolucao < DateTime.Now)
            {

            }
        }

        private void FrmMudaStatus_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cmbNovoStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um novo status!");
                return;
            }

            using (var contexto = new LocadoraAppDbContext())
            {
                var ItemAlteracao = contexto.Itens.Find(ItemAtual.ItemId);
                ItemAlteracao.Status = cmbNovoStatus.SelectedItem.ToString();
                int res = contexto.SaveChanges();
                
                if (res > 0)
                {
                    MessageBox.Show("Status alterado com sucesso!");
                    this.Close();
                }

                contexto.SaveChanges();

            }
        }
    }
}
