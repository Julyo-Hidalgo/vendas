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

    }
}
