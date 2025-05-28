using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace exament2
{
    class Program
    {
        static void Main(string[] args)
        {
            Inicio();
        }
        static void Inicio()
        {
            int opcion;
            do
            {
                
                Console.WriteLine("\t\t****BANCO UPN****");
                Console.WriteLine("1. RETIRO ");
                Console.WriteLine("2. DEPOSITO");
                Console.WriteLine("3. SALDO");
                Console.WriteLine("0. SALIR\n");
                Console.WriteLine("SELECIONE UN NÚMERO: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 0:
                        
                        salida();
                        break;
                    case 1:
                        Console.WriteLine("******RETIRO******");
                        retiro();
                        break;
                    case 2:
                        Console.WriteLine("******DEPOSITO******");
                        Deposito();
                        break;
                    case 3:
                        Console.WriteLine("******SALDO******");
                        Saldo();
                        break;
                    default:
                        break;
                }
                
            }
            while (opcion!=0);
        }
        static void retiro()
        {
            
            double saldo = 5000;
            double retiro;
            double saldoactual = saldo;
            
            Console.WriteLine("INRGESE EL MONTO A RETIRAR: ");
            retiro = int.Parse(Console.ReadLine());
            
                if (retiro > saldo)
                {
                    Console.WriteLine("DINERO INSUFICIENTE");
                }
                else if (retiro <= saldo)
                {
                
                    if (retiro <= 0)
                    {
                        Console.WriteLine("INGRESE UN NÚMERO VALIDO");
                    }
                    else if (retiro <= 500)
                    {
                        retiro = retiro - 8;
                        saldo = saldo - (retiro+8);

                        Console.WriteLine("USTED RETIRO: " + retiro);
                        Console.WriteLine("SU SALDO ACTUAL ES : S/" + saldo);
                        
                    }
                    else
                    {
                        Console.WriteLine("No puede retirar mas de S/. 500");
                    }
                }
                    
                
            

        }
        static void Deposito()
        {
            
            double saldo = 5000;
            double deposito;
            
            Console.WriteLine("INRGESE EL MONTO A DEPOSITAR: ");
            deposito = int.Parse(Console.ReadLine());

            if (deposito<=0)
            {
                Console.WriteLine("INGRESE UN CANTIDAD VALIDA");
            }
            else if (deposito<=1000)
            {
                deposito = deposito - 2;
                saldo = saldo + (deposito+2);
                Console.WriteLine("USTED DEPOSITO: " + deposito);
            }
            else
            {
                Console.WriteLine("SOLO PUEDE ABONAR S/.1000");

            }
        }
        static void Saldo()
        {
            string saldo;
            Console.WriteLine("SALDO INICIAL: S/5000");
            Console.WriteLine("HIZO DEPOSIO o RETIRO");
            saldo = Console.ReadLine();
            switch (saldo)
            {
                case "deposito":
                    Console.WriteLine("CUANTO DEPOSITO: ");
                    Double NUM1= double.Parse(Console.ReadLine());
                    break;
                case "retiro":
                    Console.WriteLine("CUANTO RETIRO: ");
                    Double NUM2 = double.Parse(Console.ReadLine());
                    break;
                default:
                    break;
            }
        }
        static void salida()
        {
            Console.WriteLine("\t\t\t\t*********** ESPERAMOS VERTE DE NUEVO ***********\t\t\t\t \n");
            Console.WriteLine("\t\t\t\t\t*********** ADIOS ***********\t\t\t\t\t\t \n");
            Console.ReadKey();
        }
        
    }
}
