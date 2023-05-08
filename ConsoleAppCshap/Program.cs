using System;

namespace ConsoleAppCshap
{
    class Program
    {
        /*
          1. Tinh tong so nguyen tu 1 den n (n la dau vao) va hien thi ra man hinh
          2. Tinh tong cac so theo day so sau: 1 + 1/3 + 1/5 + 1/7 + .. +1/(2n+1)
          3. Tinh n! (dieu kieu 0!= 1, n! = n*(n-1)*(n-2)*..1 = Recursion

         */

        static void Main(string[] args)
        {
            
            int n = 10, m = 100, k = 250;
            Console.WriteLine("Tong hai so m va n la: " + Add(n,m));
            Console.WriteLine("Gia tri nho nhat trong 3 so la" + Min(n,m,k));

            double d = 1 / 2;
            Console.WriteLine(d);

            Console.WriteLine(new string('=', 50));
            //Input value from keyboard
            Console.Write("Nhap tham so a = ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap tham so b = ");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.Write("Nhap tham so c = ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            GiaiPhuongTrinhBacHai(a, b, c);


            Console.ReadLine();
        }


        /* */

       public static int Add(int a, int b)
        {
            int total = a + b;
            return total;
        }

        /*find min value*/
        public static int Min(int a, int b)
        {
           return a > b ? b : a; //conditional expression
        }
        public static int Min(int a, int b, int c)
        {
            return Min(Min(a, b), c);
        }
        public static int Max(int a, int b) => a > b ? a : b;

        /*giai phuong trinh bac 2*/

        public static void GiaiPhuongTrinhBacHai(int a, int b, int c)
        {
            int deltal = 0;
            double x1, x2;

            if(a==0 && b != 0)
            {
                Console.WriteLine("Phuong trinh co nghiep don x= " + (-c * 1.0 / b));
            }
            else
            {
                deltal = (int)Math.Pow(b, 2) - 4 * a * c;
                if (deltal > 0)
                {
                    x1 = Math.Round( -b + Math.Sqrt(deltal)*1.0 / (2 * a));
                    x2 = b + Math.Sqrt(deltal)*1.0  / (2 * a);
                    Console.Write("Phuong trinh co hai nghiep phan biet x1 = " + x1
                        + " x2 = " + x2 );
                }else if(deltal == 0)
                {
                    Console.WriteLine("Phuong trinh co nghiep kep x1=x2= "+ (Convert.ToDouble(-b) /(2*a)));
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }

            }

        }



    }
}
