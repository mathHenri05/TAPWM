using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasse
{
    class MENSALISTA : EMPLOYEE
    {
        public double SlaMensal { get; set; }

        public static String Empresa = "Finka Tech Ltda";


        public override double SlaBruto()
        {
         return SlaMensal;
        }

        public MENSALISTA(int matx, string nomex, DateTime datax,
            double salx)
        {
            this.NomeEmployee = nomex;
            this.Matricula = matx;
            this.DataEntradaEmpresa = datax;
            this.SlaMensal = salx;
        }
        public MENSALISTA()
        {

        }



    }
}
