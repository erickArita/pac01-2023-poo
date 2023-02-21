namespace basico.estructuras_control;

public class Matriz03
{
    public Matriz03()
    {
        int[,] numeros = new int[3, 3];


        numeros[0, 0] = 1;
        numeros[0, 1] = 2;
        numeros[0, 2] = 3;
        numeros[1, 0] = 4;
        numeros[1, 1] = 5;
        numeros[1, 2] = 6;
        numeros[2, 0] = 7;
        numeros[2, 1] = 8;
        numeros[2, 2] = 9;


        for (int fila = 0; fila <= numeros.Rank; ++fila)
        {
            for (int col = 0; col <= numeros.Rank; ++col)
            {
                Console.Write(numeros[fila, col]);
                if (col < 2) Console.Write(" - ");
            }

            Console.WriteLine("");
        }
    }
}