using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, ChuVi, DienTich;
            Console.WriteLine("Nhap chieu dai 3 canh:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a ==0 || b==0|| c==0)
            {
                Console.WriteLine("Khong tao thanh tam giac");
            }
            else
            {
                ChuVi = a + b + c;
                float p = ChuVi / 2;
                DienTich = (float)Math.Sqrt(p * (p - a)*(p-b)*(p-c));
                Console.WriteLine("Chu vi hinh:" + ChuVi + "\nDien tich hinh: " + DienTich);
                Console.ReadLine();
            }
        }
    }
}
