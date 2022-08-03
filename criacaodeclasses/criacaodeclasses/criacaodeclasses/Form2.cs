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
    public partial class Form2 : Form
    {
        Professor professor;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            professor = new Professor(txtNome.Text, (Convert.ToInt32(txtIdade.Text)), txtTitulacao.Text);
            txtNome.Clear();
            txtIdade.Clear();
            txtTitulacao.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(professor.ImprimeDados());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 principal = new Form1();
            principal.Show();
        }
    }
}
