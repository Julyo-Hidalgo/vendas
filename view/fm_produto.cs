using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _211362.view
{
    public partial class fm_produto : Form
    {
        public fm_produto()
        {
            InitializeComponent();
        }

        private void pic_foto_Click(object sender, EventArgs e)
        {

            ofd_foto.InitialDirectory = "D:\\";

            ofd_foto.FileName = "";

            ofd_foto.ShowDialog();

            pic_foto.ImageLocation = ofd_foto.FileName;

        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {

        }

        private void dgv_click(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fm_produto_Load(object sender, EventArgs e)
        {

        }
    }
}
