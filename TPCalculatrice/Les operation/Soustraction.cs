namespace TPCalculatrice.Les_operation
{
    public class Soustraction : Operation
    {
        public Soustraction(int operandeGauche, int operandeDroite) : base(operandeGauche, operandeDroite)
        {
        }
        public void Excuter()
        {
            Resultas = OperandeGauche - OperandeDroite;
        }
    }
}