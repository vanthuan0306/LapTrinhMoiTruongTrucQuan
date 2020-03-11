using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDienTich
{
    class Program
    {
        static void Main(string[] args)
        {
            int dai, rong, cvi = 0, dtich = 0;
            Console.Clear();
            Console.WriteLine("*****Tinh chu vi va dien tich*****");
            Console.Write("Nhap chieu dai: ");
            dai = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            rong = Convert.ToInt32(Console.ReadLine());
            cvi = (dai + rong) * 2;
            dtich = dai * rong;
            Console.WriteLine("Chu vi la: " + cvi);
            Console.WriteLine("Dien tich la: " + dtich);
            Console.ReadLine();

        }
    }
}
