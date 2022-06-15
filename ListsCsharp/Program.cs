using System;

namespace ListsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] food = new string[10];

            food[0] = "pizza";
            food[1] = "sandwich";
            food[2] = "pasta";
            food[3] = "tacos";
            food[4] = "steak";
            food[5] = "pork chops";
            food[6] = "crab legs";
            food[7] = "salmon";
            food[8] = "cheeseburger";
            food[9] = "green beans";

            foreach (String item in food)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();

        }
    }
}
