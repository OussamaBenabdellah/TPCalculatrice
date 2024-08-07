namespace TPCalculatrice.Les_operation
{
    public class Modulo : Operation
    {
        public Modulo(int operandeGauche, int operandeDroite) : base(operandeGauche, operandeDroite)
        {
        }

        public void Excuter()
        {
            Resultas = OperandeGauche % OperandeDroite;

        }
    }
}