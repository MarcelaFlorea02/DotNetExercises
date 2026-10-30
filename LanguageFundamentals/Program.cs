namespace LanguageFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ex1 - swap
            //Console.Write("Dati a=");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Dati b=");
            //int b = int.Parse(Console.ReadLine());


            //Console.WriteLine("Valoarea lui a inainte de interschimbare este:" + a);
            //Console.WriteLine("Valoarea lui b inainte de interschimbare este:" + b);

            //var result = Swap(a, b);

            //Console.WriteLine("Valoarea primului numar dupa de interschimbare este: " + result.Item1);
            //Console.WriteLine("Valoarea celui de-al doilea numar dupa de interschimbare este:" + result.Item2);

            //ex2 - ec gr 1
            Console.Write("Dati a=");
            int a = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("a nu poate fi 0!");
                Console.Write("Dati a=");
                a = int.Parse(Console.ReadLine());
            }

            Console.Write("Dati b=");
            int b = int.Parse(Console.ReadLine());

            int x = -b / a;

            Console.WriteLine("Solutia ecuatiei este : " + x);

            Console.WriteLine("Solutia ecuatiei {0}*x+{1}=0 este : x={2}", a, b, x);
        }

        public static (int, int) Swap(int nr1, int nr2)
        {
            int aux;
            aux = nr1;
            nr1 = nr2;
            nr2 = aux;
            return (nr1, nr2);
        }
    }
}
