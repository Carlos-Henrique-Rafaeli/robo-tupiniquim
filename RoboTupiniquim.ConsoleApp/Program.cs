namespace RoboTupiniquim.ConsoleApp;

internal class Program
{
    static RoboTupiniquim roboTup1 = new RoboTupiniquim();
    static RoboTupiniquim roboTup2 = new RoboTupiniquim();

    static char[] sequenciaValidada = ['M', 'D', 'E'];

    static void Main(string[] args)
    {
        roboTup1.nome = "Primeiro";
        roboTup2.nome = "Segundo";

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
        
        GerarCoordenadaRobo(robo1);
        char[] sequencia1 = GerarSequencia(robo1);
        
        GerarCoordenadaRobo(robo2);
        char[] sequencia2 = GerarSequencia(robo2);

        ExibirPosicaoRobo(robo1, sequencia1);
        ExibirPosicaoRobo(robo2, sequencia2);
    }

    static void GerarCoordenadaMaxima(RoboTupiniquim robo1, RoboTupiniquim robo2)
    {
        string[] partesCoordenadas;
        while (true)
        {
            Console.Write("Informe as coordenadas limites: (Ex.: 5 5): ");
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

    static void GerarCoordenadaRobo(RoboTupiniquim robo)
    {
        string[] posicaoInicial;

        while (true)
        {
            Console.Write($"Informe as coordenadas do {robo.nome} Robô e sua orientação: (Ex.: 1 3 N): ");
            posicaoInicial = Console.ReadLine()!.ToUpper().Split();

            if (posicaoInicial.Length != 3 || !int.TryParse(posicaoInicial[0], out _) || !int.TryParse(posicaoInicial[1], out _))
                Console.WriteLine("\nEntrada inválida!\n");
            else
                break;
        }
        Console.WriteLine();

        robo.posicaoRobo = [int.Parse(posicaoInicial[0]), int.Parse(posicaoInicial[1])];
        robo.orientacaoRobo = char.Parse(posicaoInicial[2]);
    }

    static char[] GerarSequencia(RoboTupiniquim robo)
    {
        bool validacao = true;
        char[] sequenciaMovimento;

        do
        {
            Console.Write($"Informe a sequência de movimento do {robo.nome} Robô: (Ex.: MMDMMEMDE): ");
            sequenciaMovimento = Console.ReadLine()!.ToUpper().ToCharArray();

            foreach (char i in sequenciaMovimento)
            {
                if (!sequenciaValidada.Contains(i))
                {
                    Console.WriteLine("\nEntrada inválida!\n");
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
        Console.Clear();
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("          Robô Tupiniquim I           ");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine();
    }

    static void ExibirPosicaoRobo(RoboTupiniquim robo, char[] sequencia)
    {
        if (robo.ProcessarSequencia(sequencia))
            Console.WriteLine($"Posição final do {robo.nome} Robô: {robo.posicaoRobo[0]} {robo.posicaoRobo[1]} {robo.orientacaoRobo}");
        else
            Console.WriteLine($"A sequência do {robo.nome} Robô é inválida!");
    }

    static bool JogarNovamente()
    {
        Console.WriteLine("\nDeseja jogar novamente? (S/N)");
        string validacao = Console.ReadLine()!.ToUpper();

        return validacao != "S";
    }
}
