// See https://aka.ms/new-console-template for more information
using demo01;

Console.WriteLine("=======================================");
Console.WriteLine("Cajero Automatico");
Console.WriteLine("=======================================");
CajeroAutomatico cajero = new CajeroAutomatico();

cajero.NumCuenta = 4654645;
cajero.Titular = "Rafael";
cajero.Saldo = 1200;
cajero.Pin = 123;



bool salir = false;

while (!salir)
{
    Console.WriteLine("1. Consultar Saldo");
    Console.WriteLine("2. Depositar fondos");
    Console.WriteLine("3. Retirar Efectivo");
    Console.WriteLine("4. Cambiar Pin");
    Console.WriteLine("5. Salir");
    Console.WriteLine("Elige una de las opciones:");
    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("----------------------");
            int consultarSaldo = cajero.ConsultarSaldo();
            Console.WriteLine("Su Saldo es: ");
            Console.WriteLine(consultarSaldo);
            Console.WriteLine("----------------------");
            break;

        case 2:
            Console.WriteLine("----------------------");
            Console.WriteLine("Deposite los fondos: ");
            int deposito = int.Parse(Console.ReadLine());
            cajero.DepositarFondos(deposito);
            int depositarFondos = cajero.ConsultarSaldo();
            Console.WriteLine("Su nuevo saldo es: ");
            Console.WriteLine(depositarFondos);
            Console.WriteLine("---------------------");
            break;

        case 3:
            Console.WriteLine("----------------------");
            Console.WriteLine("Retirar Efectivo: ");
            int retiro = int.Parse(Console.ReadLine());
            int retirarEfectivo = cajero.RetirarEfectivo(retiro);
            Console.WriteLine("Su nuevo saldo es: ");
            Console.WriteLine(retirarEfectivo);
            Console.WriteLine("----------------------");
            break;
        case 4:
            Console.WriteLine("----------------------");
            Console.WriteLine("Cambie su PIN: ");
            int nuevoPin = int.Parse(Console.ReadLine());
            int pinCambiado = cajero.CambiarPin(nuevoPin);
            Console.WriteLine("Su nuevo PIN es: ");
            Console.WriteLine(pinCambiado);
            Console.WriteLine("----------------------");
            break;
        case 5:
            Console.WriteLine("Has elegido salir de la aplicación");
            salir = true;
            break;
        default:
            Console.WriteLine("Elige una opcion entre 1 y 5");
            break;
    }

}

//Consultar Saldo


//Depositar Fondos


//Retirar Efectivo


//Cambiar Pin

