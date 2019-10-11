using System;

namespace Ejercicio1Guia8
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 11.10.19
    //-------Luis Adrián Alfonzo Morán-------
    class Ejercicio2Guia8
    {
        //Estructura
        public struct Product
        {
            //Base
            public string name;
            private int quantity;
            private double money;
            private const double IVA = 0.13;
            static void Main(string[] args)
            {
                //Base
                int cantidad;
                //Consulta
                Console.WriteLine("¿Cuántos productos agregará?");
                cantidad = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Product[] prod = new Product[cantidad];
                //Proceso en FOR
                for (int i = 0; i < prod.Length; i++)
                {
                    Console.WriteLine("Producto #{0}", i + 1);
                    Console.WriteLine("¿Que producto desea agregar?");
                    prod[i].name = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("¿Cuántos {0} llevará?", prod[i].name);
                    prod[i].SetCantity(Convert.ToInt32(Console.ReadLine()));
                    Console.Clear();
                    Console.WriteLine("¿Cuál es el precio del producto?");
                    prod[i].SetMoney(Convert.ToDouble(Console.ReadLine()));
                    Console.Clear();
                }
                //Proceso en FOR
                for (int i = 0; i < prod.Length; i++)
                {
                    Console.Clear();
                    Console.WriteLine("Presione cualquier tecla para visualizar la información agregada...");
                    Console.ReadKey();
                    //Mostrar
                    Console.Clear();
                    double total;
                    total = prod[i].GetCantity() * prod[i].GetMoney();
                    Console.WriteLine("{0,5}   {1,-10}   {2,7}   {3,9} ", "Producto", "Cantidad", "Precio", "Total");
                    Console.WriteLine("-------------------------------------------------------------");
                    //Proceso en FOREACH
                    foreach (Product p in prod)
                    {
                        Console.WriteLine("{0,5}  {1,8}  {2, 13}   {3,10} ",
                            prod[i].name,
                            prod[i].GetCantity(),
                            prod[i].GetMoney(),
                            total);
                    }
                }
                Console.WriteLine();
                Console.ReadKey();
            }
            //Getter
            public double GetMoney()
            {
                double pay;
                pay = money * IVA;
                return money + pay;
            }
            //Setter
            public void SetMoney(double price)
            {
                if (price > 0.00)
                {
                    this.money = price;
                }
            }
            //Setter
            public void SetCantity(int cantity)
            {
                if (cantity > 0)
                {
                    this.quantity = cantity;
                }
            }
            //Getter
            public int GetCantity()
            {
                return quantity;
            }
        }
    }
}
