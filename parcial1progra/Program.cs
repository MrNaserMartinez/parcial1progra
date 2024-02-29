using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System;

//METODOS EJERCICIOS:
//1.Length: Obtener la longitud de una cadena.

string cadena = "Hola Mundo";
int longitud = cadena.Length; // longitud será 10

//2.ToUpper(): Convertir a mayúsculas.

string minusculas = "hola mundo";
string mayusculas = minusculas.ToUpper(); // mayusculas será "HOLA MUNDO"

//3.ToLower(): Convertir a minúsculas.

string mayusculas1 = "HOLA MUNDO";
string minusculas1 = mayusculas1.ToLower(); // minusculas será "hola mundo"


//4.IndexOf(): Buscar la primera ocurrencia de un caracter o cadena.

string frase = "La casa es grande";
int indice = frase.IndexOf("casa"); // indice será 3


//5.LastIndexOf(): Buscar la última ocurrencia de un caracter o cadena.

string frase1 = "La casa es grande y la casa es bonita";
int ultimoIndice = frase.LastIndexOf("casa"); // ultimoIndice será 26


//6.Substring(): Extraer una subcadena.

string frase2 = "La casa es grande";
string subcadena = frase.Substring(3, 4); // subcadena será "casa"


//7.Replace(): Reemplazar una subcadena por otra.

string frase3 = "La casa es grande";
string nuevaFrase = frase.Replace("grande", "pequeña"); // nuevaFrase será "La casa es pequeña"


//8.Trim(): Eliminar espacios en blanco al inicio y final.

string cadenaConEspacios = "   Hola Mundo   ";
string cadenaSinEspacios = cadenaConEspacios.Trim(); // cadenaSinEspacios será "Hola Mundo"


//9.StartsWith(): Indicar si una cadena comienza con otra.

string frase4 = "Hola Mundo";
bool empiezaConHola = frase.StartsWith("Hola"); // empiezaConHola será true


//10.EndsWith(): Indicar si una cadena termina con otra.

string frase5 = "Hola Mundo";
bool terminaConMundo = frase.EndsWith("Mundo"); // terminaConMundo será true


//11.Contains(): Determina si una cadena contiene una subcadena especificada.

string frase6 = "La casa es grande";
bool contieneCasa = frase.Contains("casa"); // contieneCasa será true


//12.Split(): Divide una cadena en subcadenas en función de un delimitador especificado y devuelve un arreglo de cadenas.

string frase7 = "Hola,Mundo,Cómo,Estás";
string[] palabras = frase.Split(','); // palabras será ["Hola", "Mundo", "Cómo", "Estás"]


//13.ToCharArray(): Convierte la cadena en un arreglo de caracteres.

string palabra = "Hola";
char[] caracteres = palabra.ToCharArray(); // caracteres será ['H', 'o', 'l', 'a']


//14.PadLeft() y PadRight(): Añaden caracteres de relleno al inicio o al final de la cadena hasta que tenga una longitud especificada.


string palabra1 = "Hola";
string palabraRellena = palabra.PadLeft(10, '-'); // palabraRellena será "------Hola"

//15.Substring() con parámetro de inicio y longitud: Permite extraer una subcadena especificando la posición inicial y la longitud deseada.

string palabra2 = "Hola";
string palabraRellena2 = palabra2.PadLeft(10, '-'); // palabraRellena será "------Hola"



//_______________________________________________________________________________________________________________


//PROPIEDADES:

//1.Length: Longitud de la cadena.

string cadena1 = "Hola Mundo";
int longitud1 = cadena1.Length; // longitud será 10


//3.Chars: Obtiene un array de caracteres que componen la cadena.

string cadena2 = "Hola";
char[] caracteres2 = cadena2.ToCharArray(); // caracteres contendrá ['H', 'o', 'l', 'a']


//4.IsNullOrEmpty: Indica si la cadena es nula o una cadena vacía.

string cadena11 = null;
string cadena22 = "";
bool esNullOrEmpty1 = String.IsNullOrEmpty(cadena11); // true
bool esNullOrEmpty2 = String.IsNullOrEmpty(cadena22); // true



//5.IsEmpty: Indica si la cadena es una cadena vacía.

string cadena4 = "";
bool esEmpty = cadena.IsEmpty; // true (No existe una propiedad IsEmpty en C#)

//6.IsNullOrWhiteSpace: Indica si la cadena es nula, una cadena vacía o contiene solo espacios en blanco.

