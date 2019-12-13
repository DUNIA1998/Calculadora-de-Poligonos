using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poligono;

namespace Calculadora_de_Poligonos
{
    public partial class CalculadoraForm : Form
    {
        public CalculadoraForm()
        {
            InitializeComponent();
        }


        Poligonos figuraSelecionada;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcularPerimetro_Click(object sender, EventArgs e)
        {

        }

        private void btnPerimetro_Load(object sender, EventArgs e)
        {

        }

        private void PrincipalTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PrincipalTabControl.SelectedIndex == 0)
            {
                figuraSelecionada = new Triangulo();
                lblFigura.Text = figuraSelecionada.Nombre;
            }
            if (PrincipalTabControl.SelectedIndex == 1)
            {
                figuraSelecionada = new Rectangulo();
                lblFigura.Text = figuraSelecionada.Nombre;
            }
            if (PrincipalTabControl.SelectedIndex == 2)
            {
                figuraSelecionada = new Circulo();
                lblFigura.Text = figuraSelecionada.Nombre;
            }
            if (PrincipalTabControl.SelectedIndex == 3)
            {
                figuraSelecionada = new Rectangulo();
                lblFigura.Text = figuraSelecionada.Nombre;
            }
            if (PrincipalTabControl.SelectedIndex == 4)
            {
                figuraSelecionada = new Pentagono();
                lblFigura.Text = figuraSelecionada.Nombre;
            }

        }

        private void LadoCLabel_Click(object sender, EventArgs e)
        {

        }

        private void LadoCTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void AlturaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AlturaTextBox_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)figuraSelecionada;
            triangulo.Altura = Convert.ToDouble(AlturaTextBox.Text);
        }
    }
}
