namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dati un numar real:");
            double numar1 = double.Parse(Console.ReadLine());
            Console.Write("Dati al doilea numar real:");
            double numar2 = double.Parse(Console.ReadLine());

            Console.Write("Alegeti o operatie(+, -, *, /) : ");
            char operatie = char.Parse(Console.ReadLine());

            Calculator calculator = new Calculator();
            double rezultat = calculator.Calculate(numar1, numar2, operatie);
            Console.WriteLine("Rezultatul este: " + rezultat);
        }
    }
}
