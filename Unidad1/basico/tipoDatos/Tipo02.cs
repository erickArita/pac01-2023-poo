namespace basico.tipoDatos;

public class Tipo02
{
    public Tipo02()
    {
        Console.WriteLine("Ingrese su nombre");
        String nombre = (Console.ReadLine());
        Console.WriteLine($"Su nombre es: {nombre}");


        Console.WriteLine("Ingrese su Genero  F/M");
        bool sexo = Console.ReadLine() == "M";
        Console.WriteLine("Su genero es: " + (sexo ? "Masculino" : "Femenino"));

        Console.WriteLine("Ingrese su Edad");
        int edad = int.Parse(Console.ReadLine());
        Console.WriteLine($"Su edad es: {edad} ");
    }
}