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
    public partial class frmcami : Form
    {
        Caminhao caminhao;

        public frmcami()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmcadastro inicial = new frmcadastro();
            this.Hide();
            inicial.Show();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            caminhao = new Caminhao(txtmarca.Text, txtmodel.Text, txtcha.Text, (Convert.ToInt32(txtkm.Text)), txtcor.Text, (Convert.ToInt32(txtano.Text)), txtplaca.Text, txtbau.Text, txtcarga.Text, (Convert.ToInt32(txtrodas.Text)));

        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(caminhao.Dados());
        }

        private void frmcami_Load(object sender, EventArgs e)
        {

        }

        private void txtrodas_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtbau.Clear();
            txtcarga.Clear();
            txtmarca.Clear();
            txtcor.Clear();
            txtmodel.Clear();
            txtrodas.Clear();
            txtplaca.Clear();
            txtkm.Clear();
            txtcha.Clear();
            txtano.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
