namespace Wk2Assignment2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*************2.4 #1*****************
            int[] testData = { 2, 5, 8 };
            int sum = 0;
            foreach (int num in testData)
            {
                sum += num;
            }
            Console.WriteLine($"2.3 #1 output: {sum}");

            //*************2.4 #2*****************
            int[] testData2 = {25, 63, 10};
            int greatest = testData2[0];
            foreach (int num in testData2) 
            {
                if (num > greatest)
                {
                    greatest = num;
                }
            }
            Console.WriteLine($"2.3 #2 output: {greatest}");

            //*************2.4 #3*****************
            Console.WriteLine("******2.3 #3 Coordinate system*******");

        begin:
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
                goto begin;
            }

        }
    }
}
