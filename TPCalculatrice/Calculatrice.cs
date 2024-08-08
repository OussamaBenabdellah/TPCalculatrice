using TPCalculatrice.Les_operation;

namespace TPCalculatrice
{
    public class Calculatrice
    {
        public Operation Operation { get; }

        public Calculatrice(Operation operation)
        {
            Operation = operation;
        }
        /// <summary>
        /// avec cette methode on est entrain d'utiliser le Patern-Matching 
        /// afin de confirmer de quel type(addition,division..) est l'Operation  
        /// 
        /// </summary>
        public void Excuter()
        {
            if (Operation is Addition addition)
            {
                addition.Excuter();
            }
            else if (Operation is Soustraction soustraction) 
            {
                soustraction.Excuter();
            }
            else if (Operation is Multiplication multiplication)
            {
                multiplication.Excuter();
            }
            else if (Operation is Division division)
            {
                division.Excuter();
            }
            else if (Operation is Modulo modulo)
            {
                modulo.Excuter();
            }
            else
            {
                Console.WriteLine("Opération noin reconus");
            }

        }



            return Resultas = 0;
            

       
      

        
    }
}