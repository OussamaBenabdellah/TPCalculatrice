using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCalculatrice.Les_operation
{
    public class Operation
    {
        public int OperandeDroite { get; set; }
        public int OperandeGauche { get; set; }
        public int Resultas { get; set; }

        public Operation(int operandeGauche, int operandeDroite)
        {
            OperandeGauche = operandeGauche;
            OperandeDroite = operandeDroite;
        }
    }
}
