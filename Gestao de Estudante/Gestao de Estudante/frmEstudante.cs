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
    public partial class frmEstudante : Form
    {
        public frmEstudante()
        {
            InitializeComponent();
        }
      
       // int [] num = new int[3];
        string[] nome = new string[3];
        long[] numEstudante = new long[3];
        string[] curso = new string[3];
        long[] contact = new long[3];
        string[] email = new string[3];

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        public void txt_salvar_Click(object sender, EventArgs e)
        {
           
           
            for (int i = 0; i < 3; i++)
            {

                nome[i] = txt_nome.Text;
                numEstudante[i] = long.Parse(txt_num.Text);
                curso[i] = cbo_curso.SelectedItem.ToString();
                //curso[i] = txt_curso.SelectedItem;
                contact[i] = long.Parse(txt_cont.Text);
                email[i] = txt_email.Text;
            }

          

        }

        private void txt_visualizar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                MessageBox.Show(nome[i] + " " + numEstudante[i] + " " + curso[i] + " " + contact[i] + " " + email[i]);
            }  
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cod_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNotas tela2 = new frmNotas();

            tela2.Visible = true;
            this.Visible = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txt_eliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registado com Sucesso");
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Actualizado com Sucesso");
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Text = " ";
            txt_num.Text = " ";
            txt_email.Text = " ";
            txt_cont.Text = " ";
           
            
        }

        private void bto_visualizar_Click(object sender, EventArgs e)
        {
             /*foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                var index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value = txt_num.Text;
                this.dataGridView1.Rows[index].Cells[1].Value = txt_nome.Text;
                this.dataGridView1.Rows[index].Cells[2].Value = cbo_curso.SelectedItem;
                this.dataGridView1.Rows[index].Cells[3].Value = txt_cont.Text;
                this.dataGridView1.Rows[index].Cells[4].Value = txt_email.Text;
               
            }*/

            var index = this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[index].Cells[0].Value = txt_num.Text;
            this.dataGridView1.Rows[index].Cells[1].Value = txt_nome.Text;
            this.dataGridView1.Rows[index].Cells[2].Value = cbo_curso.SelectedItem;
            this.dataGridView1.Rows[index].Cells[3].Value = txt_cont.Text;
            this.dataGridView1.Rows[index].Cells[4].Value = txt_email.Text;
 
        }
    }
}
