using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._06._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q1:
            Console.WriteLine("please enter your name?");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            ////Q2
            double num1 = 10.5;
            Console.WriteLine(num1);

            string str = "happy";
            Console.WriteLine(str);

            char mark = 'A';
            Console.WriteLine(mark);

            bool isLogin = false;
            Console.WriteLine(isLogin);

            int age = 28;
            Console.WriteLine(age);

            const int waterBoiling = 100;
            Console.WriteLine(waterBoiling);

            //Q3:

            string[] car = { "Volvo", "BMW", "Ford" };
            Console.WriteLine(car[0]);
            Console.WriteLine(car[1]);
            Console.WriteLine(car[2]);
            Console.WriteLine(car.Length);

            //Q4:
            Console.Write("Input your firstname:");
            string firstName = Console.ReadLine();
            Console.Write("Input your lastname:");
            string lastName = Console.ReadLine();
            Console.Write("Input your year of birth:");
            string year = Console.ReadLine();

            string myInfo = firstName + " " + lastName + " " + year;
            Console.WriteLine(myInfo);

            // Q5:
            var numbers = new string[10];
            Console.Write("element - 0: ");
            numbers[0] = Console.ReadLine();
            Console.Write("element - 1: ");
            numbers[1] = Console.ReadLine();
            Console.Write("element - 2: ");
            numbers[2] = Console.ReadLine();
            Console.Write("element - 3: ");
            numbers[3] = Console.ReadLine();
            Console.Write("element - 4: ");
            numbers[4] = Console.ReadLine();
            Console.Write("element - 5: ");
            numbers[5] = Console.ReadLine();
            Console.Write("element - 6: ");
            numbers[6] = Console.ReadLine();
            Console.Write("element - 7: ");
            numbers[7] = Console.ReadLine();
            Console.Write("element - 8: ");
            numbers[8] = Console.ReadLine();
            Console.Write("element - 9: ");
            numbers[9] = Console.ReadLine();
            string elementsOfArray = numbers[0] + " " + numbers[1] + " " +
                                        numbers[2] + " " + numbers[3] + " " +
                                        numbers[4] + " " + numbers[5] + " " +
                                        numbers[6] + " " + numbers[7] + " " +
                                        numbers[8] + " " + numbers[9] + " ";

            Console.Write("Elements in array are: " + elementsOfArray);


            // Q6:
            var num = new int[3];
            Console.Write("Input num1: ");
            num[0]= Convert.ToInt32(Console.ReadLine());
            Console.Write("Input num2: ");
            num[1] =Convert.ToInt32(Console.ReadLine());
            Console.Write("Input num3: ");
            num[2]=Convert.ToInt32(Console.ReadLine());

            int result=num[0]+num[1]+num[2];
            Console.WriteLine("Sum of all elements stored in the array is : "+result);

        }
    }
}
