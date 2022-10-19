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
    public partial class fm_cidade : Form
    {
        public fm_cidade()
        {
            InitializeComponent();
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == String.Empty) return;

            model.cidade c = new model.cidade()
            {
                nome = txt_nome.Text,
                uf = txt_uf.Text
            };

            c.insert();
        }
    }
}
