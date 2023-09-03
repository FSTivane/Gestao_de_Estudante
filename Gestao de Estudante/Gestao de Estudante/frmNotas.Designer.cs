namespace Gestao_de_Estudante
{
    partial class frmNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_numEstudante = new System.Windows.Forms.ComboBox();
            this.lbl_nomeEst = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_disciplina = new System.Windows.Forms.ComboBox();
            this.cbo_tipoAvailicao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubmeter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Estudante:";
            // 
            // cbx_numEstudante
            // 
            this.cbx_numEstudante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_numEstudante.FormattingEnabled = true;
            this.cbx_numEstudante.Location = new System.Drawing.Point(170, 39);
            this.cbx_numEstudante.MinimumSize = new System.Drawing.Size(80, 0);
            this.cbx_numEstudante.Name = "cbx_numEstudante";
            this.cbx_numEstudante.Size = new System.Drawing.Size(145, 26);
            this.cbx_numEstudante.TabIndex = 1;
            // 
            // lbl_nomeEst
            // 
            this.lbl_nomeEst.AutoSize = true;
            this.lbl_nomeEst.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_nomeEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeEst.Location = new System.Drawing.Point(41, 74);
            this.lbl_nomeEst.Name = "lbl_nomeEst";
            this.lbl_nomeEst.Size = new System.Drawing.Size(400, 20);
            this.lbl_nomeEst.TabIndex = 2;
            this.lbl_nomeEst.Text = "Nome.....                                                                ";
            this.lbl_nomeEst.Click += new System.EventHandler(this.lbl_nomeEst_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Disciplina:";
            // 
            // cbx_disciplina
            // 
            this.cbx_disciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_disciplina.FormattingEnabled = true;
            this.cbx_disciplina.Location = new System.Drawing.Point(170, 123);
            this.cbx_disciplina.MinimumSize = new System.Drawing.Size(80, 0);
            this.cbx_disciplina.Name = "cbx_disciplina";
            this.cbx_disciplina.Size = new System.Drawing.Size(145, 26);
            this.cbx_disciplina.TabIndex = 4;
            this.cbx_disciplina.SelectedIndexChanged += new System.EventHandler(this.cbx_disciplina_SelectedIndexChanged);
            // 
            // cbo_tipoAvailicao
            // 
            this.cbo_tipoAvailicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tipoAvailicao.FormattingEnabled = true;
            this.cbo_tipoAvailicao.Location = new System.Drawing.Point(170, 168);
            this.cbo_tipoAvailicao.MinimumSize = new System.Drawing.Size(80, 0);
            this.cbo_tipoAvailicao.Name = "cbo_tipoAvailicao";
            this.cbo_tipoAvailicao.Size = new System.Drawing.Size(145, 26);
            this.cbo_tipoAvailicao.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de availiacao";
            // 
            // txt_nota
            // 
            this.txt_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nota.Location = new System.Drawing.Point(170, 215);
            this.txt_nota.MinimumSize = new System.Drawing.Size(80, 30);
            this.txt_nota.Name = "txt_nota";
            this.txt_nota.Size = new System.Drawing.Size(145, 24);
            this.txt_nota.TabIndex = 7;
            this.txt_nota.TextChanged += new System.EventHandler(this.txt_nota_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nota:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSubmeter);
            this.panel1.Controls.Add(this.lbl_nomeEst);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_nota);
            this.panel1.Controls.Add(this.cbx_numEstudante);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbo_tipoAvailicao);
            this.panel1.Controls.Add(this.cbx_disciplina);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 326);
            this.panel1.TabIndex = 9;
            // 
            // btnSubmeter
            // 
            this.btnSubmeter.Location = new System.Drawing.Point(69, 280);
            this.btnSubmeter.Name = "btnSubmeter";
            this.btnSubmeter.Size = new System.Drawing.Size(75, 23);
            this.btnSubmeter.TabIndex = 9;
            this.btnSubmeter.Text = "Submeter";
            this.btnSubmeter.UseVisualStyleBackColor = true;
            this.btnSubmeter.Click += new System.EventHandler(this.btnSubmeter_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 357);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 34);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSair.Location = new System.Drawing.Point(401, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(70, 28);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 401);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmNotas";
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_numEstudante;
        private System.Windows.Forms.Label lbl_nomeEst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_disciplina;
        private System.Windows.Forms.ComboBox cbo_tipoAvailicao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSubmeter;
    }
}