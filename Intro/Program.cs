namespace Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Please input your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");*/

            //ex1 
            //int a, b, sum = 0;
            //Console.Write("a = ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //b = Convert.ToInt32(Console.ReadLine());
            //sum = a + b;
            //Console.WriteLine("a+b = " + sum);

            //Console.WriteLine("a+b = {0}", sum);

            //Console.WriteLine("{0}+{1} = {2}", a, b, sum);

            //Console.WriteLine($"a+b = {sum} ");

            //ex2
            int number;
            List<int> numbers = new List<int>();

            do
            {
                Console.WriteLine("Insert the number: ");
                number = int.Parse(Console.ReadLine());

                numbers.Add(number);
            } while (number % 100 != 0);

            Console.WriteLine();

            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

        }
    }
}
