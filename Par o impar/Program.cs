Console.Write("Ingrese un número: ");

if (int.TryParse(Console.ReadLine(), out int numero))//siempre para evitar que el usuario ingrese un valor no valido
{
    if (numero % 2 == 0)//mod para poder extraer el residuo de la division y ver si es igual a 0
    {
        Console.WriteLine($"El número {numero} es par.");
    }
    else
    {
        Console.WriteLine($"El número {numero} es impar.");
    }
}
else
{
    Console.WriteLine("Por favor, ingrese un número válido (número entero).");
}