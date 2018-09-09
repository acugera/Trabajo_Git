using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Git
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void lblPrueva_Click(object sender, EventArgs e)
        {
            if  (lblPrueva.Text == "--Prueba--")
                lblPrueva.Text = "-Prueba-";
            else
                lblPrueva.Text = "--Prueba--";
        }
    }
}
