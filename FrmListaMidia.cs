﻿using LocadoraApp2.Classes;
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
    public partial class FrmListaMidia : Form
    {
        public FrmListaMidia()
        {
            InitializeComponent();
        }
        private List<Midia> GetMidias()
        {
            using (var contexto = new LocadoraAppDbContext())
            {
                return contexto.Midias.ToList();
            }
        }
        private void FrmListaMidia_Load(object sender, EventArgs e)
        {
            CarregaDadosDGV();
        }

        private void CarregaDadosDGV()
        {

            dgvListaMidias.DataSource = GetMidias();

            dgvListaMidias.Columns["MidiaID"].HeaderText = "Código";
            dgvListaMidias.Columns["Titulo"].HeaderText = "Título";
            dgvListaMidias.Columns["Genero"].HeaderText = "Gênero";

            dgvListaMidias.Columns["Ano"].Visible = false;
            dgvListaMidias.Columns["Duracao"].Visible = false;
            dgvListaMidias.Columns["ClassificacaoIndicativa"].Visible = false;
            dgvListaMidias.Columns["Sinopse"].Visible = false;

            dgvListaMidias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dgvListaMidias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar se clicou em uma linha valida
            if (e.RowIndex > 0)
            {
                // Pega a linha selecionada pelo usuário
                DataGridViewRow linha = dgvListaMidias.Rows[e.RowIndex];

                int MidiaId = (int)linha.Cells["MidiaId"].Value;

                FrmNovaMidia frmNovaMidia = new FrmNovaMidia(MidiaId);
                frmNovaMidia.ShowDialog();

                CarregaDadosDGV();
            }
        }
    }
}

