namespace RoboTupiniquim.ConsoleApp;

internal class Program
{
    static RoboTupiniquim roboTup1 = new RoboTupiniquim();
    static RoboTupiniquim roboTup2 = new RoboTupiniquim();

    static char[] sequenciaValidada = ['M', 'D', 'E'];

    static void Main(string[] args)
    {
        while (true)
        {
            ExibirMenu();
            LancarRobosEmMarte(roboTup1, roboTup2);

            if (JogarNovamente())
                break;
        }
    }

    static void LancarRobosEmMarte(RoboTupiniquim robo1, RoboTupiniquim robo2)
    {
        GerarCoordenadaMaxima(robo1, robo2);
        GerarCoordenadaRobo(robo1, "Primeiro");
        GerarCoordenadaRobo(robo2, "Segundo");

        char[] sequencia1 = GerarSequencia("Primeiro");
        char[] sequencia2 = GerarSequencia("Segundo");

        if (robo1.ProcessarSequencia(sequencia1))
            Console.WriteLine($"Posição final do primeiro Robô: {robo1.posicaoRobo[0]} {robo1.posicaoRobo[1]} {robo1.orientacaoRobo}");
        else
            Console.WriteLine("A sequência do primeiro Robô é inválida!");
        
        if (robo2.ProcessarSequencia(sequencia2))
            Console.WriteLine($"Posição final do segundo Robô: {robo2.posicaoRobo[0]} {robo2.posicaoRobo[1]} {robo2.orientacaoRobo}");
        else
            Console.WriteLine("A sequência do segundo Robô é inválida!");
    }

    static void GerarCoordenadaMaxima(RoboTupiniquim robo1, RoboTupiniquim robo2)
    {
        string[] partesCoordenadas;
        while (true)
        {
            Console.Write("Informe as coordenadas limites do projeto (Ex.: 5 5 ou 8 4): ");
            partesCoordenadas = Console.ReadLine()!.Split();

            if (partesCoordenadas.Length != 2 || !int.TryParse(partesCoordenadas[0], out _) || !int.TryParse(partesCoordenadas[1], out _))
                Console.WriteLine("\nEntrada Inválida!\n");
            else
                break;
        }
        Console.WriteLine();

        int[] coordenadasMax = new int[partesCoordenadas.Length];

        for (int i = 0; i < partesCoordenadas.Length; i++)
            coordenadasMax[i] = int.Parse(partesCoordenadas[i]);

        robo1.coordenadaMax = coordenadasMax;
        robo2.coordenadaMax = coordenadasMax;
    }

    static void GerarCoordenadaRobo(RoboTupiniquim robo, string nome)
    {
        string[] posicaoInicial;

        while (true)
        {
            Console.Write($"Informe as coordenadas do {nome} Robô e sua orientação: (Ex.: 1 3 N ou 3 4 S): ");
            posicaoInicial = Console.ReadLine()!.Split();

            if (posicaoInicial.Length != 3 || !int.TryParse(posicaoInicial[0], out _) || !int.TryParse(posicaoInicial[1], out _))
                Console.WriteLine("\nEntrada inválida!\n");
            else
                break;
        }
        Console.WriteLine();

        robo.posicaoRobo = [int.Parse(posicaoInicial[0]), int.Parse(posicaoInicial[1])];
        robo.orientacaoRobo = char.Parse(posicaoInicial[2]);
    }

    static char[] GerarSequencia(string nome)
    {
        bool validacao = true;
        char[] sequenciaMovimento;

        do
        {
            Console.Write($"Informe a sequencia de movimento do {nome} Robô: (Ex.: MMDEMMDEDM): ");
            sequenciaMovimento = Console.ReadLine()!.ToCharArray();

            foreach (char i in sequenciaMovimento)
            {
                if (!sequenciaValidada.Contains(i))
                {
                    Console.WriteLine("Sequência inválida!\nDigite ela novamente: ");
                    break;
                }
                else
                    validacao = false;
            }
        } while (validacao);
        Console.WriteLine();

        return sequenciaMovimento;
    }

    static void ExibirMenu()
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("          Robô Tupiniquim I           ");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine();
    }
    static bool JogarNovamente()
    {
        Console.WriteLine("\nDeseja jogar novamente? (S/N)");
        string validacao = Console.ReadLine()!.ToUpper();

        return validacao != "S";
    }
}
