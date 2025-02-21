namespace Sistema_Celulares.Models
{
    public abstract class Smartphone
    {


        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public string Numero { get; set; }
        
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public void Ligar() 
        {
            Console.WriteLine($"{Modelo} - Ligando....");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"{Modelo} - Recebendo Ligação....");
        }

        public abstract void InstalarAplicativo(string nome);
    }
}