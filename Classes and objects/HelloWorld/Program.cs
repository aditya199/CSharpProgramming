using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hello World, Learn tech with aditya");

            Dog objDogOfJohn = new Dog();

            objDogOfJohn.Name = "Bla";
            objDogOfJohn.Breed = "Chow Chow";
            objDogOfJohn.Age = 5;
            objDogOfJohn.Color = "White";
            objDogOfJohn.Owner = "John";

            Dog objDogOfJony = new Dog();

            objDogOfJony.Name = "GJ";
            objDogOfJony.Breed = "German Shephard";
            objDogOfJony.Age = 4;
            objDogOfJony.Color = "brown";
            objDogOfJony.Owner = "Jony";

            objDogOfJohn.GetInfo();
            objDogOfJony .GetInfo();

            Console.ReadLine();
        }
    }

   public class Dog
    {
        public string Name;
        public string Breed;
        public int Age;
        public string Color;
        public string Owner;

        public void GetInfo()
        {
            Console.WriteLine("Hello my name is: "+ Name +" , I am a "+ Breed +", my age is "+Age+", I am "+Color+" and owner is "+Owner+".");
        }
    }
}
