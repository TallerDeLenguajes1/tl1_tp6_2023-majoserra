// See https://aka.ms/new-console-template for more information

/*Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el
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

/*Ejercicio 3. Ingrese al Branch CalculadoraV2 para implementar las mejoras en la
calculadora.. Solicite al usuario un número y muestre por pantalla:
● El valor absoluto de un número
● El cuadrado
● La raíz cuadrada
● El seno
● El Coseno
● La parte entera de un tipo float.
Luego de esto, solicite dos números al usuario y determine:
● El Máximo entre los dos números
● El Mínimo entre los dos números */

string? a, b, op, c;
bool andaNum1, andaNum2;
string? seguir = "1";
float result = 0, numC2;
int num1, num2, numC21, numC22;

Console.WriteLine("Menu:\nA-.Sumar\nB-.Restar\nC-.Dividir\nD-.Multiplicar\nE-.Calculadora 2");
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
                Console.WriteLine("La suma de" + num1 + "y de" + num2 + "es igul a" + result);
                break;
            case "B":
                result = num1 - num2;
                Console.WriteLine("La Resta de" + num1 + "y de" + num2 + "es igul a" + result);
                break;
            case "C":
                if (num2 == 0)
                {
                    Console.WriteLine("No se puede realizar esta operacion");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine("La Division de" + num1 + "y de" + num2 + "es igul a" + result);
                }
                break;
            case "D":
                result = num1 * num2;
                Console.WriteLine("La Multiplicacion de" + num1 + "y de" + num2 + "es igul a" + result);
                break;
            case "E":
                Console.WriteLine("Ingrese un numero:");
                c = Console.ReadLine();
                andaNum1 = float.TryParse(c, out numC2);
                if (andaNum1)
                {
                    Console.WriteLine("Valor absoluto:" + Math.Abs(numC2)); //todo devuelve valor absoluto
                    Console.WriteLine("Cuadrado:" + (numC2 * numC2));
                    Console.WriteLine("Raiz:" + (Math.Sqrt(numC2)));
                    double radianes = Math.PI * numC2 / 180; // Convertir a radianes
                    double coseno = Math.Cos(radianes);
                    Console.WriteLine("Coseno:" + coseno);
                    double seno = Math.Sin(radianes);
                    Console.WriteLine("Seno:" + seno);
                    int parteEntera = (int)numC2;
                    Console.WriteLine("Parte Entera:" + parteEntera);
                    Console.WriteLine("Ingrese un Numero:");
                    a = Console.ReadLine();
                    Console.WriteLine("Ingrese Otro Numero:");
                    b = Console.ReadLine();
                    andaNum1 = int.TryParse(a, out numC21);
                    andaNum2 = int.TryParse(b, out numC22);
                    if (andaNum1 && andaNum2)
                    {
                        if (numC21 == numC22)
                        {
                            Console.WriteLine("Los numeros son iguales");
                        }
                        else
                        {
                            if (numC21 > numC22)
                            {
                                Console.WriteLine("El Primer Numero es mayor");
                            }
                            else
                            {
                                Console.WriteLine("El Segundo Numero es mayor");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error al ingresar los numeros");
                    }


                }

                break;
        }
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

