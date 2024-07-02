using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7_2024
{

    

    internal class Program
    {

        class Car
        {
            //proparities
            public int Make { get; set; }
            public int Year { get; set; }
            public string Type { get; set; }
            public double Price { get; set; }
            public int Model { get; set; }
            public int PalletNo { get; set; }
            public string Color { get; set; }

            //constractor
            public Car( int Make,int Year,string Type,double Price,int Model,int PalletNo,string color )
            { 
                this.Make = Make;
                this.Year = Year;
                this.Type = Type;
                this.Price = Price;
                this.Model = Model;
                this.PalletNo = PalletNo;
                this.Color = color;
            }

            //methods
            public void DisplayInfo(int make, int year)
            {
                Console.WriteLine($"Car info are :{make},{year}");
            }

            public void DisplayInfo(int make)
            {
                Console.WriteLine($"car make is :{make}");
            }


            public virtual void Display()
                
            {
                Console.WriteLine("Welcome Car");
            }


        }

         class BMW : Car
        {

            public BMW(int Make, int Year, string Type, double Price, int Model, int PalletNo, string color)
                :base( Make,  Year,  Type, Price, Model, PalletNo, color)
            {
                
            }
            public override void Display()
            {
                Console.WriteLine("Welcome BMW");
            }
        }


        static void Main(string[] args)
        {

            BMW bmw = new BMW(1999, 2002, "BMW", 1500.45, 2024, 123456, "red");
            bmw.Display();
            
        }
    }
}
