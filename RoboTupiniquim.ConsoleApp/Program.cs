namespace RoboTupiniquim.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe as coordenadas limites do projeto (Ex.: 5 5 ou 8 4): ");
        string[] partesCoordenadas = Console.ReadLine()!.Split();

        int[] coordenadasMin = [0, 0];
        int[] coordenadasMax = new int[partesCoordenadas.Length];

        for (int i = 0; i < partesCoordenadas.Length; i++)
            coordenadasMax[i] = int.Parse(partesCoordenadas[i]);

        Console.Write("Informe as coordenadas do robô e sua orientação: (Ex.: 1 3 N ou 3 4 S): ");
        string[] posicaoInicial = Console.ReadLine()!.Split();

        int[] posicaoRobo = [int.Parse(posicaoInicial[0]), int.Parse(posicaoInicial[1])];
        char orientacaoRobo = char.Parse(posicaoInicial[2]);

        Console.Write("Informe a sequencia de movimento do robô: (Ex.: 1 3 N ou 3 4 S): ");
        char[] sequenciaMovimento = Console.ReadLine()!.ToCharArray();


        foreach (char i in sequenciaMovimento)
        {
            if (orientacaoRobo == 'N' && i == 'M')
            {
                posicaoRobo[1] += 1;
                continue;
            }
            else if (i == 'D')
            {
                orientacaoRobo = 'L';
                continue;
            }
            else if (i == 'E')
            {
                orientacaoRobo = 'O';
                continue;
            }

            if (orientacaoRobo == 'S' && i == 'M')
            {
                posicaoRobo[1] -= 1;
                continue;
            }
            else if (i == 'D')
            {
                orientacaoRobo = 'O';
                continue;
            }
            else if (i == 'E')
            {
                orientacaoRobo = 'L';
                continue;
            }

            if (orientacaoRobo == 'L' && i == 'M')
            {
                posicaoRobo[0] += 1;
                continue;
            }
            else if (i == 'D')
            {
                orientacaoRobo = 'S';
                continue;
            }
            else if (i == 'E')
            {
                orientacaoRobo = 'N';
                continue;
            }

            if (orientacaoRobo == 'O' && i == 'M')
            {
                posicaoRobo[0] -= 1;
                continue;
            }
            else if (i == 'D')
            {
                orientacaoRobo = 'N';
                continue;
            }
            else if (i == 'E')
            {
                orientacaoRobo = 'S';
                continue;
            }
        }



        Console.WriteLine($"{posicaoRobo[0]} {posicaoRobo[1]} {orientacaoRobo}");

        Console.ReadLine();
    }
}
