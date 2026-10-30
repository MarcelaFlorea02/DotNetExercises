namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1
            //string input;
            //int noA = 0, noD = 0, noS = 0;
            //Console.Write("Input the string:");
            //input = Console.ReadLine();
            //foreach (char c in input)
            //{
            //    if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            //        noA++;
            //    // noA = noA+1; 
            //    // noA +=1; 
            //    else if (c >= '0' && c <= '9')
            //        noD++;
            //    else
            //        noS++;
            //}
            //Console.WriteLine("No. of aplha=" + noA);
            //Console.WriteLine("No. of digits=" + noD);
            //Console.WriteLine("No. of specialChars=" + noS);

            //ex2
            //float distance, h, m, s, speed, t, speedkh, speedmh;
            //Console.Write("Input distance (meters):");
            //distance = float.Parse(Console.ReadLine());
            //Console.Write("Input time (hours):");
            //h = float.Parse(Console.ReadLine());
            //Console.Write("Input time (minutes):");
            //m = float.Parse(Console.ReadLine());
            //Console.Write("Input time (seconds):");
            //s = float.Parse(Console.ReadLine());
            ////calculam timpul in secunde
            //t = h * 3600 + m * 60 + s;
            //speed = distance / t;
            //Console.WriteLine("Your speed in meters/seconds is:" + speed);
            //speedkh = (distance / 1000) / (t / 3600);
            //Console.WriteLine("Your speed in km/h is:" + speedkh);
            //speedmh = speedkh * 0.621371f;
            //Console.WriteLine("Your speed in miles/h is:" + speedmh);

            //ex3
            //string result = "";
            //int nr = int.Parse(Console.ReadLine());
            //int r;
            //if (nr == 0)
            //{
            //    result = "0";
            //}
            //else
            //{
            //    while (nr != 0)
            //    {
            //        r = nr % 2;
            //        result = r + result;
            //        nr = nr / 2;
            //    }
            //}
            //Console.WriteLine(result);
        }
    }
}
