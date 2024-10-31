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



                var LocacaoItem = contexto.Locacoes
                    .Include(l => l.Itens)
                    .FirstOrDefault(l => l.LocacaoId == ItemAlteracao.LocacaoId);

                bool FechaLocacao = true;
                foreach (var item in LocacaoItem.Itens)
                {
                    if (item.Status != "Devolução")
                    {
                        FechaLocacao = false;
                        break;
                    }
                }

                if (FechaLocacao)
                {
                    LocacaoItem.Status = "Concluido";
                    contexto.SaveChanges();
                }

                if (LocacaoItem.Itens.All(i => i.Status == "Devolução"))
                {
                    LocacaoItem.Status = "Concluido";
                    contexto.SaveChanges();
                }

                if (res > 0)
                {
                    MessageBox.Show("Status alterado com sucesso!");
                    this.Close();
                }

                contexto.SaveChanges();

            }
        }

        private void FrmMudaStatus_Load(object sender, EventArgs e)
        {

        }
    }
}
