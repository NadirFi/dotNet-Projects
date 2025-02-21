namespace Sistema_Celulares.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria) {}

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o Aplicativo {nome} no Nokia");
        }
    }
}