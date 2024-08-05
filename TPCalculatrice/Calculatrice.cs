using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCalculatrice
{
    public class Calculatrice
    {
        private int operandDroite;
        public int operandGauche;
        public int Resultas { get; set; }
        public int OperandDroite { get; set; }
        public int OperandGauche { get; set; }



        public string? Operator { get; set; }

        public Calculatrice()
        {
            //operandDroite = a;
            //operandGauche = OperandGauche;
        }

        public int Addition(int a, int b)
        {
            return Resultas = a + b;

        }

        public int Soustraction(int a, int b)
        {
            return Resultas = a - b;

        }
        public int Division(int a, int b)
        {
            if (b != 0)
            {

                return Resultas = a / b;
            }
            else
            {
                Console.WriteLine("on ne peut pas déviser par la valeur Zéro");
                return 0;

            }



        }
        public int Multiplication(int a, int b)
        {
            return Resultas = a * b;
        }

        public int Modulo(int a, int b)
        {
            return Resultas = a % b;

        }


    }
}
