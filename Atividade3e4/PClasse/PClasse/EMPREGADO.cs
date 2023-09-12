using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasse
{
    abstract class EMPLOYEE
    {
        private int matricula; // atributo
        private string nomeEmployee;
        private DateTime dataEntradaEmpresa;
        private char HO;

        public int Matricula // propriedade
        {
            get { return matricula; }
            set { matricula = value; }

        }
        public string nomeEmployee
        {
            get { return nomeEmployee; }
            set { nomeEmployee = value; }
        }

        public DateTime DataEntradaEmpresa
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }
        public char HO
        {
            get { return HO; }
            set { HO = value; }
        }

        //métodos

        public String VerificaHome()//método
        {
            if (HO == 'S')
                return "Empregado trabalha em home office";
            else
                return "Empregado NÃO trabalha em home Office";
        }
        //virtual --> pode ser sobreescrito

        public virtual int TempoTrabalho()
        {
            //representa um intervalo de tempo
            TimeSpan span = DateTime.Today.Subtract
                (DataEntradaEmpresa);

            return (span.Days);
        }
        public abstract double SalarioBruto();

        public EMPLOYEE()
        {
            System.Windows.Forms.MessageBox.Show("PASSEI POR AQUI");
        }

        public EMPLOYEE(int mat, string nome, DateTime datax)
        {
            matricula = mat;
            nomeEmployee = nome;
            dataEntradaEmpresa = datax;
        }
    }


}
