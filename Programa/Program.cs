Console.WriteLine("Bienvenido:");

Console.WriteLine("Ingresa tu edad: ");
if (int.TryParse(Console.ReadLine(), out int edad))//comprueba si el valor ingresado es entero
{
    if (edad >= 18)//si es mayor de edad 
    {
        Console.WriteLine("Bienvenido, eres mayor de edad, adelante.");
    }
    else//si no es mayor de dad
    {
        Console.WriteLine("No eres mayor de edad, no puedes pasar.");
    }
}
else
{
    Console.WriteLine("Ingresa un numero valido por favor.");
}
