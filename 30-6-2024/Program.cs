using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _30_6_2024
{


    internal class Program
    {


        class Student
        {
            //field
            public int id;
            public string name;
            public int age;
            public string gender;
            public string e_mail;
            public int phone;

            //constructor
            public Student() 
            {
                this.id = 1;
                this.name = "duha";
                this.age = 28;
                this.gender = "female";
                this.e_mail = "odatduha@gmail.com";
                this.phone = 0777601083;
            }


        }

        // Q1:
        static int Sum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];


            }
            return sum;
        }
        static double Avarage(int[] numbers)
        {

            double avarage = Sum(numbers) / numbers.Length;
            return avarage;

        }
        ///////////////////////////////////////////////////////////////

        //Q2:
        static int Cube(int num)
        {
            int cubeOfNumber = num * num * num;
            return cubeOfNumber;
        }
        //Q3:
        static int[] getYear(int[] years)
        {

            List<int> specialYears = new List<int>();
            for (int j = 0; j < years.Length; j++)
            {
                if (years[j] > 1950)
                {
                    specialYears.Add(years[j]);
                }
            }
            return specialYears.ToArray();
        }
        //Q4:
        static int getAge(int age)
        {
            int AgeInDay = age * 365;
            return AgeInDay;
        }
       
         
        

       
        
        static void Main(string[] args)
        {
            //Q1:
            //Console.WriteLine("write 10 number:");
            //int[] arrayOfNumber = new int[10];

            //for (int i = 0; i < arrayOfNumber.Length; i++)
            //{
            //    Console.Write($"Write number {i}: ");
            //    arrayOfNumber[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //Console.WriteLine($"Sum of 10 numbers {Sum(arrayOfNumber)}");
            //Console.WriteLine($"Avarage of 10 numbers {Avarage(arrayOfNumber)}");
            Console.WriteLine();
            
            // Q2:
            int n = 5;
            Console.WriteLine($"Number is : {n} and cube of the {n} is :{Cube(n)}");
            Console.WriteLine();
            //Q3:
            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            int[] result = getYear(years);
            Console.WriteLine(string.Join(", ", result));

            Console.WriteLine();

            //Q4
            int age = 28;
            Console.WriteLine($" age in days :{getAge(age)}");
            Console.WriteLine();

            //Q5:
            Student student1 = new Student();
            Console.WriteLine(student1.name);
        }
    }
}
