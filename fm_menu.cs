using System;
using System.Windows.Forms;
using _211362.view;

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

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm_cidade form = new fm_cidade();
            form.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm_categoria form = new fm_categoria();
            form.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm_marca form = new fm_marca();
            form.Show();
        }
    }
}