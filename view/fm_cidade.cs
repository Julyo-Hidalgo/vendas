using _211362.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _211362.view
{
    public partial class fm_cidade : Form
    {
        model.cidade cdd = new cidade();
        public fm_cidade()
        {
            InitializeComponent();
            this.cdd.consultar();
            dgv_cidade.DataSource = banco.data_table;
        }

        private void fm_cidade_Load(object sender, EventArgs e)
        {
            limpaCampos();
            carregaGrid("");
        }

        void limpaCampos()
        {
            txt_codigo.Clear();
            txt_nome.Clear();
            txt_uf.Clear();
            txt_pesquisar.Clear();
        }

        void carregaGrid(string pesquisa)
        {
            cdd = new cidade()
            {
                nome = pesquisa
            };
            dgv_cidade.DataSource = cdd.consultar();
        }

        private void btn_incluir_Click_1(object sender, EventArgs e)
        {
            if (txt_nome.Text == String.Empty) return;

            model.cidade c = new model.cidade()
            {
                nome = txt_nome.Text,
                uf = txt_uf.Text
            };

            c.insert();
            limpaCampos();
            carregaGrid("");
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_click(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_cidade.RowCount > 0)
            {
                txt_codigo.Text = dgv_cidade.CurrentRow.Cells["id"].Value.ToString();
                txt_nome.Text = dgv_cidade.CurrentRow.Cells["nome"].Value.ToString();
                txt_uf.Text = dgv_cidade.CurrentRow.Cells["uf"].Value.ToString();
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {

            model.cidade c = new model.cidade()
            {
                nome = txt_pesquisar.Text
            };

            c.consultar();
            carregaGrid(txt_pesquisar.Text);
            limpaCampos();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == String.Empty) return;

            model.cidade c = new model.cidade()
            {
                nome = txt_nome.Text,
                uf = txt_uf.Text
            };

            c.update();
            limpaCampos();
            carregaGrid("");
        }
    }
}
