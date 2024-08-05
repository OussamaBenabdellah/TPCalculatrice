using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCalculatrice
{
    internal class Calculatrice
    {
        
        private int Resultas { get; set; }
        
        

        public int Addition(int a, int b) 
        { return Resultas = a + b; }

        public int Soustraction(int a , int b)
        {
            return Resultas = a - b;
        }
        public int  Division( int a, int b)
        {
            if (b != 0)
            {
                
                    return Resultas = a / b;
            }

            return Resultas = 0;
            

        } 
        public int Multiplication( int a , int b)
        {
            return Resultas = a* b;
        }

        public int Modulo(int a , int b)
        {
            return Resultas = a % b;

        }
    }
}
