namespace RoboTupiniquim.ConsoleApp;

internal class Program
{
    static RoboTupiniquim robo1 = new RoboTupiniquim();
    static RoboTupiniquim robo2 = new RoboTupiniquim();

    static char[] sequenciaValidada = ['M', 'D', 'E'];

    static void Main(string[] args)
    {
        GerarCoordenadaMaxima(robo1);

        GerarCoordenadaRobo(robo1);

        if (robo1.ProcessarSequencia(GerarSequencia()))
            Console.WriteLine($"{robo1.posicaoRobo[0]} {robo1.posicaoRobo[1]} {robo1.orientacaoRobo}");
        else
            Console.WriteLine("A sequência é inválida!");

        Console.ReadLine();
    }
    static void GerarCoordenadaMaxima(RoboTupiniquim robo)
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

        int[] coordenadasMax = new int[partesCoordenadas.Length];

        for (int i = 0; i < partesCoordenadas.Length; i++)
            coordenadasMax[i] = int.Parse(partesCoordenadas[i]);

        robo.coordenadaMax = coordenadasMax;
    }

    static void GerarCoordenadaRobo(RoboTupiniquim robo)
    {
        string[] posicaoInicial;

        while (true)
        {
            Console.Write("Informe as coordenadas do robô e sua orientação: (Ex.: 1 3 N ou 3 4 S): ");
            posicaoInicial = Console.ReadLine()!.Split();

            if (posicaoInicial.Length != 3 || !int.TryParse(posicaoInicial[0], out _) || !int.TryParse(posicaoInicial[1], out _))
                Console.WriteLine("\nEntrada inválida!\n");
            else
                break;
        }

        robo.posicaoRobo = [int.Parse(posicaoInicial[0]), int.Parse(posicaoInicial[1])];
        robo.orientacaoRobo = char.Parse(posicaoInicial[2]);
    }

    static char[] GerarSequencia()
    {
        bool validacao = true;
        char[] sequenciaMovimento;

        do
        {
            Console.Write("Informe a sequencia de movimento do robô: (Ex.: MMDEMMDEDM): ");
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
        
        return sequenciaMovimento;
    }
}
