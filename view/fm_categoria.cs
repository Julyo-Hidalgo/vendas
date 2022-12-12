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
            dgv_cidade.DataSource = ctg.consultar();
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

            model.categoria ctg = new model.categoria()
            {
                nome = txt_nome.Text
            };

            ctg.insert();
            limpaCampos();
            carregaGrid("");
        }

        private void fm_categoria_Load(object sender, EventArgs e)
        {
            limpaCampos();
            carregaGrid("");
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            //
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            carregaGrid(txt_pesquisar.Text);
        }

        private void dgv_click(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_cidade.RowCount > 0)
            {
                txt_codigo.Text = dgv_cidade.CurrentRow.Cells["id"].Value.ToString();
                txt_nome.Text = dgv_cidade.CurrentRow.Cells["nome"].Value.ToString();
            }
        }
    }
}