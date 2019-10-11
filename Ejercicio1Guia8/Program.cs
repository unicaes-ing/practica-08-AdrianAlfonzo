using System;

namespace Ejercicio1Guia8
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 11.10.19
    //-------Luis Adrián Alfonzo Morán-------
    class Program
    {
        //Estructura
        public struct Student
        {
            //Base
            public string name;
            public string carnet;
            public string run;
            private double cum;
            //Main
            static void Main(string[] args)
            {
                //Base
                Student studentOne = new Student();
                //Consulta
                Console.WriteLine("¿Cuál es su carnet de estudiante?");
                studentOne.carnet = Console.ReadLine();
                Console.WriteLine("¿Cuál es su nombre completo?");
                studentOne.name = Console.ReadLine();
                Console.WriteLine("¿Que carrera está estudiando actualmente?");
                studentOne.run = Console.ReadLine();
                Console.WriteLine("¿De cuánto es su CUM?");
                studentOne.SetCum(Convert.ToDouble(Console.ReadLine()));
                Console.Clear();
                //Mostrar
                Console.WriteLine("Su número de carnet es:  {0}", studentOne.carnet);
                Console.WriteLine("Su nombre completo es: {0}", studentOne.name);
                Console.WriteLine("La carrera que estudia actualmente es: {0}", studentOne.run);
                Console.WriteLine("Su CUM es de: {0}", studentOne.GetCum());
            }
            //Setter
            public void SetCum(double cum)
            {
                //Proceso en IF
                if (cum >= 0)
                {
                    //Proceso en IF
                    if (cum <= 10)
                    {
                        this.cum = cum;
                    }
                }
            }
            //Getter
            public double GetCum()
            {
                return cum;
            }
        }
    }
}