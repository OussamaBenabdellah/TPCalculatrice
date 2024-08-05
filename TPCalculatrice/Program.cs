
using TPCalculatrice;


int v;
int w;
while (true)
{
    Console.WriteLine("introduit le premier numéro");
    string a = Console.ReadLine();

    try 
    {
         v = int.Parse(a);
        
       break;
    }
    catch
    {
        Console.WriteLine(" Svp veuillez réessayer  car la valeur saisie n’est pas acceptable ");
    }
}
while (true)
{
    Console.WriteLine("introduit le deuxieme numéro ");
    string b = Console.ReadLine();

    try
    {
        w = int.Parse(b);

        break;
    }
    catch
    {
        Console.WriteLine(" Svp veuillez réessayer  car la valeur saisie n’est pas acceptable ");
    }
}

  



Calculatrice calculatrice = new Calculatrice();



Console.WriteLine(calculatrice.Addition(v,w));
Console.WriteLine(calculatrice.Soustraction(v,w));
Console.WriteLine(calculatrice.Division(v,w));
Console.WriteLine(calculatrice.Multiplication(v,w));
Console.WriteLine(calculatrice.Modulo(v,w));
