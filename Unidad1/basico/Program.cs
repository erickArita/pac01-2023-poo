using basico.estructuras_control;


int contador = 3;
decimal[] notas = {0, 0, 0};

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Ingrese nota: " + (i + 1));
    notas[i] = decimal.Parse(Console.ReadLine());
}

Promedio promedio = new(notas[0], notas[1], notas[2]);