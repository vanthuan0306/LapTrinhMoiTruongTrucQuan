using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Tinh Phuong Trinh Bac 2");
            float a, b,c,  delta;
            float PtBac2_1, PtBac2_2;
            Console.Write("Nhap a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap c:");
            c = Convert.ToInt32(Console.ReadLine());
            delta = (float)Math.Pow(b, 2) - (4 * a * c);
            if(delta <0)
            {
                Console.WriteLine("Phuong trinh vo nghiem.");
            }
            else if (delta > 0)
            {


                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c != 0)
                        {
                            Console.WriteLine("Phuong trinh vo nghiem");
                        }
                        else
                        {
                            Console.WriteLine("Phuong trinh vo so nghiem");
                        }
                    }
                    else if (c == 0)
                    {
                        if (b != 0)
                        {

                            Console.WriteLine("Phuong trinh co nghiem: 0");
                        }
                        else
                        {
                            Console.WriteLine("Phuong Trinh Vo So Nghiem");
                        }
                    }
                    else
                    {
                        PtBac2_1 = PtBac2_2 = -c / b;
                        Console.WriteLine("Phuong trinh co 1 nghiem: " + PtBac2_1);
                    }
                }
                else
                {
                    PtBac2_1 = (-b - (float)Math.Sqrt(delta)) / 2 * a;
                    PtBac2_2 = (-b + (float)Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine("Phuong trinh co nghiem x1= " +PtBac2_1+ "\nPhuong trinh co nghiem x1= "+PtBac2_2);
                }
            }
            else
            {
                PtBac2_1 = PtBac2_2 = -b / 2 * a;
                Console.WriteLine("Phuong trinh co nghiem kep x1= x2 =" +PtBac2_2);
            }
            Console.ReadLine();
        }
    }
}
