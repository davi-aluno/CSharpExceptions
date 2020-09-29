using System;

namespace Exceptions
{
    abstract class Pessoa
    {
        public string nome { get; set; }
        public DateTime dtNascFund { get; set; }
        public string email { get; set; }
        public Endereco endereco;
    }
}