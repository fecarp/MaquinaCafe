using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafe
{
    public static class clDinheiro
    {
         
        public static string CalcTroco(double Valor)
        {
            double ValOrig = Valor;
            int M10 = 0;
            int M25 = 0;
            int M50 = 0;
            int M1R = 0;

            if (Valor.ToString().EndsWith("5")){
                M25 += 1;
                Valor -= 0.25;
            }

            while (Valor >= 1.00)
            {
                M1R += 1;
                Valor -= 1.00;
            }

            if (Valor >= 0.50)
            {
                M50 += 1;
                Valor -= 0.50;
            }

            while (Valor >= 0.10)
            {
                M10 += 1;
                Valor -= 0.10;
            }

            string Ret = string.Format("{0:0.00} \nDevolvido: {1} x 1Real;\n{2} x 50 Centavos;\n{3} x 25 Centavos;\n{4} x 10 Centavos;", ValOrig, M1R, M50, M25, M10);
            return Ret;
        }
    }
}
