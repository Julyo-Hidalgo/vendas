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
        model.marca marca = new marca();

        public fm_marca()
        {
            InitializeComponent();
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
            dgv_marca.DataSource = marca.consultar();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
             model.marca marca = new model.marca()
            {
                nome = txt_pesquisar.Text
            };

            marca.consultar();
            carregaGrid(txt_pesquisar.Text);
            limpaCampos();
        }

        private void txt_pesquisar_TextChanged(object sender, EventArgs e)
        {
            //tirar isso depois
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == String.Empty) return;

            if(MessageBox.Show("Deseja excluir a marca?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                model.marca marca = new model.marca()
                {
                    id = int.Parse(txt_codigo.Text)
                };

                marca.delete();
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

            model.marca marca = new model.marca()
            {
                nome = txt_nome.Text
            };

            marca.insert();
            limpaCampos();
            carregaGrid("");
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == String.Empty) return;

            model.marca c = new model.marca()
            {
                id = int.Parse(txt_codigo.Text),
                nome = txt_nome.Text
            };

            marca.update();
            limpaCampos();
            carregaGrid("");
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            carregaGrid();
        }
    }
}
