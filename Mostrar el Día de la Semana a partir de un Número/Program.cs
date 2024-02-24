Console.WriteLine("Ingrese un número del 1 al 7 para representar un día de la semana:");
int numdia;

while (!int.TryParse(Console.ReadLine(), out numdia) || numdia < 1 || numdia > 7)
{
    Console.WriteLine("Por favor, ingrese un número válido del 1 al 7.");
}

string dia;

switch (numdia)
{
    case 1:
        dia = "Lunes";
        break;
    case 2:
        dia = "Martes";
        break;
    case 3:
        dia = "Miércoles";
        break;
    case 4:
        dia = "Jueves";
        break;
    case 5:
        dia = "Viernes";
        break;
    case 6:
        dia = "Sábado";
        break;
    case 7:
        dia = "Domingo";
        break;
    default:
        Console.WriteLine("El número ingresado no representa ningún día de la semana.");
        return;
}

Console.WriteLine($"El día de la semana es: {dia}");