using _211362.model;
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
    public partial class fm_categoria : Form
    {
        model.categoria ctg = new model.categoria();
        void limpaCampos()
        {
            txt_codigo.Clear();
            txt_nome.Clear();
            txt_pesquisar.Clear();
        }

        void carregaGrid(string pesquisa)
        {
            ctg = new categoria()
            {
                nome = pesquisa
            };
            dgv_cidade.DataSource = ctg;
        }
        public fm_categoria()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == String.Empty) return;

            model.cidade c = new model.cidade()
            {
                nome = txt_nome.Text
            };

            c.insert();
            limpaCampos();
            carregaGrid("");
        }
    }
}
