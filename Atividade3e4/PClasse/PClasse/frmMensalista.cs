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
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMensalista_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MENSALISTA objMensalista = new MENSALISTA();
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmployee = txtNome.Text;
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalario.Text);
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            if (rbtnSim.Checked)
                objMensalista.HO = 'S';
            else
                objMensalista.HO = 'N';

            //get
            MessageBox.Show("Matrícula: " + objMensalista.Matricula + "\n" +
                "Nome: " + objMensalista.NomeEmployee + "\n" +
                "Data Entrada: " +
                objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                "Salário Bruto" + objMensalista.SalarioBruto().ToString("N2") + "\n" +
                "Tempo Empresa (dias): " + objMensalista.TempoTrabalho() + "\n" + objMensalista.VerificaHome());

            MessageBox.Show(MENSALISTA.Empresa);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MENSALISTA ObjMensalista = new MENSALISTA(
                Convert.ToInt32(txtMatricula.Text),
                txtNome.Text, Convert.ToDateTime(txtData.Text),
                Convert.ToDouble(txtSalario.Text));

                 MessageBox.Show("Matrícula: " + ObjMensalista.Matricula + "\n" +
                "Nome: " + ObjMensalista.NomeEmployee + "\n" +
                "Data Entrada: " +
                ObjMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                "Salário Bruto" + ObjMensalista.SalarioBruto().ToString("N2") + "\n" +
                "Tempo Empresa (dias): " + ObjMensalista.TempoTrabalho() + "\n" + ObjMensalista.VerificaHome());
        }
    }
}
