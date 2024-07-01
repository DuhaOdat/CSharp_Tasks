using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_7_2024
{

    public class Car
    {
        //field
        private string make;
        private int year;
        private string type;
        private double price;
        private string model;
        private string palletNo;
        private string color;


        //proparities
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string PalletNo
        {
            get { return palletNo; }
            set { palletNo = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        //constractor

        public Car(string Make,int Year,string Type,double Price,string Model,string PalletNo ,string Color)
        {
            this.Make = Make;
            this.Year = Year;
            this.Type = Type;
            this.Price = Price;
            this.Model = Model;
            this.PalletNo = PalletNo;
            this.Color = Color;

            Console.WriteLine($"Car make is: {Make}, year is: {Year} ,type is: {Type}," +
                $"price is: {Price}, model is: {Model}, palletNo is: {PalletNo}, color is: {Color}");
        }

        public void Start()
        {
            Console.WriteLine($"Starting the Car !");
        }
        public void Stop()
        {
            Console.WriteLine($"Stopping the Car !");
        }

      
    }
    class BMW : Car
    {
        //constractor 
        public BMW(string Make, int Year, string Type, double Price, string Model, string PalletNo, string Color)
            : base(Make, Year, Type, Price, Model, PalletNo, Color)
        { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Car newCar = new Car("Toyota", 2021, "Sedan", 25000, "Camry", "12345", "Blue");
            newCar.Start();
            newCar.Stop();
            Console.WriteLine();
            BMW bmw = new BMW("BMW", 2022, "Coupe", 60000, "M4", "98765", "White");
            bmw.Start();
            bmw.Stop();
        }
    }
}
