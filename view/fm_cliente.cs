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
    public partial class fm_cliente : Form
    {
        cidade cdd;
        cliente cliente;

        public fm_cliente()
        {
            InitializeComponent();
        }
        void limpaCampos()
        {
            txt_codigo.Clear();
            txt_nome.Clear();
            txt_pesquisar.Clear();
            cb_cidade.SelectedIndex = -1;
            txt_renda.Clear();
            mtxt_cpf.Clear();
            txt_pesquisar.Clear();
            dtp_data_nascimento.Value = DateTime.Now;
            check_bloqueia.Checked = false;
        }

        private void fm_cliente_Load(object sender, EventArgs e)
        {
            cdd = new cidade();
            cb_cidade.DataSource = cdd.consultar();
            cb_cidade.DisplayMember = "nome";
            cb_cidade.ValueMember = "id";

            limpaCampos();
            carregaGrid("");

            dgv_cidade.Columns["id"].Visible = false;
            dgv_cidade.Columns["foto"].Visible = false;
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

        private void dgv_click(object sender, EventArgs e)
        {

        }
    }
}
