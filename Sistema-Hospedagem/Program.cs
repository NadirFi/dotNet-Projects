using Sistema_Hospedagem.Models;

string? opcao = string.Empty;

bool exibirMenu = true;

while (exibirMenu)
{
    opcao = string.Empty;
    //Console.Clear();
    Console.WriteLine("Digite a sua opção:  ");
    Console.WriteLine("1 - Listar Suites.");
    Console.WriteLine("2 - Reservar uma Suite.");
    Console.WriteLine("3 - Encerrar.");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Suite Pequena       - Diaria: R$ 10,00 - Capacidade: 2 Hospedes");
            Console.WriteLine("Suite Intermediaria - Diaria: R$ 20,00 - Capacidade: 4 Hospedes");
            Console.WriteLine("Suite Grande        - Diaria: R$ 40,00 - Capacidade: 8 Hospedes");
            Console.WriteLine("Suite Gigante       - Diaria: R$ 80,00 - Capacidade: 12 Hospedes");
            
            break;
        
        case "2":
            opcao = string.Empty;

            while (exibirMenu)
            {
                Console.WriteLine("Escolha a Suite de sua nescessidade: ");
                Console.WriteLine("1 - Suite Pequena - Diaria: R$ 10,00 - Capacidade: 2 Hospedes");
                Console.WriteLine("2 - Suite Media   - Diaria: R$ 20,00 - Capacidade: 4 Hospedes");
                Console.WriteLine("3 - Suite Grande  - Diaria: R$ 40,00 - Capacidade: 8 Hospedes");
                Console.WriteLine("4 - Suite Gigante - Diaria: R$ 80,00 - Capacidade: 12 Hospedes");
                Console.WriteLine("5 - Sair..");
                
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        List<Pessoa> hospedesP = new List<Pessoa>();
                        Suite suiteP = new Suite("Pequena", 2, 10.00M);
                        string? nomeP = string.Empty;
                        string? sobrenomeP = string.Empty;
                        int diasReservadosP = 0;
                        Console.WriteLine("Digite a quantidade de dias que deseja reservar: ");
                        diasReservadosP = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < 2; i++)
                        {
                            Console.WriteLine($"Digite o primeiro Nome do Hospede (Capacidade {i+1} de 2): ");
                            nomeP = Console.ReadLine();
                            Console.WriteLine($"Digite o Sobrenome do {i+1}° Hospede (Capacidade {i+1} de 2): ");
                            sobrenomeP = Console.ReadLine();

                            if (i == 1)
                            {   
                                try
                                {
                                Pessoa hospede = new Pessoa(nomeP, sobrenomeP);
                                hospedesP.Add(hospede);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine($"Não foi possivel adicionar o Hospedi {e.Message}");
                                    i = -1;
                                }
                            } 
                            else
                            {
                                Console.WriteLine($"Deseja Adicionar mais Hospedes? (1 - Sim || 2 - Não)");
                                string? entrada = Console.ReadLine();
                                if (entrada == "2")
                                {
                                    i = 2;
                                }
                                try
                                {
                                    Pessoa hospede = new Pessoa(nomeP, sobrenomeP);
                                    hospedesP.Add(hospede);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine($"Exceção tratada {e.Message}");
                                }
                            }


                        }

                        Reserva reserva = new Reserva(hospedesP, suiteP, diasReservadosP);
                        Console.WriteLine($"Suite Reservada.");
                        Console.WriteLine($"Suite {suiteP.TipoSuite}, Diaria {suiteP.ValorDiaria:C}, Capacidade: {suiteP.Capacidade}.");
                        foreach (Pessoa p in hospedesP)
                        {
                            Console.WriteLine($"Hospede: {p.Nome} {p.Sobrenome}");
                        }
                        Console.WriteLine($"Valor Toral pagar: {reserva.CalcularValorDiaria():C}");

                    break;

                    case "2":
                        List<Pessoa> hospedesM = new List<Pessoa>();
                        Suite suiteM = new Suite("Media", 4, 20.00M);
                        string? nomeM = string.Empty;
                        string? sobrenomeM = string.Empty;
                        int diasReservadosM = 0;
                        Console.WriteLine("Digite a quantidade de dias que deseja reservar: ");
                        diasReservadosM = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine($"Digite o primeiro Nome do Hospede (Capacidade {i+1} de 4): ");
                            nomeM = Console.ReadLine();
                            Console.WriteLine($"Digite o Sobrenome do {i+1}° Hospede (Capacidade {i+1} de 4): ");
                            sobrenomeM = Console.ReadLine();

                            if (i == 3)
                            {   
                                try
                                {
                                Pessoa hospede = new Pessoa(nomeM, sobrenomeM);
                                hospedesM.Add(hospede);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine($"Não foi possivel adicionar o Hospedi {e.Message}");
                                    i = -1;
                                }
                            } 
                            else
                            {
                                Console.WriteLine($"Deseja Adicionar mais Hospedes? (1 - Sim || 2 - Não)");
                                string? entrada = Console.ReadLine();
                                if (entrada == "2")
                                {
                                    i = 4;
                                }
                                try
                                {
                                    Pessoa hospede = new Pessoa(nomeM, sobrenomeM);
                                    hospedesM.Add(hospede);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine($"Exceção tratada {e.Message}");
                                }
                            }


                        }

                        Reserva reservaM = new Reserva(hospedesM, suiteM, diasReservadosM);
                        Console.WriteLine($"Suite Reservada.");
                        Console.WriteLine($"Suite {suiteM.TipoSuite}, Diaria {suiteM.ValorDiaria:C}, Capacidade: {suiteM.Capacidade}.");
                        foreach (Pessoa p in hospedesM)
                        {
                            Console.WriteLine($"Hospede: {p.Nome} {p.Sobrenome}");
                        }
                        Console.WriteLine($"Valor Toral pagar: {reservaM.CalcularValorDiaria():C}");
                    break;
                    
                    case "3":
                        List<Pessoa> hospedesG = new List<Pessoa>();
                        Suite suiteG = new Suite("Grande", 8, 40.00M);
                        string? nomeG = string.Empty;
                        string? sobrenomeG = string.Empty;
                        int diasReservadosG = 0;
                        Console.WriteLine("Digite a quantidade de dias que deseja reservar: ");
                        diasReservadosM = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < 8; i++)
                        {
                            Console.WriteLine($"Digite o primeiro Nome do Hospede (Capacidade {i+1} de 8): ");
                            nomeM = Console.ReadLine();
                            Console.WriteLine($"Digite o Sobrenome do {i+1}° Hospede (Capacidade {i+1} de 8): ");
                            sobrenomeM = Console.ReadLine();

                            if (i == 7)
                            {   
                                try
                                {
                                Pessoa hospede = new Pessoa(nomeG, sobrenomeG);
                                hospedesG.Add(hospede);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine($"Não foi possivel adicionar o Hospedi {e.Message}");
                                    i = -1;
                                }
                            } 
                            else
                            {
                                Console.WriteLine($"Deseja Adicionar mais Hospedes? (1 - Sim || 2 - Não)");
                                string? entrada = Console.ReadLine();
                                if (entrada == "2")
                                {
                                    i = 8;
                                }
                                try
                                {
                                    Pessoa hospede = new Pessoa(nomeG, sobrenomeG);
                                    hospedesG.Add(hospede);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine($"Exceção tratada {e.Message}");
                                }
                            }


                        }

                        Reserva reservaG = new Reserva(hospedesG, suiteG, diasReservadosG);
                        Console.WriteLine($"Suite Reservada.");
                        Console.WriteLine($"Suite {suiteG.TipoSuite}, Diaria {suiteG.ValorDiaria:C}, Capacidade: {suiteG.Capacidade}.");
                        foreach (Pessoa p in hospedesG)
                        {
                            Console.WriteLine($"Hospede: {p.Nome} {p.Sobrenome}");
                        }
                        Console.WriteLine($"Valor Toral pagar: {reservaG.CalcularValorDiaria():C}");
                    break;

                    case "4":
                    List<Pessoa> hospedesGG = new List<Pessoa>();
                        Suite suiteGG = new Suite("Gigante", 12, 80.00M);
                        string? nomeGG = string.Empty;
                        string? sobrenomeGG = string.Empty;
                        int diasReservadosGG = 0;
                        Console.WriteLine("Digite a quantidade de dias que deseja reservar: ");
                        diasReservadosM = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < 12; i++)
                        {
                            Console.WriteLine($"Digite o primeiro Nome do Hospede (Capacidade {i+1} de 12): ");
                            nomeM = Console.ReadLine();
                            Console.WriteLine($"Digite o Sobrenome do {i+1}° Hospede (Capacidade {i+1} de 12): ");
                            sobrenomeM = Console.ReadLine();

                            if (i == 11)
                            {   
                                try
                                {
                                Pessoa hospede = new Pessoa(nomeGG, sobrenomeGG);
                                hospedesGG.Add(hospede);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine($"Não foi possivel adicionar o Hospedi {e.Message}");
                                    i = -1;
                                }
                            } 
                            else
                            {
                                Console.WriteLine($"Deseja Adicionar mais Hospedes? (1 - Sim || 2 - Não)");
                                string? entrada = Console.ReadLine();
                                if (entrada == "2")
                                {
                                    i = 12;
                                }
                                try
                                {
                                    Pessoa hospede = new Pessoa(nomeGG, sobrenomeGG);
                                    hospedesGG.Add(hospede);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine($"Exceção tratada {e.Message}");
                                }
                            }


                        }

                        Reserva reservaGG = new Reserva(hospedesGG, suiteGG, diasReservadosGG);
                        Console.WriteLine($"Suite Reservada.");
                        Console.WriteLine($"Suite {suiteGG.TipoSuite}, Diaria {suiteGG.ValorDiaria:C}, Capacidade: {suiteGG.Capacidade}.");
                        foreach (Pessoa p in hospedesGG)
                        {
                            Console.WriteLine($"Hospede: {p.Nome} {p.Sobrenome}");
                        }
                        Console.WriteLine($"Valor Toral pagar: {reservaGG.CalcularValorDiaria():C}");
                    break;

                    case "5":
                        exibirMenu = false;
                        Console.WriteLine("Programa Encerrado !!");
                    break;
                    
                    default:
                        Console.WriteLine("Opção Digitada Invalida, Reveja o Menu...");
                        break;
                }
            
            }
            break;
        
        case "3":
            exibirMenu = false;
            Console.WriteLine("Programa Encerrado !!");
            break;

        default:
            Console.WriteLine("Opção Digitada Invalida, Reveja o Menu...");
            break;
    }
}