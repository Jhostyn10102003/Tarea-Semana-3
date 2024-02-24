Console.WriteLine("Ingrese el primer número:");
if (int.TryParse(Console.ReadLine(), out int numero1))
{
    Console.WriteLine("Ingrese el segundo número:");
    if (int.TryParse(Console.ReadLine(), out int numero2))
    {
        Console.WriteLine("Ingrese el tercer número:");
        if (int.TryParse(Console.ReadLine(), out int numero3))
        {
            // Encontrar el mayor de los tres números
            int mayor = numero1;

            if (numero2 > mayor)
            {
                mayor = numero2;
            }

            if (numero3 > mayor)
            {
                mayor = numero3;
            }

            // Mostrar el resultado
            Console.WriteLine($"El mayor de los tres números es: {mayor}");
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un tercer número válido (número entero).");
        }
    }
    else
    {
        Console.WriteLine("Por favor, ingrese un segundo número válido (número entero).");
    }
}
else
{
    Console.WriteLine("Por favor, ingrese un primer número válido (número entero).");
}