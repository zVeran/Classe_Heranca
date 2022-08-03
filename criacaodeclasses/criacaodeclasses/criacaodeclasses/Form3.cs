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
    public partial class Form3 : Form
    {
        Aluno aluno;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            aluno = new Aluno(txtNome.Text, (Convert.ToInt32(txtIdade.Text)), txtCurso.Text);
            txtNome.Clear();
            txtIdade.Clear();
            txtCurso.Clear();
        }

        private void bntExibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aluno.ImprimeDados());
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 principal = new Form1();
            principal.Show();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
