using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task13._2
{
    internal class Program
    {
        public class Building
        {
            public string adress { get; set; }
            public float length { get; set; }
            public float width { get; set; }
            public float height { get; set; }

            public Building(string adr, float len, float wid, float hei)
            {
                this.adress = adr;
                this.length = len;
                this.width = wid;
                this.height = hei;
            }
            public void Print()
            {
                Console.WriteLine($"Здание по адресу: {this.adress}\nДлина: {this.length}\nШирина: {this.width}\nВысота: {this.height}");
            }
        }
        sealed class MultiBulding : Building
        {
            public int storeys { get; set; }
            public MultiBulding(string adr, float len, float wid, float hei, int stor) : base(adr, len, wid, hei)
            {
                storeys = stor;
            }
            public void Print()
            {
                base.Print();
                Console.WriteLine($"Этажность: {this.storeys}");
            }
        }

        static void Main()
        {
            Console.WriteLine("Адрес: ");
            string adress = Console.ReadLine();

            Console.WriteLine("Длина: ");
            float length =float.Parse (Console.ReadLine());

            Console.WriteLine("Ширина: ");
            float width = float.Parse(Console.ReadLine());

            Console.WriteLine("Высота: ");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Этажность: ");
            int storeys = int.Parse(Console.ReadLine());

            Building building1 = new Building(adress, length, width, height);
            building1.Print();

            Console.WriteLine("Адрес многоэтажки: ");
            adress = Console.ReadLine();
            MultiBulding multiBulding1 = new MultiBulding(adress,length,width,height,storeys);
            
            Console.WriteLine();
            multiBulding1.Print();

            Console.ReadKey();
        }
    }
}
