using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Array
{
    public class Funcionario
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;

        }

        public Funcionario()
        {

        }


        public void AumentoSalario(double perce)
        {

            Salario += Salario * perce / 100.0;
        }

        public override string ToString()
        {
            return Id
                + ","
                + Nome
                + ","
                + Salario.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
