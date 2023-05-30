// See https://aka.ms/new-console-template for more information

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

