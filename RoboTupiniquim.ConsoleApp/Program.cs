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

        foreach (int i in coordenadasMax)
            Console.WriteLine(i);

        Console.ReadLine();
    }
}
