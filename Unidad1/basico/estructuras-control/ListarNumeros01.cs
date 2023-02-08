namespace basico.estructuras_control;

public class ListarNumeros01
{
    public ListarNumeros01()
    {
        bool continuar = true;

        while (continuar)
        {
            int i = 1;
            Console.WriteLine("Listar número hasta: ");
            int hasta = int.Parse(Console.ReadLine());
            while (i <= hasta)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("Desea continuar S/N");
            continuar = Console.ReadLine().ToUpper() == "S";
            Console.Clear();
        }
    }
}