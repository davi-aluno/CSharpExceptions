using System;
using System.Collections.Generic;
using System.Text;

namespace POOExercise
{
    class ClientePF : Pessoa
    {
        private long id;
        private string cpf;
        private string renda;
        private string sexo;

        public long Id
        {
            get => id;
            set => id = value;
        }

        public string Cpf
        {
            get => cpf;
            set => cpf = value;
        }

        public string Renda
        {
            get => renda;
            set => renda = value;
        }

        public string Sexo
        {
            get => sexo;
            set => sexo = value;
        }
    }
}
