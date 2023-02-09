namespace basico.estructuras_control;

public class Arreglo01
{
    public Arreglo01()
    {
        Random random = new Random();
        int[] numeros = new int[5];

        for (int i = 0; i < 5; i++)
        {
            int rand = random.Next();
            numeros[i] = rand;
            Console.WriteLine(rand);
        }
    }
}