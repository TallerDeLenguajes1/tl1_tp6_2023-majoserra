// See https://aka.ms/new-console-template for more information
/*
Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el
texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
número sólo si éste es mayor a 0.

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

/*Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego
pida dos números y que devuelva el resultado de la operación seleccionada. Además
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo.

string? a, b, op;
bool andaNum1, andaNum2;
string? seguir = "1";
float result = 0;
int num1, num2;
Console.WriteLine("Menu:\nA-.Sumar\nB-.Restar\nC-.Dividir\nD-.Multiplicar");
op = Console.ReadLine();
Console.WriteLine("Ingrese el Primer Num:");
a = Console.ReadLine();
Console.WriteLine("Ingrese el Segundo Num:");
b = Console.ReadLine();

andaNum1 = int.TryParse(a, out num1);
andaNum2 = int.TryParse(b, out num2);

if (andaNum1 && andaNum2)
{
    while (seguir != "0")
    {

        switch (op)
        {
            case "A":
                result = num1 + num2;
                break;
            case "B":
                result = num1 - num2;
                break;
            case "C":
                if (num2 == 0)
                {
                    Console.WriteLine("No se puede realizar esta operacion");
                    result = 0;
                }
                else
                {
                    result = num1 / num2;
                }
                break;
            case "D":
                result = num1 * num2;
                break;
        }
        Console.WriteLine("El Resultado es:" + result);
        Console.WriteLine("Desea Seguir Operando?");
        seguir = Console.ReadLine();
        if (seguir != "0")
        {
            Console.WriteLine("Menu:\nA-.Sumar\nB-.Restar\nC-.Dividir\nD-.Multiplicar");
            op = Console.ReadLine();
        }

    }
}
else
{
    Console.WriteLine("Error al ingresar los numeros");
}

*/
Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego
pida dos números y que devuelva el resultado de la operación seleccionada. Además
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo.

string? a, b, op;
bool andaNum1, andaNum2;
string? seguir = "1";
float result = 0;
int num1, num2;
Console.WriteLine("Menu:\nA-.Sumar\nB-.Restar\nC-.Dividir\nD-.Multiplicar");
op = Console.ReadLine();
Console.WriteLine("Ingrese el Primer Num:");
a = Console.ReadLine();
Console.WriteLine("Ingrese el Segundo Num:");
b = Console.ReadLine();

andaNum1 = int.TryParse(a, out num1);
andaNum2 = int.TryParse(b, out num2);

if (andaNum1 && andaNum2)
{
    while (seguir != "0")
    {

        switch (op)
        {
            case "A":
                result = num1 + num2;
                break;
            case "B":
                result = num1 - num2;
                break;
            case "C":
                if (num2 == 0)
                {
                    Console.WriteLine("No se puede realizar esta operacion");
                    result = 0;
                }
                else
                {
                    result = num1 / num2;
                }
                break;
            case "D":
                result = num1 * num2;
                break;
        }
        Console.WriteLine("El Resultado es:" + result);
        Console.WriteLine("Desea Seguir Operando?");
        seguir = Console.ReadLine();
        if (seguir != "0")
        {
            Console.WriteLine("Menu:\nA-.Sumar\nB-.Restar\nC-.Dividir\nD-.Multiplicar");
            op = Console.ReadLine();
        }

    }
}
else
{
    Console.WriteLine("Error al ingresar los numeros");
}

