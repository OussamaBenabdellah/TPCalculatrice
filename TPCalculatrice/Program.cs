using TPCalculatrice;
using TPCalculatrice.Les_operation;

//char operations;

bool vrais = false;
int o1 = 0;
while (!vrais)
{
    Console.WriteLine("introduit le premier numéro");

    string? saisir = Console.ReadLine();
    vrais = int.TryParse(saisir, out int g);
    o1 = g;
    if (vrais == true)
    {
        break;
    }
    Console.WriteLine($" Svp veuillez réessayer  car la valeur saisie n’est pas acceptable  ");
}
bool x = false;
string? saisie;
int o2 = 0;
while (!x)
{
    Console.WriteLine("introduit le deuxieme numéro ");

    saisie = Console.ReadLine();
    x = int.TryParse(saisie, out int y);

    o2 = y;

    if (x == true)
    {
        break;
    }
    else
    {
        Console.WriteLine($" Svp veuillez réessayer  car la valeur saisie n’est pas acceptable  ");
    }
}

bool isValidOperator = false;
string? opérateur = "";
while (!isValidOperator)
{
    string[] opérateurs = ["+", "*", "-", "/", "%"];
    Console.WriteLine("introduit l'opération souhaiter  ");
    opérateur = Console.ReadLine();

    foreach (var item in opérateurs)
    {
        if (item == opérateur)
        {
            isValidOperator = true;
            opérateur = item;
            break;
        }
        else
        {
            isValidOperator = false;
        }
    }
    if (!isValidOperator)
    {
        Console.WriteLine($" Svp veuillez réessayer  car la valeur saisie n’est pas acceptable  ");
    }
}

IOperation operations;
///
/// dans ce swith on est entrain d'utiliser le polymorphisme afin d'instancier chaque class (addition, Division ...)
///
switch (opérateur)
{
    case "+":
        {
            operations = new Addition(o1, o2);
            break;
        }
    case "/":
        {
            operations = new Division(o1, o2); break;
        }
    case "*":
        {
            operations = new Multiplication(o1, o2); break;
        }
    case "-":
        {
            operations = new Soustraction(o1, o2); break;
        }
    case "%":
        operations = new Modulo(o1, o2); break;

    default:
        {
            return;
        }
}
 
Calculatrice calculatrice = new(operations);

calculatrice.Excuter();

Console.WriteLine(operations.Resultas);