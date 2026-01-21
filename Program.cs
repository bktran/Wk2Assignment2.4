namespace Wk2Assignment2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*************2.4 #1*****************
            Console.WriteLine("Enter numbers to find the sum:");
            List<int> input = new List<int>();
            start:
            while (input.Count < 3)
            {
                try
                {
                    input.Add(int.Parse(Console.ReadLine()));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " Input a valid number.");
                    goto start;
                }
            }
            int sum = 0;
            foreach (int num in input)
            {
                sum += num;
            }
            
            Console.WriteLine($"2.3 #1 Sum of input: {sum}");
            Console.WriteLine();

            //*************2.4 #2*****************
            Console.WriteLine("Enter numbers to the determine the largest number:");
            List<int> input2 = new List<int>();
        start2:
            while (input2.Count < 3)
            {
                try
                {
                    input2.Add(int.Parse(Console.ReadLine()));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " Input a valid number.");
                    goto start2;
                }
            }
            int greatest = input2[0];
            foreach (int num in input2)
            {
                if (num > greatest) 
                {
                    greatest = num;
                    
                }
            }
            Console.WriteLine($"The largest number is {greatest}");

            //*************2.4 #3*****************
            Console.WriteLine();
            Console.WriteLine("******2.3 #3 Coordinate system*******");

        start3:
            try
            {
                Console.WriteLine("Input value for X: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Input value for Y: ");
                int y = int.Parse(Console.ReadLine());

                if (x > 0 && y > 0)
                {
                    Console.WriteLine($"({x},{y}) is the first quadrant.");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine($"({x},{y}) is the second second quadrant.");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine($"({x},{y}) is the third quadran.");
                }
                else if (x > 0 && y > 0)
                {
                    Console.WriteLine($"({x},{y}) is the fourth quadrant.");
                }
                else if (x == 0 && y > 0)
                {
                    Console.WriteLine($"({x},{y}) is on the y-axis, between first and second quadrant.");
                }
                else if (x == 0 && y < 0)
                {
                    Console.WriteLine($"({x},{y}) is on the y-axis, between third and fourth quadrant.");
                }
                else if (x > 0 && y == 0)
                {
                    Console.WriteLine($"({x},{y}) is on the x-axis, between first and fourth quadrant.");
                }
                else if (x < 0 && y == 0)
                {
                    Console.WriteLine($"({x},{y}) is on the x-axis, between second and third quadrant.");
                }
                else
                {
                    Console.WriteLine($"({x},{y}) is in the center.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " Enter a number");
                goto start3;
            }

        }
    }
}
