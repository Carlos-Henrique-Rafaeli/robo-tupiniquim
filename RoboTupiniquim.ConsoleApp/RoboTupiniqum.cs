namespace RoboTupiniquim.ConsoleApp;

public class RoboTupiniquim
{
    int[] posicaoRobo;
    char orientacaoRobo;

    public void ProcessarSequencia(char[] sequencia)
    {
        foreach (char i in sequencia)
        {
            switch (i)
            {
                case 'M':
                    MoverRobo();
                    break;
                case 'D':
                    VirarRobo('D');
                    break;
                case 'E':
                    VirarRobo('E');
                    break;
            }
        }
    }

    public void MoverRobo()
    {
        int index = VerificarIndex();
        bool ehPositivo = VerificarOrientacao();

        if (ehPositivo)
            posicaoRobo[index] += 1;
        else
            posicaoRobo[index] -= 1;
    }

    public void VirarRobo(char qualLadoVirar)
    {
        if (qualLadoVirar == 'D' && orientacaoRobo == 'N')
            orientacaoRobo = 'L';
        else if (orientacaoRobo == 'L')
            orientacaoRobo = 'S';
        else if (orientacaoRobo == 'S')
            orientacaoRobo = 'O';
        else if (orientacaoRobo == 'O')
            orientacaoRobo = 'N';

        if (qualLadoVirar == 'E' && orientacaoRobo == 'N')
            orientacaoRobo = 'O';
        else if (orientacaoRobo == 'O')
            orientacaoRobo = 'S';
        else if (orientacaoRobo == 'S')
            orientacaoRobo = 'L';
        else if (orientacaoRobo == 'L')
            orientacaoRobo = 'N';
    }

    public int VerificarIndex()
    {
        if (orientacaoRobo == 'N' || orientacaoRobo == 'S')
            return 1;
        else if (orientacaoRobo == 'L' || orientacaoRobo == 'O')
            return 0;

        return -1;
    }

    public bool VerificarOrientacao()
    {
        if (orientacaoRobo == 'N' || orientacaoRobo == 'L')
            return true;
        else if (orientacaoRobo == 'L' || orientacaoRobo == 'S')
            return false;

        return false;
    }

}
