namespace RoboTupiniquim.ConsoleApp;

public class RoboTupiniquim
{
    public int[] posicaoRobo = [0, 0];
    public char orientacaoRobo = 'N';
    public int[] coordenadaMax = [5, 5];
    public int[] coordenadaMin = [0, 0];

    public bool ProcessarSequencia(char[] sequencia)
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

        if (VerificarBorda())
            return true;
        else
            return false;
    }

    private bool VerificarBorda()
    {
        if (posicaoRobo[0] > coordenadaMax[0] || posicaoRobo[0] < coordenadaMin[0])
            return false;

        if (posicaoRobo[1] > coordenadaMax[1] || posicaoRobo[1] < coordenadaMin[1])
            return false;

        return true;
    }

    private void MoverRobo()
    {
        int index = VerificarIndex();
        int verificacao = VerificarOrientacao();

        if (verificacao == 1)
            posicaoRobo[index] += 1;
        else if (verificacao == 0)
            posicaoRobo[index] -= 1;
    }

    private void VirarRobo(char qualLadoVirar)
    {
        if (qualLadoVirar == 'D')
        {
            switch (orientacaoRobo)
            {
                case 'N':
                    orientacaoRobo = 'L';
                    break;
                
                case 'S':
                    orientacaoRobo = 'O';
                    break;
                
                case 'L':
                    orientacaoRobo = 'S';
                    break;
                
                case 'O':
                    orientacaoRobo = 'N';
                    break;
            }
        }
        else if (qualLadoVirar == 'E')
        {
            switch (orientacaoRobo)
            {
                case 'N':
                    orientacaoRobo = 'O';
                    break;

                case 'S':
                    orientacaoRobo = 'L';
                    break;

                case 'L':
                    orientacaoRobo = 'N';
                    break;

                case 'O':
                    orientacaoRobo = 'S';
                    break;
            }
        }
    }

    private int VerificarIndex()
    {
        if (orientacaoRobo == 'N' || orientacaoRobo == 'S')
            return 1;
        else if (orientacaoRobo == 'L' || orientacaoRobo == 'O')
            return 0;

        return -1;
    }

    private int VerificarOrientacao()
    {
        if (orientacaoRobo == 'N' || orientacaoRobo == 'L')
            return 1;
        else if (orientacaoRobo == 'L' || orientacaoRobo == 'S')
            return 0;

        return -1;
    }
}
