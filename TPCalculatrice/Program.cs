
using System.Linq.Expressions;
using TPCalculatrice;



//char op;
Calculatrice calculatrice = new Calculatrice();

bool vrais = false;

while (!vrais)
{
    Console.WriteLine("introduit le premier numéro");

    string? saisir = Console.ReadLine();
    vrais = int.TryParse(saisir, out int g);
    calculatrice.OperandDroite = g;
    if (vrais)
    {
        break;
    }
    Console.WriteLine($" Svp veuillez réessayer  car la valeur saisie n’est pas acceptable  ");

}
bool x = false;
string? saisie;

while (!x)
{
    Console.WriteLine("introduit le deuxieme numéro ");

    saisie = Console.ReadLine();
    x = int.TryParse(saisie, out int y);
    calculatrice.OperandGauche = y;
    

    if(x)
    {
        break;
    }
    Console.WriteLine($" Svp veuillez réessayer  car la valeur saisie n’est pas acceptable  ");
}


bool isValidOperator = false;

while (!isValidOperator)
{
    string[] opérateur = ["*", "-", "/", "%", "+"];
    Console.WriteLine("introduit l'opération souhaiter  ");
    calculatrice.Operator = Console.ReadLine();

    foreach (var item in opérateur)
    {

        if (item == calculatrice.Operator)
        {
            isValidOperator = true;
            calculatrice.Operator = item;
            break;
        }
        else
        {
            isValidOperator = false;


        }
    }

    Console.WriteLine($" Svp veuillez réessayer  car la valeur saisie n’est pas acceptable  ");

}

switch (calculatrice.Operator)
{
    case "+":
        {
            calculatrice.Addition(calculatrice.OperandDroite, calculatrice.OperandGauche);

            break;
        }
    case "/":
        {
            calculatrice.Division(calculatrice.OperandDroite, calculatrice.OperandGauche); break;
        }
    case "*":
        {
            calculatrice.Multiplication(calculatrice.OperandDroite, calculatrice.OperandGauche); break;
        }
    case "-":
        {
            calculatrice.Soustraction(calculatrice.OperandDroite, calculatrice.OperandGauche); break;
        }
    case "%":
        calculatrice.Modulo(calculatrice.OperandDroite, calculatrice.OperandGauche); break;

    default:
        {
            break;
        }
}
Console.WriteLine(calculatrice.Resultas);









