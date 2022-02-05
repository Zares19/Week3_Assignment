using System;

namespace Week3_Assignment
{
    class Program
    {

        public class Car
        {
            public string make;
            public string model;
            public int mph;
        }

        static void Main(string[] args)
        {
            //Class object
            Car c = new Car();
            Car d = new Car();
            Car e = new Car();

            //Variable
            int speedLimit = 0;
            int demeritPoints = 0;

            //Gettin the users input
            Console.WriteLine("What was the speed limit? ");
            string speedLimitText = Console.ReadLine(); speedLimit = int.Parse(speedLimitText);
            Console.WriteLine("Enter the make of Car 1: ");
            c.make = Console.ReadLine();
            Console.WriteLine("Enter the model of Car 1: ");
            c.model = Console.ReadLine();
            Console.WriteLine("Enter the mph for Car 1: ");
            string cMphText = Console.ReadLine(); c.mph = int.Parse(cMphText);
            
            Console.WriteLine("Enter the make of Car 2: ");
            d.make = Console.ReadLine();
            Console.WriteLine("Enter the model of Car 2: ");
            d.model = Console.ReadLine();
            Console.WriteLine("Enter the mph for Car 2: ");
            string dMphText = Console.ReadLine(); d.mph = int.Parse(dMphText);

            Console.WriteLine("Enter the make of Car 3: ");
            e.make = Console.ReadLine();
            Console.WriteLine("Enter the model of Car 3: ");
            e.model = Console.ReadLine();
            Console.WriteLine("Enter the mph for Car 3: ");
            string eMphText = Console.ReadLine(); e.mph = int.Parse(eMphText);
            
            Console.WriteLine("Car 1:" + " " + c.make + " " + c.model + " " + c.mph + "mph" );

            if (c.mph < speedLimit)
            {
                Console.WriteLine("Ok. You are good to go");
            }
            else
            {
                int speedDifference = c.mph - speedLimit;

                for (int counter = 5; counter <= speedDifference; counter += 1)
                {
                    if (counter % 5 == 0)
                    {
                        demeritPoints++;
                    }
                }
            }
            Console.Write("Demerit Points :");
            Console.WriteLine(demeritPoints);

            if (demeritPoints >= 10)
            {
                Console.WriteLine("Your license is suspended");
            }

            Console.WriteLine("Car 2:" + " " + d.make + " " + d.model + " " + d.mph + "mph");

            if (d.mph < speedLimit)
            {
                Console.WriteLine("Ok. You are good to go");
            }
            else
            {
                int speedDifference = d.mph - speedLimit;

                for (int counter = 5; counter <= speedDifference; counter += 1)
                {
                    if (counter % 5 == 0)
                    {
                        demeritPoints++;
                    }
                }
            }
            Console.Write("Demerit Points :");
            Console.WriteLine(demeritPoints);

            if (demeritPoints >= 10)
            {
                Console.WriteLine("Your license is suspended");
            }

            Console.WriteLine("Car 3:" + " " + e.make+ " " + e.model+ " " + e.mph + "mph");

            if (e.mph < speedLimit)
            {
                Console.WriteLine("Ok. You are good to go");
            }
            else
            {
                int speedDifference = e.mph - speedLimit;

                for (int counter = 5; counter <= speedDifference; counter += 1)
                {
                    if (counter % 5 == 0)
                    {
                        demeritPoints++;
                    }
                }
            }
            Console.Write("Demerit Points :");
            Console.WriteLine(demeritPoints);

            if (demeritPoints >= 10)
            {
                Console.WriteLine("Your license is suspended");
            }

        }
    }
}
