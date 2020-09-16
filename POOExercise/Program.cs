using System;

namespace POOExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientePJ    objClientePJ = new ClientePJ();
            ClientePF    objClientePF = new ClientePF();
            PessoaFisica objPessoaFisica = new PessoaFisica();

            objClientePJ.Nome = "Davi";
            objClientePJ.DtNascFund = "01/01/2001";
            objClientePJ.Email = "davi.israel01@greensystem.com";
            objClientePJ.Id = 10;
            objClientePJ.Cnpj = "95.796.199/0001-12";
            objClientePJ.Lucro = 1000.00;
            objClientePJ.TipoEmpresa = "Desenvolvimento de jogos";

            objClientePJ.endereco = new Endereco();
            objClientePJ.endereco.TipoEndereco = "casa";
            objClientePJ.endereco.Id = 11;
            objClientePJ.endereco.Cidade = "São Paulo";
            objClientePJ.endereco.Logradouro = "Santo André";
            objClientePJ.endereco.Bairro = "Parque Marajoara 2";
            objClientePJ.endereco.Complemento = "Perto de uma escola";

            objClientePF.Id = 13;
            objClientePF.Cpf = "426.745.130-39";
            objClientePF.Renda = "1000,00 R$";
            objClientePF.Sexo = "Masculino";

            objPessoaFisica.Nome = "Davi";
            objPessoaFisica.DtNascFund = "01/01/2001";
            objPessoaFisica.Email = "davi.israel01@greensystem.com";
            objPessoaFisica.Id = 10;
            objPessoaFisica.Cpf = "426.745.130-39";
            objPessoaFisica.Renda = 12000.00;
            objPessoaFisica.Sexo = "Masculino";

            objPessoaFisica.endereco = new Endereco();
            objPessoaFisica.endereco.TipoEndereco = "casa";
            objPessoaFisica.endereco.Id = 11;
            objPessoaFisica.endereco.Cidade = "São Paulo";
            objPessoaFisica.endereco.Logradouro = "Santo André";
            objPessoaFisica.endereco.Bairro = "Parque Marajoara 2";
            objPessoaFisica.endereco.Complemento = "Perto de uma escola";

            Console.WriteLine($"objClientePJ:\n" +
                              $"Nome: {objClientePJ.Nome}\n" +
                              $"DtNascFund: {objClientePJ.DtNascFund}\n" +
                              $"Email: {objClientePJ.Email}\n" +
                              $"Id: {objClientePJ.Id}\n" +
                              $"Cnpj: {objClientePJ.Cnpj}\n" +
                              $"Lucro: {objClientePJ.Lucro}\n" +
                              $"TipoEmpresa: {objClientePJ.TipoEmpresa}\n" +
                              $"Endereço TipoEndereco: {objClientePJ.endereco.TipoEndereco}\n" +
                              $"Endereço ID: {objClientePJ.endereco.Id}\n" +
                              $"Endereço Cidade: {objClientePJ.endereco.Cidade}\n" +
                              $"Endereço Logradouro: {objClientePJ.endereco.Logradouro}\n" +
                              $"Endereço Bairro: {objClientePJ.endereco.Bairro}\n" +
                              $"Endereco Complemento: {objClientePJ.endereco.Complemento}\n\n" +
                              $"objClientePF:\n" +
                              $"Id: {objClientePF.Id}\n" +
                              $"Cpf: {objClientePF.Cpf}\n" +
                              $"Renda: {objClientePF.Renda}\n" +
                              $"Sexo: {objClientePF.Sexo}\n\n" +
                              $"objPessoaFisica:\n" +
                              $"Nome: {objPessoaFisica.Nome}\n" +
                              $"DtNascFund: {objPessoaFisica.DtNascFund}\n" +
                              $"Email: {objPessoaFisica.Email}\n" +
                              $"Id: {objPessoaFisica.Id}\n" +
                              $"CPF: {objPessoaFisica.Cpf}\n" +
                              $"Renda: {objPessoaFisica.Renda}\n" +
                              $"Sexo: {objPessoaFisica.Sexo}\n" +
                              $"Endereço TipoEndereco: {objPessoaFisica.endereco.TipoEndereco}\n" +
                              $"Endereço ID: {objPessoaFisica.endereco.Id}\n" +
                              $"Endereço Cidade: {objPessoaFisica.endereco.Cidade}\n" +
                              $"Endereço Logradouro: {objPessoaFisica.endereco.Logradouro}\n" +
                              $"Endereço Bairro: {objPessoaFisica.endereco.Bairro}\n" +
                              $"Endereco Complemento: {objPessoaFisica.endereco.Complemento}\n\n");
        }
    }
}