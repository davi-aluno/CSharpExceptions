using System;
using System.Collections.Generic;
using System.Text;

namespace POOExercise
{
    class PessoaFisica : Pessoa
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public double Renda { get; set; }
        public string Sexo { get; set; }
    }
}
