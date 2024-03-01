
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("BIENVENIDO AL SISTEMA NUMERO 1 PARA EL PARCIAL 1\n\n");
Console.WriteLine("EJERCICIO #3 PARA EL PARCIAL 1\n");

Console.WriteLine("TU TABLA DE MULTIPLICAR");
Console.WriteLine("para esto solo debes de colocar el numero que deseas");
Console.WriteLine("Ingresa el numero que deseas ver en tabla de 10");
int n = Convert.ToInt32(Console.ReadLine());


for (int i = 1; i <= 10; i++)
{
    int resultado = n * i;
    Console.WriteLine($"{n} x {i} = {resultado}");
}