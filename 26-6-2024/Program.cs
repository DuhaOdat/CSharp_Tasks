using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_6_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q1:
            int[] numbers = new int[2];
            Console.Write("write a number:");
            numbers[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("write a number:");
            numbers[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" the smaller number is {numbers.Min()}");

            //Q2:
            Console.Write("write a number positive or negative: ");
            int num = Convert.ToInt32(Console.ReadLine());
            char[] signs = { '-', '0', '+' };

            char signChar = signs[Math.Sign(num) + 1];
            Console.WriteLine($"The sign is {signChar}");

            // Q3: ascending

            int[] arrayNum = new int[3];
            Console.Write("Write number1: ");
            arrayNum[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write number2: ");
            arrayNum[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write number3: ");
            arrayNum[2] = Convert.ToInt32(Console.ReadLine());
            Array.Sort(arrayNum);
            Console.WriteLine(arrayNum[0]);
            Console.WriteLine(arrayNum[1]);
            Console.WriteLine(arrayNum[2]);


            // Q3: descending
            int[] arrayNum = new int[3];
            Console.Write("Write number1: ");
            arrayNum[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write number2: ");
            arrayNum[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write number3: ");
            arrayNum[2] = Convert.ToInt32(Console.ReadLine());
            Array.Sort(arrayNum);
            Array.Reverse(arrayNum);
            Console.WriteLine(arrayNum[0]);
            Console.WriteLine(arrayNum[1]);
            Console.WriteLine(arrayNum[2]);


            // Q4:
            int[] numbersOfArray = new int[5];
            Console.Write("write a number:");
            numbersOfArray[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("write a number:");
            numbersOfArray[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("write a number:");
            numbersOfArray[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("write a number:");
            numbersOfArray[3] = Convert.ToInt32(Console.ReadLine());
            Console.Write("write a number:");
            numbersOfArray[4] = Convert.ToInt32(Console.ReadLine());
            Array.Sort(numbersOfArray);
            Console.WriteLine($" the Largest number is {numbersOfArray.Max()}");

            //Q5:
            Console.Write("Input kilometer per hour : ");
            double kmPerHour = Convert.ToDouble(Console.ReadLine());
            double milePerHour = kmPerHour * 0.621371;
            Console.WriteLine($" {milePerHour} miles per hour");

            // Q6:
            Console.Write("Input hours: ");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input minutes: ");
            int minute = Convert.ToInt32(Console.ReadLine());
            int total = (hour * 60) + minute;
            Console.WriteLine($"Total: {total} minutes .");

            //Q7:
            Console.Write("Input minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            int hour = (minutes / 60);
            int minuteOfHour = hour * 60;
            int minute = minutes - minuteOfHour;
            Console.WriteLine($" {hour} Hours, {minute} Minutes ");

            //Q8:
            string[] str = {"welcome to orang academy",
                            "this is your way to sucess",
                            "be proud to be apart of this journy",
                            "dont be shy to ask any thing  about any topic",
                            "its just seven months of hard word to achieve your google"

            };

            string sentence1=  str[0].Substring(0,7);
            Console.WriteLine($" sentence1: {sentence1} ");
            string sentence2 = str[1].Substring(0, 7);
            Console.WriteLine($" sentence2: {sentence2} ");
            string sentence3 = str[2].Substring(0, 7);
            Console.WriteLine($" sentence3: {sentence3} ");
            string sentence4 = str[3].Substring(0, 7);
            Console.WriteLine($" sentence4: {sentence4} ");
            string sentence5 = str[4].Substring(0, 7);
            Console.WriteLine($" sentence5: {sentence5} ");


        }
    }
}
