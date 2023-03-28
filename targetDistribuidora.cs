using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targetSistemas
{
    public class targetDistribuidora
    {
        private double[] faturamentoDiario;

        public targetDistribuidora(double[] faturamentoDiario)
        {
            this.faturamentoDiario = faturamentoDiario;
        }

        public double MenorFaturamento()
        {
            double menor = faturamentoDiario[0];
            for (int i = 1; i < faturamentoDiario.Length; i++)
            {
                if (faturamentoDiario[i] < menor)
                {
                    menor = faturamentoDiario[i];
                }
            }
            return menor;
        }

        public double MaiorFaturamento()
        {
            double maior = faturamentoDiario[0];
            for (int i = 1; i < faturamentoDiario.Length; i++)
            {
                if (faturamentoDiario[i] > maior)
                {
                    maior = faturamentoDiario[i];
                }
            }
            return maior;
        }

        public int DiasAcimaDaMedia()
        {
            double media = MediaFaturamentoDiario();
            int diasAcima = 0;
            for (int i = 0; i < faturamentoDiario.Length; i++)
            {
                if (faturamentoDiario[i] > media)
                {
                    diasAcima++;
                }
            }
            return diasAcima;
        }

        private double MediaFaturamentoDiario()
        {
            double soma = 0;
            int diasUteis = 0;
            for (int i = 0; i < faturamentoDiario.Length; i++)
            {
                if (faturamentoDiario[i] > 0)
                {
                    soma += faturamentoDiario[i];
                    diasUteis++;
                }
            }
            return soma / diasUteis;
        }
    }

}
