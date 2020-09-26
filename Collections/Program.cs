using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica objPessoaFisica1 = new PessoaFisica();
            objPessoaFisica1.nome = "Davi";
            objPessoaFisica1.dtNascFund = new DateTime(2001, 08, 01);

            PessoaFisica objPessoaFisica2 = new PessoaFisica();
            objPessoaFisica2.nome = "Samuel";
            objPessoaFisica2.dtNascFund = new DateTime(1995, 01, 09);

            PessoaFisica objPessoaFisica3 = new PessoaFisica();
            objPessoaFisica3.nome = "Erika";
            objPessoaFisica3.dtNascFund = new DateTime(2001, 06, 01);

            Endereco endereco1 = new Endereco();
            endereco1.Id = 1;
            endereco1.Bairro = "bairro1";
            endereco1.Logradouro = "estatico";
            objPessoaFisica1.ListaEnderecos = new List<Endereco>();
            objPessoaFisica1.ListaEnderecos.Add(endereco1);

            Endereco endereco2 = new Endereco();
            endereco2.Id = 2;
            endereco2.Bairro = "bairro2";
            endereco2.Logradouro = "dinamico";
            objPessoaFisica2.ListaEnderecos = new List<Endereco>();
            objPessoaFisica2.ListaEnderecos.Add(endereco2);

            Endereco endereco3 = new Endereco();
            endereco3.Id = 3;
            endereco3.Bairro = "bairro3";
            endereco3.Logradouro = "estatico";
            objPessoaFisica3.ListaEnderecos = new List<Endereco>();
            objPessoaFisica3.ListaEnderecos.Add(endereco3);

            Queue<PessoaFisica> pessoaFisica = new Queue<PessoaFisica>();
            pessoaFisica.Enqueue(objPessoaFisica1);
            pessoaFisica.Enqueue(objPessoaFisica2);
            pessoaFisica.Enqueue(objPessoaFisica3);

            foreach(var pessoas in pessoaFisica)
            {
                Console.WriteLine("Nome: {0} | Data de nascimento: {1}", pessoas.nome, pessoas.dtNascFund);
                foreach (var endereco in pessoas.ListaEnderecos)
                {
                    Console.WriteLine("ID: {0} | Bairro: {1} | Logradouro {2}", endereco.Id, endereco.Bairro, endereco.Logradouro);
                }
            }
        }
    }
}
