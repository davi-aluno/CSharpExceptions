using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica objPessoaFisica = new PessoaFisica();
            objPessoaFisica.nome = "Davi";
            objPessoaFisica.dtNascFund = new DateTime(2001, 08, 01);

            Endereco endereco1 = new Endereco();
            endereco1.Id = 1;
            endereco1.Bairro = "bairro1";
            endereco1.Logradouro = "estatico";
            objPessoaFisica.ListaEnderecos = new List<Endereco>();
            objPessoaFisica.ListaEnderecos.Add(endereco1);

            Endereco endereco2 = new Endereco();
            endereco2.Id = 2;
            endereco2.Bairro = "bairro2";
            endereco2.Logradouro = "dinamico";
            objPessoaFisica.ListaEnderecos.Add(endereco2);

            Endereco endereco3 = new Endereco();
            endereco3.Id = 3;
            endereco3.Bairro = "bairro3";
            endereco3.Logradouro = "estatico";
            objPessoaFisica.ListaEnderecos.Add(endereco3);

            List<PessoaFisica> pessoaFisica = new List<PessoaFisica>();
            pessoaFisica.Add(objPessoaFisica);

            foreach (var x in objPessoaFisica.ListaEnderecos)
            {
                foreach (var p in pessoaFisica)
                {
                    Console.WriteLine("Nome: {0} | Data de nascimento: {1}", p.nome, p.dtNascFund);
                    Console.WriteLine("ID: {0} | Bairro: {1} | Logradouro {2}", x.Id, x.Bairro, x.Logradouro);
                }
            }
        }
    }
}
