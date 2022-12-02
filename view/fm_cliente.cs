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
    public partial class fm_cliente : Form
    {
        public fm_cliente()
        {
            InitializeComponent();
        }
        void limpaCampos()
        {
            txt_codigo.Clear();
            txt_nome.Clear();
            txt_renda.Clear();
            mtxt_cpf.Clear();
            txt_pesquisar.Clear();
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
    }
}
