using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientProxy_P4_20190140015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();
            double hasilTambah = obj.Tambah(1,2);
            Console.WriteLine("1 + 2 = " + hasilTambah);
            double hasilKurang = obj.Kurang(3,2);
            Console.WriteLine("3 - 2 = "+ hasilKurang);
            double hasilKali = obj.Kali(2,2);
            Console.WriteLine("2 x 2 = " + hasilKali);
            double hasilBagi = obj.Bagi(2,2);
            Console.WriteLine("2 / 2 = "+ hasilBagi);

            ServiceReference1.Koordinat a = new ServiceReference1.Koordinat();
            ServiceReference1.Koordinat b = new ServiceReference1.Koordinat();

            a.x = 7;
            a.y = 8;

            b.x= 5;
            b.y= 6;

            double selisihX = a.x - b.x;
            double selisihY = a.y - b.y;

            double jarak = Math.Sqrt(Math.Pow(selisihX,2) + Math.Pow(selisihY,2));
            Console.WriteLine("Hasil Koordinat "+jarak);
            Console.ReadLine();
        }
    }
}
