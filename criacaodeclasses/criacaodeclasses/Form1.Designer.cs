namespace criacaodeclasses
{
    partial class Form1
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
            this.btnProfessor = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProfessor
            // 
            this.btnProfessor.BackColor = System.Drawing.Color.Azure;
            this.btnProfessor.Location = new System.Drawing.Point(75, 145);
            this.btnProfessor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(161, 44);
            this.btnProfessor.TabIndex = 0;
            this.btnProfessor.Text = "Cadastrar Profssor";
            this.btnProfessor.UseVisualStyleBackColor = false;
            this.btnProfessor.Click += new System.EventHandler(this.btnProfessor_Click);
            // 
            // btnAluno
            // 
            this.btnAluno.BackColor = System.Drawing.Color.Azure;
            this.btnAluno.Location = new System.Drawing.Point(75, 219);
            this.btnAluno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(161, 44);
            this.btnAluno.TabIndex = 1;
            this.btnAluno.Text = "Cadastrar Aluno";
            this.btnAluno.UseVisualStyleBackColor = false;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Azure;
            this.btnSair.Location = new System.Drawing.Point(75, 292);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(161, 44);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(325, 418);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAluno);
            this.Controls.Add(this.btnProfessor);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Entrada";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfessor;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Button btnSair;
    }
}

