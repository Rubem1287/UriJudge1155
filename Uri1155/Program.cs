using System;
using System.Globalization;
namespace Uri1155
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double s;
            i = 0;
            s = 0;
            for(int c =1;c<=100;c++)
            {
                if(i==0)
                {
                    i = 1;
                    s =(double) 1.0 + 1.0 / 2.0;
                }
                if(c>=2)
                {
                    s = (double) s + 1.0 / c;
                }
            }

            Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
