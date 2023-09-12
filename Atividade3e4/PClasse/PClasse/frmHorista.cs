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
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            HORISTA ObjHorista = new HORISTA();

            ObjHorista.NomeEmployee = txtNome.Text;
            ObjHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            ObjHorista.SalarioHora = Convert.ToDouble(txtSalario.Text);
            ObjHorista.NumeroHora = Convert.ToDouble(txtHora.Text);
            ObjHorista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            ObjHorista.DiasFalta = Convert.ToInt32(txtFaltas.Text);

            MessageBox.Show("Nome:" + ObjHorista.NomeEmployee +
                "\n" + "Matrícula:" + ObjHorista.Matricula + "\n" +
                "Tempo Trabalho:" + ObjHorista.TempoTrabalho().ToString()
                + "\n" + "Salário" + ObjHorista.SalarioBruto().ToString("N2"));
        }

        private void TxtHora_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
