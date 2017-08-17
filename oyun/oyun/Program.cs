using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oyun
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sorular = { "Türkiye'nin başkenti neresidir?","Malatya'nın en çok neyi meşhurdur" };
            string[,] secenekler ={{"Ankara","Malatya ","İstanbul","İzmir"},{"Kayısı","Elma","Armut","Çilek"}};
            int[] cevapSecenegi= { 1, 1 };
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0}, {1}", i + 1, sorular[i]);
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("{0},{1}", j + 1, secenekler[i, j]);
                }
                int cevap = Convert.ToInt32(Console.ReadLine());
                if(cevap==cevapSecenegi[i])
                {
                    Console.WriteLine("{0}. soruya verdiğiniz cevap doğrudur", i+1);
                }
                else
                {
                    Console.WriteLine("{0}. soruya verdiğiniz cevap yanlıştır", i + 1);
                }
                
            }
                    Console.ReadKey();
        }
    }
}
