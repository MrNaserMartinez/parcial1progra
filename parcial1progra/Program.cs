
Console.WriteLine("BIENVENIDO AL SISTEMA NUMERO 1 PARA EL PARCIAL 1");
int opcion;

do
{
    Console.WriteLine("Menú:");
    Console.WriteLine("1. Calcular el factorial del número");
    Console.WriteLine("2. Calcular la raíz cuadrada de un número");
    Console.WriteLine("3. Salir");
    Console.Write("Elige una opción: ");

    string entrada = Console.ReadLine();

    if (!int.TryParse(entrada, out opcion))
    {
        Console.WriteLine("Opción no válida. Debes ingresar un número.");
        continue;
    }

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Listo para calcular el factorial.");
            Console.Write("Ingresa un número para calcular su factorial: ");
            int numero = int.Parse(Console.ReadLine());

            long factorial = CalcularFactorial(numero);
            Console.WriteLine($"El factorial de {numero} es: {factorial}");
            break;
        case 2:
            Console.WriteLine("Has elegido la Opción 2.");
            break;
        case 3:
            Console.WriteLine("Saliendo del programa...");
            return;
        default:
            Console.WriteLine("Opción no válida. Debes elegir una de las opciones disponibles.");
            break;
    }
} while (opcion != 3);

    static long CalcularFactorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            long resultado = 1;
            for (int i = 2; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
