using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _28_6_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Q1://////////////////////////////////////////////////////////////////////
            //	Correct the syntax error:
            //wrong-	string[] ARR = [1, 7  9  45,]
            int[] ARR = { 1, 7, 9, 45 };
            // wrong -  int arr2=["Str" "alex","moh"
            string[] arr2 = { "Str", "alex", "moh" };
            // wrong- 	string arr3= 'the','fox' 'over' lazy, 'dog',  ]
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };


            //Q2://////////////////////////////////////////////////////////////////////
            //What the index of "Banana","Tomato"?
            String[] fruits = { "Tomato", "Banana", "Watermelon" };

            int bananaIndex = Array.IndexOf(fruits, "Banana");
            Console.WriteLine($"BananaIndex: {bananaIndex}");

            int tomatoIndex = Array.IndexOf(fruits, "Tomato");
            Console.WriteLine($"TomatoIndex: {tomatoIndex}");
            Console.WriteLine("\n");

            //Q3://///////////////////////////////////////////////////////////////////

            string[] favoritFood = { "maqloba", "tabolah", "Pasta", "Pitza", "Tomato" };
            string[] favoriteSport = { "running", "Bowling", "Horse Racing" };
            string[] favoriteMovie = { "The Call", "Ocean 14", "3 Idiots", "alaaldeen" };

            foreach (string item in favoritFood)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < favoritFood.Length; i++)
            {

                Console.WriteLine(favoritFood[i]);
            }

            Console.WriteLine("\n");
            foreach (string item1 in favoriteSport)
            {
                Console.WriteLine(item1);
            }
            Console.WriteLine("\n");
            for (int j = 0; j < favoriteSport.Length; j++)
            {

                Console.WriteLine(favoriteSport[j]);
            }

            Console.WriteLine("\n");

            foreach (string item2 in favoriteMovie)
            {
                Console.WriteLine(item2);
            }
            Console.WriteLine("\n");
            for (int k = 0; k < favoriteMovie.Length; k++)
            {

                Console.WriteLine(favoriteMovie[k]);
            }

            Console.WriteLine("\n");


            // Q4://///////////////////////////////////////////////////////////////////
            //Console.Write("Input three numbers separated by comma: ");
            // string str =Console.ReadLine();

            //string [] numbers=str.Split(',');

            //if (numbers.Length != 3)
            //{
            //    Console.WriteLine("please enter just 3 number");

            //}
            //else
            //{
            //    int number1 = Convert.ToInt32(numbers[0]);
            //    int number2 = Convert.ToInt32(numbers[1]);
            //    int number3 = Convert.ToInt32(numbers[2]);

            //    int sum = number1 + number2 + number3;
            //    Console.WriteLine($"The sum of three numbers: {sum}");

            //}

            Console.WriteLine("\n");

            // Q5://///////////////////////////////////////////////////////////////////

            int sum = 0;
            Console.Write($"The odd numbers are: ");
            for (int x = 0; x < 100; x++)
            {

                if (x % 2 != 0)
                {
                    Console.Write(x + " ");
                    sum = sum + x;
                }


            }
            Console.WriteLine("\n");
            Console.WriteLine($"The Sum of odd Numbers is: {sum} ");
            Console.WriteLine("\n");


            //Q6://///////////////////////////////////////////////////////////////////


            for (int m = 1; m < 5; m++)
            {
                for (int n = 0; n < m; n++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine("\n");
            }


            Console.WriteLine("\n");

            int num = 1;
            for (int y = 1; y < 5; y++)
            {
                
                
                for (int z = 0;  z< y; z++)
                {
                    Console.Write(num+" ");
                  num++;
                  
                }

                Console.WriteLine("\n");


            }
        }
    }
}
