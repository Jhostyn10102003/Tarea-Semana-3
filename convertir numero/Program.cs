Console.WriteLine("Ingrese un número del 1 al 5 en letra:");
string numeroText = Console.ReadLine().ToLower(); // Convierte la entrada a minúsculas para ser insensible a mayúsculas.

int num;

switch (numeroText)
{
    case "uno":
        num = 1;
        break;
    case "dos":
        num = 2;
        break;
    case "tres":
        num = 3;
        break;
    case "cuatro":
        num = 4;
        break;
    case "cinco":
        num = 5;
        break;
    default:
        Console.WriteLine("Número en letra no es valido.");
        return;
}

Console.WriteLine($"El número en dígito es: {num}");
