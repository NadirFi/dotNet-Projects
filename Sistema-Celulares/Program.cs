using Sistema_Celulares.Models;

Console.WriteLine("=========================================================");
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("40028922", "A52", "01010101", 32);
nokia.Ligar();
nokia.InstalarAplicativo("'Chamada Personalizada'");
Console.WriteLine("=========================================================");

Console.WriteLine("=========================================================");
Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("92565614", "Iphone 8", "02020202", 128);
iphone.Ligar();
iphone.InstalarAplicativo("'Safari'");
Console.WriteLine("=========================================================");

Console.WriteLine("=========================================================");
nokia.ReceberLigacao();
iphone.ReceberLigacao();
Console.WriteLine("=========================================================");