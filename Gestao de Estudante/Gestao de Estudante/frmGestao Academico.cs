using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_de_Estudante
{
    public partial class frmGestaoAcademica : Form
    {
        public frmGestaoAcademica()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnSubmeter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Submetido com Sucesso");
        }
    }
}
