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
    public partial class frmcadastro : Form
    {
        public frmcadastro()
        {
            InitializeComponent();
        }

        private void btncami_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcami Caminhao = new frmcami();
            Caminhao.Show();
        }

        private void btncar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcarro Carro = new frmcarro();
            Carro.Show();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
