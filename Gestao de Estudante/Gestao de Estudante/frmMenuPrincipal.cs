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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnEstudante_Click(object sender, EventArgs e)
        {
            frmEstudante estudante = new frmEstudante();
            estudante.Visible = true;
        }

        private void btnAvaliacao_Click(object sender, EventArgs e)
        {
            frmNotas notas = new frmNotas();
            notas.Visible = true;
        }

        private void btnGestAcademica_Click(object sender, EventArgs e)
        {
            frmGestaoAcademica gestAc = new frmGestaoAcademica();
            gestAc.Visible = true;
        }

        private void btnPauta_Click(object sender, EventArgs e)
        {
            frmPauta pauta = new frmPauta();
            pauta.Visible = true;
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmRelatorio relat = new frmRelatorio();
            relat.Visible = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cadastrar(object sender, MouseEventArgs e)
        {

        }

        private void Apag(object sender, EventArgs e)
        {

        }
    }
}
