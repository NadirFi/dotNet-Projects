namespace Sistema_Hospedagem.Models
{
    public class Reserva
    {
        public Reserva() {}

        public Reserva(List<Pessoa> hospedes, Suite suite ,int diasReservados)
        {
            Hospedes = hospedes;
            Suite = suite;
            DiasReservados = diasReservados;
        }

        private List<Pessoa> _hospedes = new List<Pessoa>();
        private Suite _suite = new Suite();

        private int _diasReservados = 0;
        
        private List<Pessoa> Hospedes
        { 
            get => _hospedes;
            set => _hospedes = value;
        }

        private Suite Suite 
        { 
            get => _suite; 
            set => _suite = value;
        }

        private int DiasReservados 
        { 
            get => _diasReservados; 
            set => _diasReservados = value;
        }

        // public void CadastrarHospedes(List<Pessoa> hospedes)
        // {
        //         Hospedes = hospedes;
        // }

        // public void CadastrarSuite(Suite suite)
        // {
        //     Suite = suite;
        // }

        // public int ObterQtdHospedes()
        // {
        //     return Hospedes.Count;
        // }

        public decimal CalcularValorDiaria()
        {
            if (DiasReservados >= 10)
            {
                double valorToral = Convert.ToDouble(Suite.ValorDiaria * DiasReservados);
                double valorDesconto = valorToral - (valorToral * 0.10);
                
                return Convert.ToDecimal(valorDesconto);
            }
            return Suite.ValorDiaria * DiasReservados;
        }

    }
}