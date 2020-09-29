using System.Collections.Generic;

namespace Exceptions
{
    class PessoaFisica : Pessoa
    {
        public int id { get; set; }
        public string cpf { get; set; }
        public double renda { get; set; }
        public string sexo { get; set; }

        public List<Endereco> ListaEnderecos { get; set; }
    }
}
