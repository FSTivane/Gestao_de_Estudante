namespace Gestao_de_Estudante
{
    partial class frmGestaoAcademica
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_discpnome = new System.Windows.Forms.TextBox();
            this.btnSubmeter = new System.Windows.Forms.Button();
            this.txt_nomedisc = new System.Windows.Forms.Label();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_discpnome);
            this.groupBox3.Controls.Add(this.btnSubmeter);
            this.groupBox3.Controls.Add(this.txt_nomedisc);
            this.groupBox3.Controls.Add(this.txt_cod);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(4, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 171);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cadastrar Disciplinas";
            // 
            // txt_discpnome
            // 
            this.txt_discpnome.Location = new System.Drawing.Point(110, 71);
            this.txt_discpnome.Name = "txt_discpnome";
            this.txt_discpnome.Size = new System.Drawing.Size(179, 20);
            this.txt_discpnome.TabIndex = 3;
            // 
            // btnSubmeter
            // 
            this.btnSubmeter.Location = new System.Drawing.Point(214, 109);
            this.btnSubmeter.Name = "btnSubmeter";
            this.btnSubmeter.Size = new System.Drawing.Size(75, 23);
            this.btnSubmeter.TabIndex = 6;
            this.btnSubmeter.Text = "Submeter";
            this.btnSubmeter.UseVisualStyleBackColor = true;
            this.btnSubmeter.Click += new System.EventHandler(this.btnSubmeter_Click);
            // 
            // txt_nomedisc
            // 
            this.txt_nomedisc.AutoSize = true;
            this.txt_nomedisc.Location = new System.Drawing.Point(6, 74);
            this.txt_nomedisc.Name = "txt_nomedisc";
            this.txt_nomedisc.Size = new System.Drawing.Size(98, 13);
            this.txt_nomedisc.TabIndex = 2;
            this.txt_nomedisc.Text = "Nome da Disciplina";
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(110, 29);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(107, 20);
            this.txt_cod.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Codigo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Location = new System.Drawing.Point(4, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 34);
            this.panel1.TabIndex = 7;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSair.Location = new System.Drawing.Point(322, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(69, 28);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmGestaoAcademica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 224);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmGestaoAcademica";
            this.Text = "Gestao Academica";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_discpnome;
        private System.Windows.Forms.Button btnSubmeter;
        private System.Windows.Forms.Label txt_nomedisc;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
    }
}