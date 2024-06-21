using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
using System.Transactions;

namespace Classes_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car("volvo", "Red", 4); //normal car
            E ecar = new E("tesla", "White", 4); //electric car
            Bike bike = new Bike("Ninja", "Green", 3);

            //to see different output change ecar to mycar;
            if (mycar is E)
            {
                ecar.displayModel();
                ecar.Drive();
                Console.WriteLine("");

            }
            else if (mycar is Bike)
            {
                bike.PutHelmetOn();
                bike.Drive();
                bike.displayModel();
            }
            else
            {
                //both previous if need to be false to get here
                mycar.OpenRadio();
                mycar.OpenWindow();
                Console.WriteLine("");
                mycar.displayModel();
                mycar.Drive();
            }
            //and then update here accordingly to that vehicle
            mycar.GasSimulation();

            Console.ReadLine();
        }
    }
}
