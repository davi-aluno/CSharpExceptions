using System;

namespace POOExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientePJ objClientePJ = new ClientePJ();
            ClientePF objClientePF = new ClientePF();
            Endereco  objEndereco  = new Endereco();

            objClientePJ.Id = 10;
            objClientePJ.Cnpj = "22.725.316/0001-83";
            objClientePJ.Lucro = 10000.50;
            objClientePJ.TipoEmpresa = "Desenvolvimento de jogos";

            objClientePF.Id = 10;
            objClientePF.Cpf = "989.760.840-04";
            objClientePF.Renda = "1000";
            objClientePF.Sexo = "Masculino";

            objEndereco.TipoEndereco = "endereco aleatorio";
            objEndereco.ID = 10;
            objEndereco.Cidade = "endereco aleatorio";
            objEndereco.Logradouro = "endereco aleatorio";
            objEndereco.Bairro = "endereco aleatorio";
            objEndereco.Complemento = "endereco aleatorio";

            Console.WriteLine("CleintePJ:\n" +
                              $"{objClientePJ.Id}\n" +
                              $"{objClientePJ.Cnpj}\n" +
                              $"{objClientePJ.Lucro}\n" +
                              $"{objClientePJ.TipoEmpresa}\n\n" +
                              "ClientePF:\n" +
                              $"{objClientePF.Id}\n" +
                              $"{objClientePF.Cpf}\n" +
                              $"{objClientePF.Renda}\n" +
                              $"{objClientePF.Sexo}\n\n" +
                              "Endereco:\n" +
                              $"{objEndereco.Consultar()}");
        }
    }
}