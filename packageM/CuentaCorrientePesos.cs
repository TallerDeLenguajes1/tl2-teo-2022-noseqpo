using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace packageM
{
    internal class CuentaCorrientePesos : Cuenta
    {
        int limiteEx = 20000;

        public override void Extraccion(int modo, int monto)
        {
            if (monto > saldo)
            {
                Console.WriteLine("Sin saldo disponible");
            }
            else
            {
                switch (modo)
                {
                    case 1:
                        if (monto > limiteEx)
                        {
                            Console.WriteLine("Limite de extraccion excedido");
                        }
                        else
                        {
                            Console.WriteLine("Usted ha retirado {0}.", monto);
                            saldo -= monto;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Usted ha retirado {0}.", monto);
                        saldo -= monto;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
        }
    }
}
