using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaExemploAPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionarTriangulo();
        }

        private void SelecionarTriangulo()
        {
            cmbTriangulo.Visible = cmbForma.Text.Equals("Triângulo");

            txtBase.Visible = cmbForma.Text.Equals("Triângulo");
            txtAltura.Visible = cmbForma.Text.Equals("Triângulo");

            lblBase.Visible = cmbForma.Text.Equals("Triângulo");
            lblAltura.Visible = cmbForma.Text.Equals("Triângulo");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
