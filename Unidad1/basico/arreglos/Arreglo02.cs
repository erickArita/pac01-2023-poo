namespace basico.estructuras_control;

public class Arreglo02
{
    public Arreglo02()
    {
        bool seguirCreandoNumeros;
        Random random = new Random();
        do
        {
            Console.WriteLine("Ingrese el tamaño del arreglo");
            int size = int.Parse(Console.ReadLine());
            int[] numeros = new int[size];

            for (int i = 1; i < numeros.Length; i++)
            {
                int rand = random.Next(1, 10);
                while (numeros.Contains(rand))
                {
                    rand = random.Next(0, 10);
                }

                numeros[i] = rand;
                Console.WriteLine($" {i} : {rand}");
            }

            Console.WriteLine("Desea seguir generand números  S/N");
            seguirCreandoNumeros = Console.ReadLine().ToLower() == "s";
        } while (seguirCreandoNumeros);
    }
}