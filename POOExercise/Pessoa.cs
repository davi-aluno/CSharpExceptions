using System;
using System.Collections.Generic;
using System.Text;

namespace POOExercise
{
    abstract class Pessoa
    {
        private string nome;
        private string dtNascFund;
        private string email;
        public Endereco endereco;

        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public string DtNascFund
        {
            get => dtNascFund;
            set => dtNascFund = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }
    }
}