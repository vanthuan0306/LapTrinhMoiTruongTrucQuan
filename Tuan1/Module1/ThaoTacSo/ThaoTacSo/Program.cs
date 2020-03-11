using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaoTacSo
{
    class Program
    {
        static void Main(string[] args)
        {
            int nSo1, nSo2, nTong = 0, nTich = 0, nHieu = 0;
            double nThuong = 0;
            Console.Clear();
            Console.Write("{0}", "Nhap So thu nhat: ");
            //read first number from user
            nSo1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap So thu hai: ");
            //read second number from user
            nSo2 = Convert.ToInt32(Console.ReadLine());
            nTong = nSo1 + nSo2;
            Console.WriteLine("Tong cua " + nSo1 + " va " + nSo2 + " la: " + nTong);
            nHieu = nSo1 - nSo2;
            Console.WriteLine("Hieu cua " + nSo1 + " va " + nSo2 + " la: " + nHieu);
            nTich = nSo1 * nSo2;
            Console.WriteLine("Tich cua " + nSo1 + " va " + nSo2 + " la: " + nTich);
            nThuong = nSo1 / nSo2;
            Console.WriteLine("Thuong cua " + nSo1 + " va " + nSo2 + " la: " + nThuong);
            Console.ReadLine();
        }
    }
}
