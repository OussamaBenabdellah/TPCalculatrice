using TPCalculatrice.Les_operation;

namespace TPCalculatrice
{
    public class Calculatrice
    {
        public IOperation Operation { get; }

        public Calculatrice(IOperation operation)
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
            Operation.Excuter();
        }
    }
}