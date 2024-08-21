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
            switch (cmbForma.Text)
            {
                case "Quadrado":
                    SelecionarQuadrado();
                    break;
                case "Triangulo":
                    break;
                default:
                    break;

            }
            SelecionarTriângulos();
            txtBase.Visible = cmbForma.Text.Equals("Quadrado");

        }

        private void SelecionarQuadrado()
        {
            ExibirBase(true);
            ExibitAltura(false);
            lblRaio.Visible = txtraio.Visible = false;
            txtArea.Visible = lblArea.Visible = false;


        }


        private void cmbTriangulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void SelecionarTriângulos()
        {
            ExibirBase(true);
            cmbTriangulo.Visible = cmbForma.Text.Equals("Triângulo");
            lblArea.Visible = cmbForma.Text.Equals("Triângulo");
            txtArea.Visible = cmbForma.Text.Equals("Triângulo");

        }


        void ExibirBase(bool visivel)
        {
            lblbase.Visible = txtBase.Visible = visivel;
        }


        private void ExibitAltura(bool visivel)
        {
            lblAltura.Visible = txtaltura.Visible = visivel;
        }
        
        private void btnCriar_Click(object sender, EventArgs e)
        {
            if(cmbForma.Text.Equals("Quadrado"))
            {

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
