using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _211362.model;

namespace _211362.view
{
    public partial class fm_marca : Form
    {
        marca marca = new marca();

        public fm_marca()
        {
            InitializeComponent();
            this.marca.consultar();
            dgv_venda.DataSource = banco.data_table;
        }

        void limpaCampos()
        {
            txt_codigo.Clear();
            txt_nome.Clear();
            txt_pesquisar.Clear();
        }

        void carregaGrid(string pesquisa)
        {
            marca = new marca()
            {
                nome = pesquisa
            };
            dgv_venda.DataSource = marca.consultar();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {

        }

        private void txt_pesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == String.Empty) return;

            marca marca = new marca()
            {
                nome = txt_nome.Text
            };

            marca.insert();
            limpaCampos();
            carregaGrid("");
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void dgv_click(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_venda.RowCount > 0)
            {
                txt_codigo.Text = dgv_venda.CurrentRow.Cells["id"].Value.ToString();
                txt_nome.Text = dgv_venda.CurrentRow.Cells["nome"].Value.ToString();
                txt_uf.Text = dgv_venda.CurrentRow.Cells["uf"].Value.ToString();
            }
        }

        private void fm_marca_Load(object sender, EventArgs e)
        {

        }
    }
}