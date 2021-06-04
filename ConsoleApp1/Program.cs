using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Name = "Ahmet";
            musteri1.Surname = "Mehmet";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);

        }
    }
}
