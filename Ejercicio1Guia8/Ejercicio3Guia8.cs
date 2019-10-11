using System;

namespace Ejercicio1Guia8
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 11.10.19
    //-------Luis Adrián Alfonzo Morán-------
    class Ejercicio3Guia8
    {
        //Estructura
        public struct Student
        {
            public string nameStudent;
            public string ID;
            public string run;
            public Signature signatureOne;
            public Signature signatureTwo;
            public Signature signatureThree;
            public Signature signatureFour;
        }
        //Estructura
        public struct Signature
        {
            public string nameSignature;
            private double grade;
            //Getter
            public double GetGrade()
            {
                return grade;
            }
            //Setter
            public void SetGrade(double grade)
            {
                if (grade >= 0 && grade <= 10)
                {
                    this.grade = grade;
                }
                else
                {
                    this.grade = 1;
                }
            }
        }
        //Función
        static string AprobReprob(double grade)
        {
            if (grade >= 7)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                string yes = "¡Ha aprobado, felicidades!";
                return yes;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                string no = "¡Lo siento, ha reprobado!";
                return no;
            }
        }
        //Main
        static void Main(string[] args)
        {
            //Base
            int how;
            //Consulta
            Console.WriteLine("¿Cuántos estudiantes se analizarán?");
            how = Convert.ToInt32(Console.ReadLine());
            Student[] StudentArray = new Student[how];
            Console.Clear();
            //Proceso en FOR
            for (int i = 0; i < StudentArray.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Estudiante {0}", i + 1);
                Console.WriteLine("¿Cuál es el nombre del estudiante?");
                StudentArray[i].nameStudent = Console.ReadLine();
                Console.WriteLine("¿Cuál es el carnet o identificador estudiantil?");
                StudentArray[i].ID = Console.ReadLine();
                Console.WriteLine("´¿Que carrera está estudiando actualmente?");
                StudentArray[i].run = Console.ReadLine();
                ////
                Console.Clear();
                Console.WriteLine("¿Cuál es el nombre de la materia I?");
                StudentArray[i].signatureOne.nameSignature = Console.ReadLine();
                Console.WriteLine("¿Nota?");
                StudentArray[i].signatureOne.SetGrade(Convert.ToDouble(Console.ReadLine()));
                ////
                Console.Clear();
                Console.WriteLine("¿Cuál es el nombre de la materia II?");
                StudentArray[i].signatureTwo.nameSignature = Console.ReadLine();
                Console.WriteLine("¿Nota?");
                StudentArray[i].signatureTwo.SetGrade(Convert.ToDouble(Console.ReadLine()));
                ////
                Console.Clear();
                Console.WriteLine("¿Cuál es el nombre de la materia III?");
                StudentArray[i].signatureThree.nameSignature = Console.ReadLine();
                Console.WriteLine("¿Nota?");
                StudentArray[i].signatureThree.SetGrade(Convert.ToDouble(Console.ReadLine()));
                ////
                Console.Clear();
                Console.WriteLine("¿Cuál es el nombre de la materia IV?");
                StudentArray[i].signatureFour.nameSignature = Console.ReadLine();
                Console.WriteLine("¿Nota?");
                StudentArray[i].signatureFour.SetGrade(Convert.ToDouble(Console.ReadLine()));
                Console.Clear();
            }
            //Proceso en FOR
            for (int i = 0; i < StudentArray.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Estudiante #{0}", i + 1);
                Console.WriteLine("Nombre completo: {0}", StudentArray[i].nameStudent);
                Console.WriteLine("Carnet o ID: {0}", StudentArray[i].ID);
                Console.WriteLine("Carrera que estudia: {0}", StudentArray[i].run);
                ////
                Console.WriteLine();
                Console.WriteLine("{0}", StudentArray[i].signatureOne.nameSignature);
                Console.WriteLine("Nota: {0}", StudentArray[i].signatureOne.GetGrade());
                Console.WriteLine("{0}", AprobReprob(StudentArray[i].signatureOne.GetGrade()));
                ////
                Console.WriteLine();
                Console.WriteLine("{0}", StudentArray[i].signatureTwo.nameSignature);
                Console.WriteLine("Nota: {0}", StudentArray[i].signatureTwo.GetGrade());
                Console.WriteLine("{0}", AprobReprob(StudentArray[i].signatureTwo.GetGrade()));
                ////
                Console.WriteLine();
                Console.WriteLine("{0}", StudentArray[i].signatureThree.nameSignature);
                Console.WriteLine("Nota: {0}", StudentArray[i].signatureThree.GetGrade());
                Console.WriteLine("{0}", AprobReprob(StudentArray[i].signatureThree.GetGrade()));
                ////
                Console.WriteLine();
                Console.WriteLine("{0}", StudentArray[i].signatureFour.nameSignature);
                Console.WriteLine("Nota: {0}", StudentArray[i].signatureFour.GetGrade());
                Console.WriteLine("{0}", AprobReprob(StudentArray[i].signatureFour.GetGrade()));
            }
        }
    }
}
