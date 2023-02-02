namespace basico.estructuras_control;

public class Promedio
{
    /**
     * 1. Solicitar al usuario que ingrese 3 notas
     * < 70 = reprobado
     * >= 70 = aprobado
     * > 80 = nueno
     * > 90 = sobresaliente
     */
    public Promedio(decimal nota1, decimal nota2, decimal nota3)
    {
        decimal promedio = (nota1 + nota2 + nota3) / 3;

        if (promedio > 90)
        {
            Console.WriteLine("Sobresaliente");
        }

        if (promedio > 80)
        {
            Console.WriteLine("Bueno");
        }

        if (promedio >= 70)
        {
            Console.WriteLine("Aprobado");
        }

        if (promedio < 70)
        {
            Console.WriteLine("Reprobado");
        }


        Console.WriteLine("El promedio es " + Decimal.Round(promedio, 2));
        Console.WriteLine("------------------------------");
    }
}