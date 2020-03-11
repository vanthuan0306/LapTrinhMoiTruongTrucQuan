using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            float a,x ;
            
            Console.WriteLine("Nhap Goc Tinh:");
           x= Convert.ToInt32(Console.ReadLine());
            a = x * (float)Math.PI/180;
            float Sin = (float) Math.Sin(a);
            float Cos = (float)Math.Cos(a);
            float Tan = (float)Math.Tan(a);
            float CogTan = 1 / Tan;
            Console.WriteLine("Sin<" + a + ">="+Sin+ "\nCos<" + a + ">="+Cos+ "\nTan<" + a + ">="+Tan+ "\nCogTan<" + a + ">="+CogTan);
            Console.ReadLine();
        }
    }
}
