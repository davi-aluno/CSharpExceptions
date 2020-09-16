using System;
using System.Collections.Generic;
using System.Text;

namespace POOExercise
{
    class PessoaFisica : Pessoa
    {
        public int id { get; set; }
        public string cpf { get; set; }
        public double renda { get; set; }
        public string sexo { get; set; }
    }
}
