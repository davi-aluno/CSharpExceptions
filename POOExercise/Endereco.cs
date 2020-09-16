using System;
using System.Collections.Generic;
using System.Text;

namespace POOExercise
{
    class Endereco : IEndereco
    {
        public string TipoEndereco { get; set; }
        public long ID { get; set; }
        public string Cidade{ get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Consultar()
        {
            return $"Tipo endereco {TipoEndereco}\n" +
                   $"ID: {ID}\n" +
                   $"Cidade: {Cidade}\n" +
                   $"Logradouro: {Logradouro}\n" +
                   $"Bairro: {Bairro}\n" +
                   $"Complemento: {Complemento}";
        }
    }
}
