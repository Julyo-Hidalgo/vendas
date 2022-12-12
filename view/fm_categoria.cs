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
        categoria categoria;
        public fm_categoria()
        {
            InitializeComponent();
            this.categoria.consultar();
            dgv_cidade.DataSource = banco.data_table;
        }

        void limpaCampos()
        {
            txt_codigo.Clear();
            txt_nome.Clear();
            txt_pesquisar.Clear();
        }

        void carregaGrid(string pesquisa)
        {
            categoria = new categoria()
            {
                nome = pesquisa
            };
            dgv_cidade.DataSource = categoria.consultar();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            carregaGrid(txt_pesquisar.Text);
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == String.Empty) return;

            if (MessageBox.Show("Deseja excluir a categoria?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                categoria categoria = new categoria(){
                    id = int.Parse(txt_codigo.Text)
                };
                categoria.delete();

                limpaCampos();
                carregaGrid("");
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == String.Empty) return;

            categoria = new categoria()
            {
                nome = txt_nome.Text
            };

            categoria.insert();
            limpaCampos();
            carregaGrid("");
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {/*
            if (txt_nome.Text == String.Empty) return;

            categoria categoria = new categoria()
            {
                id = int.Parse(txt_codigo.Text),
                nome = txt_nome.Text
            };

            categoria.update();
            limpaCampos();
            carregaGrid("");*/
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void dgv_click(object sender, DataGridViewCellEventArgs e)
        {
            /*if (dgv_cidade.RowCount > 0)
            {
                txt_codigo.Text = dgv_cidade.CurrentRow.Cells["id"].Value.ToString();
                txt_nome.Text = dgv_cidade.CurrentRow.Cells["nome"].Value.ToString();
            }*/
        }

        private void fm_categoria_Load(object sender, EventArgs e)
        {/*
            limpaCampos();
            carregaGrid("");*/
        }
    }
}