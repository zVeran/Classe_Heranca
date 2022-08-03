using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace criacaodeclasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 professor = new Form2();
            professor.Show();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 aluno = new Form3();
            aluno.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.Exit();
        }
    }
}
