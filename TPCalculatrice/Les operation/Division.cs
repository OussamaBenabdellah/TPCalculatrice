namespace TPCalculatrice.Les_operation
{
    public class Division : Operation 
    {
        public Division(int operandeGauche, int operandeDroite) : base(operandeGauche, operandeDroite)
        {
        }

        public override void Excuter()
        {
            if (OperandeDroite != 0)
            {
                Resultas = OperandeGauche / OperandeDroite;
            }
            else
            {
                Console.WriteLine("on ne peut pas déviser par la valeur Zéro");
            }
        }
    }
}