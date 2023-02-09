namespace basico.estructuras_control;

public class ListarNumeros05
{
    public ListarNumeros05()
    {
        int[] numerosGenerados = new int[10];


        Random random = new Random();
        for (int j = 0; j < 10; j++)
        {
            bool yaExiste;
            int numeroGenerado = random.Next(1, 10);
            numerosGenerados[j] = numeroGenerado;

            // do
            // {
            //     numeroGenerado = random.Next(1, 10);
            //     for()
            // } while (yaExiste);

            numerosGenerados[j] = numeroGenerado;
        }

        foreach (var numerosGenerado in numerosGenerados)
        {
            Console.Write(numerosGenerado);
            Console.Write(" - ");
        }
    }
}