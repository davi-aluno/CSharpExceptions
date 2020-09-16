using System;
using System.Collections.Generic;
using System.Text;

namespace POOExercise
{
    class ClientePJ : Pessoa
    {
        private long ID;
        private string cnpj;
        private double lucro;
        private string tipoEmpresa;

        public long Id
        {
            get => ID;
            set => ID = value;
        }

        public string Cnpj
        {
            get => cnpj;
            set => cnpj = value;
        }

        public double Lucro
        {
            get => lucro;
            set => lucro = value;
        }

        public string TipoEmpresa
        {
            get => tipoEmpresa;
            set => tipoEmpresa = value;
        }
    }
}
