string Usuario = "Jhostyn";
string contraseña = "contraseña1";


Console.Write("Ingrese el nombre de usuario: ");
string Usuarioing = Console.ReadLine();   


Console.Write("Ingrese la contraseña: ");
string Contraseñaing = Console.ReadLine();

// Validar las credenciales
if (Usuarioing == Usuario && Contraseñaing == contraseña)
{
    Console.WriteLine("Bienvenido");
}
else
{
    Console.WriteLine("Los datos proporcionados no son correctos... ");//se podría mejorar añiadiendo un ciclo para que se repita la acción hasta que se escriban los datos validos

}