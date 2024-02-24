Console.WriteLine("Elija una figura geométrica (triángulo, cuadrado o círculo):");
string figura = Console.ReadLine().ToLower();// tolower para poder convertir el texto en minuscula

double area = 0;

if (figura == "triángulo")
{
    Console.WriteLine("Ingrese la base del triángulo:");
    double baseTriangulo;
    while (!double.TryParse(Console.ReadLine(), out baseTriangulo))//usamos ! para verificar si la conversión fué exitosa
        Console.WriteLine("Por favor, ingrese un número válido.");

    Console.WriteLine("Ingrese la altura del triángulo:");
    double alturaTriangulo;
    while (!double.TryParse(Console.ReadLine(), out alturaTriangulo))
        Console.WriteLine("Por favor, ingrese un número válido.");

    area = 0.5 * baseTriangulo * alturaTriangulo;
}
else if (figura == "cuadrado")
{
    Console.WriteLine("Ingrese el lado del cuadrado:");
    double ladoCuadrado;
    while (!double.TryParse(Console.ReadLine(), out ladoCuadrado))
        Console.WriteLine("Por favor, ingrese un número válido.");

    area = ladoCuadrado * ladoCuadrado;
}
else if (figura == "círculo")
{
    Console.WriteLine("Ingrese el radio del círculo:");
    double radioCirculo;
    while (!double.TryParse(Console.ReadLine(), out radioCirculo))
        Console.WriteLine("Por favor, ingrese un número válido.");

    area = Math.PI * radioCirculo * radioCirculo;
}
else
{
    Console.WriteLine("Figura no reconocida.");
    return;
}

Console.WriteLine($"El área de la {figura} es: {area}");