string cadena7 = null;
string cadena7 = "";
string cadena7 = "   ";
bool esNullOrWhiteSpace1 = String.IsNullOrWhiteSpace(cadena1); // true
bool esNullOrWhiteSpace2 = String.IsNullOrWhiteSpace(cadena2); // true
bool esNullOrWhiteSpace3 = String.IsNullOrWhiteSpace(cadena3); // true


//7.Chars[int index]: Permite acceder a un carácter específico dentro de la cadena utilizando un índice entero.

string cadena = "Hola";
char primerCaracter = cadena[0]; // 'H'

//_________________________________________________________________________________

//Operaciones con cadenas

//1.Comparación de cadenas
//operador ==

string cadena1 = "Hola";
string cadena2 = "Hola";

if (cadena1 == cadena2)
{
    Console.WriteLine("Las cadenas son iguales.");
}
else
{
    Console.WriteLine("Las cadenas son diferentes.");
}

//Equals

string cadena1 = "Hola";
string cadena2 = "hola";

if (cadena1.Equals(cadena2, StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Las cadenas son iguales (ignorando mayúsculas y minúsculas).");
}
else
{
    Console.WriteLine("Las cadenas son diferentes.");
}


//2.Concatenación de cadenas

//	Operador +:
string cadena1 = "Hola";
string cadena2 = "Mundo";
string resultado = cadena1 + " " + cadena2;
//	Método String.Concat(): El método Concat() de la clase String se utiliza para concatenar múltiples cadenas.
string cadena1 = "Hola";
string cadena2 = "Mundo";
string resultado = String.Concat(cadena1, " ", cadena2); // resultado contendrá "Hola Mundo"
//	Método String.Join(): El método Join() de la clase String se utiliza para concatenar una matriz o colección de cadenas, colocando un separador opcional entre cada una de ellas.
string[] partes = { "Hola", "Mundo" };
string resultado = String.Join(" ", partes); // resultado contendrá "Hola Mundo"
//	Interpolación de Cadenas: Puedes utilizar la interpolación de cadenas, que es una característica introducida en C# 6.0, para concatenar cadenas y valores dentro de una cadena utilizando el símbolo $. Por ejemplo:
string cadena9 = "Hola";
string cadena99 = "Mundo";
string resultado9 = $"{cadena9} {cadena99}"; // resultado contendrá "Hola Mundo"


//3.Busqueda de patrones

//1.	Método IndexOf(): El método IndexOf() te permite buscar la primera ocurrencia de un carácter o subcadena dentro de una cadena y devuelve su posición. Puedes usar este método para buscar un patrón específico.

string frase9 = "La casa es grande";
int indice9 = frase9.IndexOf("casa"); // Devuelve el índice de la primera ocurrencia de "casa" (3 en este caso)

if (indice != -1)
{
    Console.WriteLine($"La subcadena 'casa' se encuentra en el índice {indice}.");
}
else
{
    Console.WriteLine("La subcadena 'casa' no se encuentra en la frase.");
}


//2.Método Contains(): El método Contains() te permite verificar si una cadena contiene una subcadena específica.

string frase8 = "La casa es grande";
int indice8 = frase8.IndexOf("casa"); // Devuelve el índice de la primera ocurrencia de "casa" (3 en este caso)

if (indice != -1)
{
    Console.WriteLine($"La subcadena 'casa' se encuentra en el índice {indice}.");
}
else
{
    Console.WriteLine("La subcadena 'casa' no se encuentra en la frase.");
}


//4.Formateo de cadenas

//1.	Interpolación de Cadenas: Es una característica introducida en C# 6.0 que te permite insertar valores de variables o expresiones directamente dentro de una cadena precedida por el símbolo $. Esto simplifica la creación de cadenas formateadas.

string nombre = "Juan";
int edad = 30;
string mensaje = $"Hola, mi nombre es {nombre} y tengo {edad} años.";
Console.WriteLine(mensaje);



//2.Método ToString() con formato: Puedes utilizar el método ToString() de los tipos numéricos y otros tipos de datos para formatearlos como cadenas con un formato específico. Esto es útil para controlar la precisión, el número de decimales, el formato de fecha y hora, etc.

double precio = 19.99;
string precioFormateado = precio.ToString("C"); // Formatear como moneda
Console.WriteLine($"El precio es: {precioFormateado}");

DateTime fecha = DateTime.Now;
string fechaFormateada = fecha.ToString("yyyy-MM-dd HH:mm:ss"); // Formatear como fecha y hora
Console.WriteLine($"La fecha actual es: {fechaFormateada}");


