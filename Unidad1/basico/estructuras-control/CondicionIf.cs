namespace basico.estructuras_control;

public class CondicionIf
{
    public CondicionIf()
    {
        Console.WriteLine("ingrese su edad");

        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("es mayor de edad");
        }
        else
        {
            Console.WriteLine("es menor de edad");
        }


        if (edad is >= 16 and <= 18) {
            Console.WriteLine("Puede participar en la selección");
        } else {
            Console.WriteLine("no puede participar en la selección");
        }
    }
}