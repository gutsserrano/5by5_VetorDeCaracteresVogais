/* Faça um vetor de caracteres de 10 posições e imprima os seguintes itens:
		a) somente as vogais
		b) somente as consoantes
 */

char[] letras = new char[10];
char[] vogais = new char[10];
char[] cons = new char[10];

int contVog = 0, contCons = 0;

int option = 0;

do
{
    Console.WriteLine("Digite 10 caracteres:");
    for (int i = 0; i < 10; i++)
    {
        letras[i] = char.Parse(Console.ReadLine());
    }

    for (int i = 0; i < 10; i++)
    {
        if (letras[i] == 'a' || letras[i] == 'e' || letras[i] == 'i' || letras[i] == 'o' || letras[i] == 'u')
        {
            vogais[contVog] = letras[i];
            contVog++;
        }
        else
        {
            cons[contCons] = letras[i];
            contCons++;
        }
    }

    Console.WriteLine("\nVogais");
    for (int i = 0; i < contVog; i++)
    {
        Console.Write(vogais[i] + " ");
    }

    Console.WriteLine("\nConsoantes");
    for (int i = 0; i < contCons; i++)
    {
        Console.Write(cons[i] + " ");
    }

    do
    {
        Console.WriteLine("\n\nDeseja sair do programa?");
        Console.WriteLine("1 - Sair");
        Console.WriteLine("2 - Continuar");
        option = int.Parse(Console.ReadLine());
    } while (option < 1 || option > 2);
} while (option == 2);
