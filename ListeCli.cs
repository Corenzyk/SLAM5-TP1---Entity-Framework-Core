namespace SLAM5_TP1___Entity_Framework_Core
{
    public partial class ListeCli : Form
    {
        public ListeCli()
        {
            InitializeComponent();
        }

        private void ListeCli_Load(object sender, EventArgs e)
        {
            bsClients.DataSource = Modele.listeClients(); // appel de la méthode listeClients
            dgvClients.DataSource = bsClients;
        }
    }
}
