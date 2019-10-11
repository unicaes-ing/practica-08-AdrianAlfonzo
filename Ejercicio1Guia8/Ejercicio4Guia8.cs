using System;

namespace Ejercicio1Guia8
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 11.10.19
    //-------Luis Adrián Alfonzo Morán-------
    class Ejercicio4Guia8
    {
        //Enumeración
        public enum TipoDePago
        {
            //Base
            HandMoney = 1,
            DebitCard = 2,
            CreditCard = 3
        }
        //Main
        static void Main(string[] args)
        {
            //Base
            double pay;
            //Consulta
            Console.WriteLine("¿Cuánto pagará?");
            pay = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("¿Que método de pago usará?");
            Console.WriteLine(" [1] Efectivo");
            Console.WriteLine(" [2] Debito");
            Console.WriteLine(" [3] Credito");
            Console.WriteLine();
            int answer = Convert.ToInt32(Console.ReadLine());
            //Proceso en SWITCH
            switch ((TipoDePago)answer)
            {
                //Caso I
                case TipoDePago.HandMoney:
                Console.Clear();
                Console.WriteLine("Abono: ${0}", pay);
                Console.WriteLine("Efectivo: Se le aplicará un descuento del 15%");
                //Base
                double totOne, subOne;
                subOne = pay * 0.15;
                totOne = pay - subOne;
                Console.WriteLine("Total a pagar son: ${0}", totOne);
                break;
                //Caso II
                case TipoDePago.DebitCard:
                Console.Clear();
                Console.WriteLine("Abono: ${0}", pay);
                Console.WriteLine("Debito: Se le aplicará un descuento del 10%");
                //Base
                double totTwo, subTwo;
                subTwo = pay * 0.10;
                totTwo = pay - subTwo;
                Console.WriteLine("Total a pagar son: ${0}", totTwo);
                break;
                //Caso III
                case TipoDePago.CreditCard:
                Console.Clear();
                Console.WriteLine("Abono: ${0}", pay);
                Console.WriteLine("Credito: Se le aplicará un descuento del 5%");
                //Base
                double totThree, sub3;
                sub3 = pay * 0.05;
                totThree = pay - sub3;
                Console.WriteLine("Total a pagar son: ${0}", totThree);
                break;
            }
            Console.ReadKey();
        }
    }
}
