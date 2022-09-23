using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace packageM
{
    internal class Cuenta
    {
        internal int saldo = 0;
        int limiteEx = 0;

        public void Insercion(int monto)
        {
            saldo += monto;
        }

        public override void Extraccion(int modo, int monto)
        {
            
        }


    }
}
