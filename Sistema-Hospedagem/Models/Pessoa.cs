namespace Sistema_Hospedagem.Models
{
    public class Pessoa
    {

        public Pessoa() {}

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome = string.Empty;
        private string _sobrenome = string.Empty;

        public string Nome 
        { 
            get => _nome;
            
            set 
            {
                 _nome = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("O nome não pode ser vazio(nulo)..");
            }
        }

        public string Sobrenome 
        {   
            get => _sobrenome; 
            
            set
            {
                _sobrenome = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("O sobrenome não pode ser vazio(nulo)..");
            } 
        }
    }
}