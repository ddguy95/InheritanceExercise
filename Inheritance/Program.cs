using System;
using System.Collections.Specialized;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace Inheritance
{
    class Program
    {
        public static string name { get; private set; }

        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird OllieOwl = new Bird()
            {
                Name = "OllieOwl",
                Eyes = 2,
                Smell = true,
                Move = true,
                Feathers = true,
                Claws = 2,
                Beak = true,
                Wings = 2

            };

            Console.WriteLine($"{OllieOwl.Name} is a beautiful bird! He has {OllieOwl.Eyes}, {OllieOwl.Wings}, and can {OllieOwl.Move} quickly.");
            Console.WriteLine($"His {OllieOwl.Feathers} are long and amazing!  He has a {OllieOwl.Beak} and keen sense of {OllieOwl.Smell}"!);
            Console.WriteLine($"His {OllieOwl.Claws} can grip and tear through anything.");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile SammySnake = new Reptile()
            {
                Name = "Sammy Snake",
                Eyes = 2,
                Smell = true,
                Move = true,
                IsColdBloodied = true,
                UsesTongue = true,
                HasRoughSkin = true,
                IsDefensive = true
            };
                Console.WriteLine($"Hello my name is {SammySnake.Name}!");
                Console.WriteLine($"I have {SammySnake.Eyes} eyes.");
            Console.WriteLine($"Here are some interesting facts about me... {(SammySnake.IsColdBloodied?"I am cold blooded":"I am not cold blooded")}," +
                $" {SammySnake.UsesTongue}, " +
                $"{SammySnake.HasRoughSkin}, " +
                $"{SammySnake.IsDefensive}.");
                Console.WriteLine($"Can I {SammySnake.Move} and " +
                    $"{SammySnake.Smell}!");
            

        }
    }
}
