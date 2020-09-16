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

            objClientePJ.nome = "Davi";
            objClientePJ.dtNascFund = "01/01/2001";
            objClientePJ.email = "davi.israel01@greensystem.com";
            objClientePJ.id = 10;
            objClientePJ.cnpj = "95.796.199/0001-12";
            objClientePJ.lucro = 10000.00;
            objClientePJ.tipoEmpresa = "Desenvolvimento de jogos";

            objClientePJ.endereco = new Endereco();
            objClientePJ.endereco.TipoEndereco = "casa";
            objClientePJ.endereco.Id = 11;
            objClientePJ.endereco.Cidade = "São Paulo";
            objClientePJ.endereco.Logradouro = "Santo André";
            objClientePJ.endereco.Bairro = "Parque Marajoara 2";
            objClientePJ.endereco.Complemento = "Perto de uma escola";

            objClientePF.id = 13;
            objClientePF.cpf = "426.745.130-39";
            objClientePF.renda = 15000.00;
            objClientePF.sexo = "Masculino";

            objPessoaFisica.nome = "Davi";
            objPessoaFisica.dtNascFund = "01/01/2001";
            objPessoaFisica.email = "davi.israel01@greensystem.com";
            objPessoaFisica.id = 10;
            objPessoaFisica.cpf = "752.056.350-29";
            objPessoaFisica.renda = 12000.00;
            objPessoaFisica.sexo = "Masculino";

            objPessoaFisica.endereco = new Endereco();
            objPessoaFisica.endereco.TipoEndereco = "casa";
            objPessoaFisica.endereco.Id = 11;
            objPessoaFisica.endereco.Cidade = "São Paulo";
            objPessoaFisica.endereco.Logradouro = "Santo André";
            objPessoaFisica.endereco.Bairro = "Parque Marajoara 2";
            objPessoaFisica.endereco.Complemento = "Perto de uma escola";

            Console.WriteLine($"objClientePJ:\n" +
                              $"Nome: {objClientePJ.nome}\n" +
                              $"DtNascFund: {objClientePJ.dtNascFund}\n" +
                              $"Email: {objClientePJ.email}\n" +
                              $"Id: {objClientePJ.id}\n" +
                              $"Cnpj: {objClientePJ.cnpj}\n" +
                              $"Lucro: {objClientePJ.lucro}\n" +
                              $"TipoEmpresa: {objClientePJ.tipoEmpresa}\n\n" +
                              $"Informações completas do endereço da ClientePJ:\n" +
                              $"Endereço TipoEndereco: {objClientePJ.endereco.TipoEndereco}\n" +
                              $"Endereço ID: {objClientePJ.endereco.Id}\n" +
                              $"Endereço Cidade: {objClientePJ.endereco.Cidade}\n" +
                              $"Endereço Logradouro: {objClientePJ.endereco.Logradouro}\n" +
                              $"Endereço Bairro: {objClientePJ.endereco.Bairro}\n" +
                              $"Endereco Complemento: {objClientePJ.endereco.Complemento}\n\n" +
                              $"objClientePF:\n" +
                              $"Id: {objClientePF.id}\n" +
                              $"Cpf: {objClientePF.cpf}\n" +
                              $"Renda: {objClientePF.renda}\n" +
                              $"Sexo: {objClientePF.sexo}\n\n" +
                              $"objPessoaFisica:\n" +
                              $"Nome: {objPessoaFisica.nome}\n" +
                              $"DtNascFund: {objPessoaFisica.dtNascFund}\n" +
                              $"Email: {objPessoaFisica.email}\n" +
                              $"Id: {objPessoaFisica.id}\n" +
                              $"CPF: {objPessoaFisica.cpf}\n" +
                              $"Renda: {objPessoaFisica.renda}\n" +
                              $"Sexo: {objPessoaFisica.sexo}\n\n" +
                              $"Informações completas do endereço da PessoaFisica:\n" +
                              $"Endereço TipoEndereco: {objPessoaFisica.endereco.TipoEndereco}\n" +
                              $"Endereço ID: {objPessoaFisica.endereco.Id}\n" +
                              $"Endereço Cidade: {objPessoaFisica.endereco.Cidade}\n" +
                              $"Endereço Logradouro: {objPessoaFisica.endereco.Logradouro}\n" +
                              $"Endereço Bairro: {objPessoaFisica.endereco.Bairro}\n" +
                              $"Endereco Complemento: {objPessoaFisica.endereco.Complemento}\n\n");
        }
    }
}