namespace basico.estructuras_control;

public class Vocales
{
    public Vocales()
    {
        Console.WriteLine("Nombres según la vocal");
        Console.WriteLine("--------------------------\n");
        Console.WriteLine("Ingrese una vocal: ");

        char? vocal = Console.ReadLine()?[0];

        switch (vocal)
        {
            case 'A':
                Console.Write("Angie, Ana");
                break;
            case 'E':
                Console.Write("Erick, Ester");
                break;
            case 'I':
                Console.Write("Iván, I");
                break;
            case 'O':
                Console.Write("Oscar, Orlando");
                break;
            case 'U':
                Console.Write("Uriel, El burro eres tú");
                break;
            default:
                Console.WriteLine("No se ingresó una vocal");
                break;
        }
    }
}