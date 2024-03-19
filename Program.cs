using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Program
    {
        public static void Main()
        {
            Ex26();
            Ex27();
            Ex28();
            Ex29();
            Ex30();
            Ex31();
            Ex32();
            Ex33();
           
        }

        public static void Ex26()
        {
            Console.WriteLine("Exercici 26");
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var myLinqQuery = from num in array
                              where num % 2 == 0
                              select num;

            Console.WriteLine("Nombres parells:");
            foreach (var num in myLinqQuery)
            {
                Console.WriteLine(num);
            }

        }

        public static void Ex27()
        { 
            Console.WriteLine("\nExercici 27");
            int[] array = {-1,-2,-3,-4, 0, 1, 2, 3 };

            var myLinqQuery = from num in array
                              where num>=0
                              select num;
            Console.WriteLine("Nombres positius:");

            foreach (var num in myLinqQuery)
            {
                Console.WriteLine(num);
            }

        }
        public static void Ex28()
        {
            Console.WriteLine("\nExercici 28");

            int[] array = { 15, 16, 17, 18, 19, 20, 21, 22, 23 };

            var myQuery = from num in array
                          where num >= 20
                          select num;

            Console.WriteLine("Numeros majors que 20 en la seva potencia");
            foreach (var item in myQuery)
            {
                Console.WriteLine(item * item);

            }
        }

        public static void Ex29()
        {
            Console.WriteLine("\nExercici 29");
            List<int> array = new List<int> { 1, 2, 3, 4, 5,  7, 8, 9, 1, 2, 4, 5, 6, 8, 9, 10 };

            var myQuery = from num in array
                          group num by num into gr
                          select new { num = gr.Key, freq = gr.Count() };

            Console.WriteLine("Frequencia de nombres:");

            foreach (var item in myQuery)
            {
                Console.WriteLine("Numero: " + item.num + " Freqüència: " + item.freq);
            }
        }


        public static void Ex30()
        {
            Console.WriteLine("\nExercici 30");
            string array = "Eric puto tonto";

            var myQuery = from letter in array
                          group letter by letter into gr
                          select new { letter = gr.Key, freq = gr.Count() };

            Console.WriteLine("Frequencia de lletres:");

            foreach (var letter in myQuery)
            {
                Console.WriteLine("Caracter: " + letter.letter + " Freqüència: " + letter.freq);
            }
        }

        public static void Ex31()
        {
            Console.WriteLine("\nExercici 31");
            string[] diesSetmana = { "Dilluns", "Dimarts", "Dimecres", "Dijous", "Divendres", "Dissabte", "Diumenge" };
            var myQuery = from dia in diesSetmana
                          select dia;

            foreach (var dia in myQuery)
            {
                Console.WriteLine(dia);
            }

        }

        public static void Ex32()
        {
            Console.WriteLine("\nExercici 29");
            List<int> array = new List<int> { 1, 2, 3, 4, 5, 7, 8, 9, 1, 2, 4, 5, 6, 8, 9, 10 };

            var myQuery = from num in array
                          group num by num into gr
                          select new { num = gr.Key, freq = gr.Count() };

            Console.WriteLine("Frequencia de nombres:");

            foreach (var item in myQuery)
            {
                Console.WriteLine("Numero: " + item.num + " Freqüència: " + item.freq + " Multiplicacio Numero-Frequencia: " + item.num * item.freq);
            }

        }

        public static void Ex33()
        {
            Console.WriteLine("\nExercici 33");
            string[] arrayCiutats = { "ROMA", "LONDRES", "NAIROBI", "CALIFÒRNIA", "ZURICH", "NOVA DELHI", "AMSTERDAM", "ABU DHABI", "PARÍS" };

            char carInici = 'A';
            char carFinal = 'M';

            var myQuery = from ciutat in arrayCiutats
                          where ciutat.StartsWith(carInici) && ciutat.EndsWith(carFinal)
                          select ciutat;

            Console.WriteLine("La ciutat que comença amb " + carInici + " i acaba amb " + carFinal + " és : " + myQuery.First());
            
        }
    }
}