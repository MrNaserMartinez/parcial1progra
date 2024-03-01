
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("BIENVENIDO AL SISTEMA NUMERO 1 PARA EL PARCIAL 1\n\n");
Console.WriteLine("EJERCICIO #4 PARA EL PARCIAL 1\n");


Console.WriteLine("ADIVINA EL NUMERO SECRETO ENTRE 1 Y 100\n");
Console.WriteLine("Bienvenido al juego de adivinar el número secreto!");
Console.WriteLine("El número secreto está entre 1 y 100.");

int elegido = 33; 

int intentos = 0;
int noelegido;

do
{
    Console.Write("Introduce tu intento: ");
    if (!int.TryParse(Console.ReadLine(), out noelegido))
    {
        Console.WriteLine("Error: Debes ingresar un número entero.");
        continue;
    }
    intentos++;

    if (noelegido < elegido)
    {
        Console.WriteLine("El número secreto es mayor.");
    }
    else if (noelegido > elegido)
    {
        Console.WriteLine("El número secreto es menor.");
    }
    else
    {
        Console.WriteLine($"ESOOOOOO {elegido} COMO EL GRAN FERNANDO ALONSO");
        Console.WriteLine($"Solo te hiciste {intentos} intentos. XD");
    }

} while (noelegido != elegido);
