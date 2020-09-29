using System;

namespace Collections
{
    abstract class Pessoa
    {
        public string nome { get; set; }
        public DateTime dtNascFund { get; set; }
        public string email { get; set; }
        public Endereco endereco;
    }
}