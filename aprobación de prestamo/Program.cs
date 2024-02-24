Console.Write("Ingrese la cantidad a prestar: ");
if (decimal.TryParse(Console.ReadLine(), out decimal Mprestamo))//1er if
{
    Console.Write("Ingrese su edad: ");
    if (int.TryParse(Console.ReadLine(), out int edad)) //usamos || para combinar las condiciones de ambos iff
    {
        if (Mprestamo < 5000 || edad > 60)//2do if
        {
            Console.WriteLine("¡Préstamo aprobado!");
        }
        else
        {
            Console.WriteLine("Préstamo rechazado.");
        }
    }
    else
    {
        Console.WriteLine("Por favor, ingrese una edad válida (número entero).");
    }
}
else
{
    Console.WriteLine("Por favor, ingrese un monto válido (número decimal).");
}