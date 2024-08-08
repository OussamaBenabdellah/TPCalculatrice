namespace TPCalculatrice.Les_operation
{
    public abstract class Operation : IOperation 
    {
        protected int OperandeDroite { get; }
        protected int OperandeGauche { get; }
        public int  Resultas { get ; protected  set; }

        protected Operation(int operandeGauche, int operandeDroite)
        {
            OperandeGauche = operandeGauche;
            OperandeDroite = operandeDroite;
        }

        public abstract void Excuter();
    }
}