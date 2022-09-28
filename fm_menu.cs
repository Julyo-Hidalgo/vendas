namespace _211362
{
    public partial class fm_menu : Form
    {
        public fm_menu()
        {
            InitializeComponent();
        }

        private void fm_menu_Load(object sender, EventArgs e)
        {
            banco.cria_banco();
        }
    }
}