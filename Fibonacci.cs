using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targetSistemas
{
    class Fibonacci
    {
        private int numero;
        private bool pertence;

        public Fibonacci(int numero)
        {
            this.numero = numero;
            this.pertence = false;
        }

        public void ImprimirSequencia()
        {
            int a = 0;
            int b = 1;
            int c = 0;

            Console.Write("Sequência de Fibonacci: ");

            while (c <= numero)
            {
                Console.Write("{0} ", c);

                if (c == numero)
                {
                    pertence = true;
                }

                c = a + b;
                a = b;
                b = c;
            }

            Console.WriteLine();
        }

        public void VerificarPertinencia()
        {
            if (pertence)
            {
                Console.WriteLine("{0} pertence à sequência de Fibonacci.", numero);
            }
            else
            {
                Console.WriteLine("{0} não pertence à sequência de Fibonacci.", numero);
            }
        }
    }
}