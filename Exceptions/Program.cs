using System;
using System.Collections;
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

            ArrayList arr = new ArrayList();
            arr.Add(objPessoaFisica1);
            arr.Add("objPessoaFisica3");
            arr.Add(objPessoaFisica2);
            arr.Add(objPessoaFisica3);

            try
            {
                foreach (PessoaFisica pessoa in arr)
                {
                    Console.WriteLine(pessoa.nome);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro: dado invalido " + e.Message);
            }

            Endereco endereco1 = new Endereco();
            endereco1.Id = 1;
            endereco1.Bairro = "bairro1";
            endereco1.Logradouro = "estatico";

            Endereco endereco2 = new Endereco();
            endereco2.Id = 2;
            endereco2.Bairro = "bairro2";
            endereco2.Logradouro = "dinamico";

            objPessoaFisica1.ListaEnderecos = new List<Endereco>();
            objPessoaFisica1.ListaEnderecos.Add(endereco1);
            objPessoaFisica1.ListaEnderecos.Add(endereco2);

            Endereco endereco3 = new Endereco();
            endereco3.Id = 3;
            endereco3.Bairro = "bairro3";
            endereco3.Logradouro = "dinamico";
            objPessoaFisica2.ListaEnderecos = new List<Endereco>();
            objPessoaFisica2.ListaEnderecos.Add(endereco3);

            Endereco endereco4 = new Endereco();
            endereco4.Id = 4;
            endereco4.Bairro = "bairro4";
            endereco4.Logradouro = "estatico";

            Endereco endereco5 = new Endereco();
            endereco5.Id = 5;
            endereco5.Bairro = "bairro5";
            endereco5.Logradouro = "dinamico";

            Endereco endereco6 = new Endereco();
            endereco6.Id = 6;
            endereco6.Bairro = "bairro6";
            endereco6.Logradouro = "dinamico";

            objPessoaFisica3.ListaEnderecos = new List<Endereco>();
            objPessoaFisica3.ListaEnderecos.Add(endereco4);
            objPessoaFisica3.ListaEnderecos.Add(endereco5);
            objPessoaFisica3.ListaEnderecos.Add(endereco6);

            List<PessoaFisica> pessoaFisica = new List<PessoaFisica>();
            pessoaFisica.Add(objPessoaFisica1);
            pessoaFisica.Add(objPessoaFisica2);
            pessoaFisica.Add(objPessoaFisica3);

            foreach(var pessoas in pessoaFisica)
            {
                Console.WriteLine("\nNome: {0} | Data de nascimento: {1}\nEndereço(s):", pessoas.nome, pessoas.dtNascFund);
                foreach (var endereco in pessoas.ListaEnderecos)
                {
                    Console.WriteLine("ID: {0} | Bairro: {1} | Logradouro {2}", endereco.Id, endereco.Bairro, endereco.Logradouro);
                }
            }
        }
    }
}