Console.WriteLine("Ingrese el número correspondiente al tipo de servicio:");
Console.WriteLine("1. Lavado de auto");
Console.WriteLine("2. Cambio de aceite");
Console.WriteLine("3. Revisión mecánica");

int opcion;

while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 3)
{
    Console.WriteLine("Por favor, ingrese un número válido del 1 al 3.");
}

double importe;

switch (opcion)
{
    case 1:
        importe = 20.0;
        break;
    case 2:
        importe = 50.0;
        break;
    case 3:
        importe = 100.0;
        break;
    default:
        Console.WriteLine("Opción no válida.");
        return;
}

Console.WriteLine($"El importe a pagar es: ${importe}");