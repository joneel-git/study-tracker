using Classes_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects
{

    public class Car
    {
        public string name = ""; //fields
        public string color = ""; //fields
        public int gasLevel = 0; //fields
        public Car(string n, string c, int g)
        {
            color = c;
            name = n;
            gasLevel = g;
        }
        public virtual void Drive()
        {
            ConsoleColor color = Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Motor_Engine go VrOOooom.. ", color);
        }
        public void OpenWindow()
        {
            ConsoleColor color = Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Car Window is open. \nAhh,... fresh Air!");
        }
        public void OpenRadio()
        {
            ConsoleColor color = Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("");
            Console.WriteLine("Open car radio,... \nJeee, Rock'n roll.");
        }
        public void displayModel()
        {
            ConsoleColor color = Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{this.color} {this.name}");
        }
        //-----------------------------------
        ConsoleColor defaultColor = Console.ForegroundColor; //storing default color
        public int GasSimulation()
        {

            int gasLevel = this.gasLevel;

            void Sleep()
            {
                ConsoleColor color = Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Sad to see you go.. ", color);
                Thread.Sleep(1000);
            }
            bool choice = true;
            do
            {
                Console.ForegroundColor = defaultColor; // Reset to default color
                Console.Write(" Do you want to continue? y/n (enter) ");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key == ConsoleKey.Enter)
                {
                    ConsoleColor color = Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nPlease enter either y/n ", color);
                    Console.Write("");
                    choice = true;
                }
                else if (info.Key == ConsoleKey.N)
                {
                    Sleep();
                    choice = false;
                    break;
                }
                else if (info.Key == ConsoleKey.Y)
                {
                    if (gasLevel == 0)
                    {

                        Console.WriteLine("\n We are out pf Gas ..S " + gasLevel);
                        choice = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n our Gas Level: " + gasLevel);
                        gasLevel--;
                        choice = true;
                        continue;
                    }
                }
                else
                {
                    choice = false;
                    break;
                }
            } while (choice);
            return gasLevel;
            //-----------------------------------
        }
    }
    public class E : Car
    {
        //sharing fields from Car using constructor
        public E(string n, string c, int g) : base(n, c, g)
        {
            color = c;
            name = n;
            gasLevel = g;
        }
        public override void Drive()
        {
            ConsoleColor color = Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Electric_Engine go SssssHhhh  not Vroom.. ", color);

        }
    }

    public class Bike : Car
    {
        public Bike(string n, string c, int g) : base(n, c, g)
        {
            color = c;
            name = n;
            gasLevel = g;
        }
        public void PutHelmetOn()
        {
            ConsoleColor color = Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Helmet feels nice on the head.. ", color);
        }
    }
}
//Iam using different sleep method so this one can be ignored
class Enviroment
{
    public void Sleep()
    {
        Console.WriteLine("\nGoodbye World Enviroment Exit...");
        Thread.Sleep(5000);
        Environment.Exit(0);
    }
}