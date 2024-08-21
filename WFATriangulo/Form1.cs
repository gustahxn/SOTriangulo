using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFATriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionarTriângulos();

        }

        private void cmbTriangulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void SelecionarTriângulos()
        {
            cmbTriangulo.Visible = cmbForma.Text.Equals("Triângulo");
            lblbase.Visible = cmbForma.Text.Equals("Triângulo");
            txtBase.Visible = cmbForma.Text.Equals("Triângulo");
            lblArea.Visible = cmbForma.Text.Equals("Triângulo");
            txtArea.Visible = cmbForma.Text.Equals("Triângulo");
            txtaltura.Visible = cmbForma.Text.Equals("Triângulo");
            lblAltura.Visible = cmbForma.Text.Equals("Triângulo");
        }
    }
}
