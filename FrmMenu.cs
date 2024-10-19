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
    }
}