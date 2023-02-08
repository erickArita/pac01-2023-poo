namespace basico.estructuras_control;

public class ListarNUmeros03
{
    public ListarNUmeros03()
    {
        bool continuar;
        do
        {
            int i = 1;
            Console.WriteLine("Hasta donde quiere contar: ");
            int hasta = int.Parse(Console.ReadLine());

            while (i <= hasta)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("Quiere seguir contando? (S/N)");
            continuar = Console.ReadLine().ToUpper() == "S";
        } while (continuar);
    }
}