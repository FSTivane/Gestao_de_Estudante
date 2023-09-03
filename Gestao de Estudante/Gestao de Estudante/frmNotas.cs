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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
            
        }

        private void lbl_nomeEst_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmeter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Submetido com Sucesso");
        }

        private void txt_nota_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbx_disciplina_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
