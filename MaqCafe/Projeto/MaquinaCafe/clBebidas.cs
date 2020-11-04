using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafe
{
    public static class clBebidas
    {

        public static IDictionary<string, double> Bebidas = new Dictionary<string, double>()
        {
            {"Cappuccino",3.50 },
            {"Mocha",4.00 },
            {"Café com leite",3.00 }
        };

    }
}
