namespace ErrorsAndExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double nr1 = double.Parse(Console.ReadLine());
            //double nr2 = double.Parse(Console.ReadLine());

            //try
            //{
            //    double result = Divide(nr1, nr2);
            //    throw new ArgumentException("Error!!"); 
            //    Console.WriteLine(result);
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine("An error has occured : {0}", ex.Message); 
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("An error has occured : {0}", ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Finally clause!"); 
            //}

            var temperatureObj = new Temperature();
            temperatureObj.temp = 0;
            try
            {
                temperatureObj.DisplayTemp();
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        
        static double Divide(double a, double b)
        {
            return a / b;
        }

        // static double Divide(double a, double b) => a / b; 
    }
}
