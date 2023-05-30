// See https://aka.ms/new-console-template for more information

/*Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el
texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
número sólo si éste es mayor a 0.*/
/*
string? numS;
string numI = "";
bool anda;
int num, digito;
Console.WriteLine("Ingrese el numero:");
numS = Console.ReadLine();

anda = int.TryParse(numS, out num);

if (anda)
{
    if (num > 0)
    {
        while (num != 0)
        {
            digito = num % 10;
            num = num / 10;
            numI = numI + digito.ToString();
        }
    }
}
Console.WriteLine("El numero es:" + numI);

*/
//! Ejercicio 4
string? cad, cad2;
Console.WriteLine("Ingrese una Cadena de Texto");
cad = Console.ReadLine();
//Obtener la longitud de la cadena y muestre por pantalla.
Console.WriteLine("Longitud:" + cad.Length); //Longitud de cadena
//A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas distintas.
Console.WriteLine("Ingrese una Segunda Cadena de Texto");
cad2 = Console.ReadLine();

Console.WriteLine("Cadenas Concatenadas: " + cad + cad2);
//? Extraer una subcadena de la cadena ingresada.

//Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento porelemento en pantalla
Console.WriteLine("Recorriendo la cadena de texto con Foreach:");
foreach (char caracter in cad)
{
    Console.WriteLine(caracter);
}
//Buscar la ocurrencia de una palabra determinada en la cadena ingresada
Console.WriteLine("Ingrese una palabra para buscar en la cadena:");
string? palabraBuscada = Console.ReadLine();
bool contienePalabra = cad.Contains(palabraBuscada);
Console.WriteLine("La cadena contiene la palabra buscada: " + contienePalabra);
// Convertir la cadena a mayúsculas y luego a minúsculas
string mayusculas = cad.ToUpper();
string minusculas = cad.ToLower();
Console.WriteLine("Cadena en mayúsculas: " + mayusculas);
Console.WriteLine("Cadena en minúsculas: " + minusculas);
// Separar la cadena por caracteres determinados
char separador = ' ';
string[] partes = cad.Split(separador); //Divide a la cadena cuando aparece un espacio en blanco

foreach (string parte in partes)
{
    Console.WriteLine(parte);
}
/*Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación
simple como cadena de caracteres y que el sistema lo resuelva. Por ej. ingrese
por pantalla “582+2” y que le devuelva la suma de 582 con 2*/
char[] operadores = { '+', '-', '*', '/' };
string? ecu;
Console.WriteLine("Ingrese Una Ecuacion");
ecu = Console.ReadLine();
string[] componentes = ecu.Split(operadores); //Divide a la cadena cuando aparece un espacio en blanco
bool anda1, anda2;
int num1, num2;
anda1 = int.TryParse(componentes[0], out num1);
anda2 = int.TryParse(componentes[1], out num2);
if (anda1 && anda2)
{
    if (ecu.Contains("+"))
    {
        Console.WriteLine("suma:" + (num1 + num2));
    }
    else
    {
        if (ecu.Contains("-"))
        {
            Console.WriteLine("resta:" + (num1 - num2));
        }
        else
        {
            if (ecu.Contains("/"))
            {
                Console.WriteLine("Division:" + (num1 / num2));
            }
            else
            {
                if (ecu.Contains("*"))
                {
                    Console.WriteLine("Multiplicacion:" + (num1 * num2));
                }
                else
                {
                    Console.Write("operacion incorrecta");
                }
            }
        }
    }
}