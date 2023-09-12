using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmMensalista frmMens = new frmMensalista();
            frmMens.Show();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmHorista FrmH = new frmHorista();
            FrmH.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
