using System;

namespace Method
{
    class Program
    {
        public static int Perimeter(int a, int b, int c)
        {
            return a + b + c;
        }

        public static double GetPow(double a, double b)
        {
            double z = Math.Pow(a, b);
            return z;
        }

        public static double Distance(double x1, double y1, double x2, double y2)
        {
            double z;
            double t = x2 - x1;
            double f = y2 - y1;
            z = Math.Sqrt(Math.Pow(t, 2) + Math.Pow(f, 2));
            Convert.ToDouble(z);
            return z;
        }


        public static int ChangeDigits(ref int a)
        {
            int r, des, ed;
            ed = a % 10;
            des = a / 10 % 10;
            r = ed * 10 + des;
            return r;

        }

        public static int BitwiseSum(int a, int b)
        {
            int sum,rez1,rez2,rez3;
            rez1 = (a / 10 % 10) + (b / 10 % 10);
            rez2 = (a % 10) + (b % 10);
            rez3 = rez2 % 10;
            sum = rez1 * 10 + rez3;
            return sum;
        }

        static void Main(string[] args)
        {


           //int x;
           //x = Perimeter(4, 6, 3);
           // Console.WriteLine(x);
           

            //double z;
            //double a, b;
            //double.TryParse(Console.ReadLine(), out a);
            //double.TryParse(Console.ReadLine(), out b);
            //z = GetPow(a,b);
            //Console.WriteLine(z);



            //double n = Distance(34, 67, 2, 6);
            //Console.WriteLine(n);



            //int a, i;
            //int.TryParse(Console.ReadLine(), out a);
            //i = ChangeDigits(ref a);
            //Console.WriteLine(i);



            //int x, y,o;
            //int.TryParse(Console.ReadLine(), out x);
            //int.TryParse(Console.ReadLine(), out y);
            //o = BitwiseSum(x, y);
            //Console.WriteLine(o);


            //for (int i=1;i<3;i++)
            //{
            //    switch(i)
            //    {
            //        default:
            //            Console.WriteLine($"i={i++}");
            //            break;

            //    }
            //}
            
            #region Questions
            //1.Tom
            //2.Sam
            //3.1
            //4.int128 float64 real
            //5.boolean
            //6.
            //7.20
            //8.
            //9.18
            //10.1
            //11.5
            //12.0
            //13.i=1
            //14.
            //15.2
            //16.
            //17.
            //18.
            //19.0
            //20.Display(1,2) Display(1,2,3)
            //21.
            //22.16
            //23.
            //24.252
            //25.Summer
            //26.8
               #endregion


                  }
    }
}
