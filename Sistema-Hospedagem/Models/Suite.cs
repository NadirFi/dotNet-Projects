namespace Sistema_Hospedagem.Models
{
    public class Suite
    {
        public Suite() {}

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        private string _tipoSuite = string.Empty;
        private int _capacidade = 0;
        private decimal _valorDiaria = 0.00M;

        public string TipoSuite 
        { 
            get => _tipoSuite; 
            set 
            {
                _tipoSuite = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("O tipo da Suite não pode ser vazio(nulo)..");
            }
        }

        public int Capacidade 
        { 
            get => _capacidade; 
            set 
            {
                _capacidade = value > 0 ? value : throw new ArgumentException("A capacidade não pode ser Zero ou nulo..");
            }
        }

        public decimal ValorDiaria 
        { 
            get => _valorDiaria; 
            set 
            {
                _valorDiaria = value > 0 ? value : throw new ArgumentException("O valor da Suite não pode ser vazio(nulo)..");
            }
        }
    }
}