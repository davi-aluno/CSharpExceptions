namespace POOExercise
{
    abstract class Pessoa
    {
        public string nome { get; set; }
        public string dtNascFund { get; set; }
        public string email { get; set; }
        public Endereco endereco;
    }
}