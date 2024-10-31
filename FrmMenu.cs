namespace LocadoraApp2
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNovaMidia frmNovaMidia = new FrmNovaMidia();
            frmNovaMidia.Show();
        }



        private void novaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novalocacao frmnovalocacao = new Novalocacao();
            frmnovalocacao.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaMidia frmListaMidia = new FrmListaMidia();
            frmListaMidia.Show();
        }

        private void listaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListaLocacoes frmListaLocacoes = new FrmListaLocacoes();
            frmListaLocacoes.Show();   
        }
    }
}