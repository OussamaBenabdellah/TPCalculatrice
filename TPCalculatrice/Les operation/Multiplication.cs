namespace TPCalculatrice.Les_operation
{
    public class Multiplication : Operation 
    {
        public Multiplication(int operandeGauche, int operandeDroite) : base(operandeGauche, operandeDroite)
        {
        }

        public override void Excuter()
        {
            Resultas = OperandeGauche * OperandeDroite;
        }
    }
}