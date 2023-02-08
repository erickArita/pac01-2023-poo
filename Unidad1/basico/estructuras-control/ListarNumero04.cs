namespace basico.estructuras_control;

public class ListarNumero04
{
    public ListarNumero04()
    {
        bool continuar;
        do
        {
            Console.WriteLine("Hasta donde quiere contar: ");
            int hasta = int.Parse(Console.ReadLine());

            for (int i = 1; i <= hasta; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Quiere seguir contando? (S/N)");
            continuar = Console.ReadLine()?.ToUpper() == "S";
        } while (continuar);
    }
}