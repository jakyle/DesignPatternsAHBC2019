using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //  DESIGN PATTERNS
            // =====================
            //
            //  Factory Method (or just Factory)
            // have a factory class create the derived class for you, think of what a factory does, it creates objects for you.

            var dogFactory = new DogFactory();

            var dog = dogFactory.Create(DogType.Poodle);

            Console.WriteLine(dog.Bark());
            Console.WriteLine();

            // Singleton 
            // Purpose: have a single instance of an objct in memory, great if you want a single source of truth, and or you ONLY want
            // one instance of an object into memory. now a days, this is a popular one to have around.

            var appOptions = AppOptions.Instance;

            appOptions.ApplicationOwner = "James";
            appOptions.InCloud = false;

            var appOptionsTwo = AppOptions.Instance;

            Console.WriteLine(appOptionsTwo.ApplicationOwner);
            Console.WriteLine();

            // Fluent Builder
            // Purpose: Another common Dotnet Creation pattern, for building out your object

            var carBuilder = new CarBuilder();

            var car = carBuilder.Add4WheelDrive()
                .AddConvertable()
                .AddWarrinty(5)
                .AddOwner("Jimmy")
                .Build();

            Console.WriteLine(car.Owner);
            Console.WriteLine(car.WarrintyInYears);

            Console.ReadLine();
        }
    }
}
