namespace TPCalculatrice.Les_operation
{
    public class Addition : Operation
    {
        public Addition(int operandeGauche, int operandeDroite) : base(operandeGauche, operandeDroite)
        {
        }

        public void Excuter()
        {
            Resultas = OperandeGauche + OperandeDroite;
        }
    }
}