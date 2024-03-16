using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01
{
    public class CajeroAutomatico : CuentaBancaria
    {

        public int ConsultarSaldo()
        {
            return Saldo;
        }

        public int DepositarFondos(int cantidad)
        {
            Saldo += cantidad;
            return Saldo;
        }

        public int RetirarEfectivo(int cantidad)
        {
            
            if (cantidad <= Saldo)
            {
                Saldo -= cantidad; 
                return Saldo;
            }
            else
            {
                Console.WriteLine("Sin fondos");
                return Saldo; 
            }
        }


        public int CambiarPin(int nuevoPin)
        {
            Pin = nuevoPin;
            return Pin;
        }
    }
}
