
Console.WriteLine("BIENVENIDO AL SISTEMA NUMERO 1 PARA EL PARCIAL 1\n\n");
Console.WriteLine("EJERCICIO #2 PARA EL PARCIAL 1\n");

Console.WriteLine("CALCULAR EL RESULTADO\n");
Console.WriteLine("Ingrese el primer numero entero");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero entero");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa el operador matemático (+, -, *, /)");
Console.WriteLine("Recuerda usar solamente los signos mostrados:");
string operador = Console.ReadLine();

double r = 0;
switch (operador)
{
    case "+":
        r = n1 + n2;
        break;
    case "-":
        r = n1 - n2;
        break;
    case "*":
        r = n1 * n2;
        break;
    case "/":
        if (n2 == 0)
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
            return;
        }
        r = (double)n1 / n2;
        break;
    default:
        Console.WriteLine("Error: Operador no válido. Debes ingresar uno de los operadores mostrados.");
        return;
}
Console.WriteLine($"El resultado de tu operación es: {r}");