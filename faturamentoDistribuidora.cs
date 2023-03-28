using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targetSistemas
{
    public class FaturamentoDistribuidora
    {
        public double Sp { get; set; }
        public double Rj { get; set; }
        public double Mg { get; set; }
        public double Es { get; set; }
        public double Outros { get; set; }

        public Dictionary<string, double> CalcularPercentuais()
        {
            var total = Sp + Rj + Mg + Es + Outros;
            var percentuais = new Dictionary<string, double>();
            percentuais.Add("SP", Sp / total * 100);
            percentuais.Add("RJ", Rj / total * 100);
            percentuais.Add("MG", Mg / total * 100);
            percentuais.Add("ES", Es / total * 100);
            percentuais.Add("Outros", Outros / total * 100);
            return percentuais;
        }
    }

}
