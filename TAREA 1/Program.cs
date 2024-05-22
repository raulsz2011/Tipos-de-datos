using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  tipos de datos

            int entero = 0;
            int edad;
            int num1, num2, num3;
            byte b = 255;
            long larga = 222;

            float flotante = 3.14f; //32 bits
            double doble = 56.15;  // 64bit
            decimal dec = 124.15m; //32 bits

            Boolean boleano = true;

            string cadena = "Bienvenidos al curso de c#";
            char caracter = 'A';

            string nombre = "", apellido = "";

            var variable = 20;

            dynamic dinamica = 20;
            dinamica = "Curso de C#";
            dinamica = true;
            dinamica = 'c';
            #endregion

            //Console.WriteLine("Hola");  // imprmir en pantalla
            //Console.Write(" Mundo");

            //Console.Write("Digite su nombre: ");
            //nombre = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Digite su edad: ");
            //edad = int.Parse(Console.ReadLine());  //Parse

            //Console.WriteLine("Mi nombre es: " + nombre + " mi edad es: " + edad);  // contatenar con simbolo mas

            // operadores  + - * / > < >= <= != ==  %

            num1 = 3;
            num2 = 5;
            #region calculadora
            Console.WriteLine("Suma: " + (num1 + num2));
            Console.WriteLine("Multiplicacion: " + (num1 * num2));
            Console.WriteLine("Dividir: " + (num1 / num2));
            Console.WriteLine("Resta: " + (num1 - num2));


            //Console.WriteLine();
            //Console.WriteLine("Suma: " + (num1 + num2));

            #endregion

            // if
            //Console.Write("Digite un numero:"); num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Digite otro numero:"); num2 = Convert.ToInt32(Console.ReadLine());
            //if (num1 > num2)
            //{
            //    Console.WriteLine("{0} es mayor que{1} ", num1, num2); // referencia 
            //                                                           //  0      1
            //}
            //else
            //{
            //    Console.WriteLine("{1} es mayor que{0} ", num1, num2); // referencia 
            //                                                           //    0     1
            //}

            // for

            // contadores y acumuladores
            // i = 0
            // contador i = i + 1  ==  i++   ++i  incrementar
            // contador i = i - 1  ==  i--   --i  decrementar
            // contador i = i + 2  ==  i+=2   i-=2   i*=2  i/=2
            int contador = 0;

            contador++;

            for (int i = 1; i <= 20; i *= 2)
            {
                Console.WriteLine(i);
            }

            Console.Read();  // leer datos

        }

    }
}
