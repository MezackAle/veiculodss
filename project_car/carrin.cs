using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_car
{
    public partial class frmcarro : Form
    {
        Carro carro;

        public frmcarro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmcadastro inicial = new frmcadastro();
            this.Hide();
            inicial.Show();

        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carro.Dados());
        }

        private void btncad_Click(object sender, EventArgs e)
        {
            carro = new Carro(txtmarca.Text, txtmodel.Text, txtcha.Text, (Convert.ToInt32(txtkm.Text)), txtcor.Text, (Convert.ToInt32(txtano.Text)), txtplaca.Text, txtbag.Text, (Convert.ToInt32(txtportas.Text)), txtcarroceria.Text);

        }

        private void txtmodel_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmcarro_Load(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtano.Clear();
            txtbag.Clear();
            txtcarroceria.Clear();
            txtcha.Clear();
            txtcor.Clear();
            txtkm.Clear();
            txtmarca.Clear();
            txtmodel.Clear();
            txtplaca.Clear();
            txtportas.Clear();
        }
    }
}
