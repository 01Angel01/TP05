using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace tpmodul5_1302202095
{
    internal class Program
    {
        static void Main(String[] args)
        {
            SayaTubeVideo a = new SayaTubeVideo("Judul video ");
            a.PrintVideoDetails();
            Console.WriteLine();
            a.IncreasePlayCount(5);
            a.PrintVideoDetails();
        }

    }
    public class SayaTubeVideo
    {

        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {

            this.title = title;
            Random random = new Random();
            id = random.Next(0, 100000);
            playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            playCount = playCount + count;
 
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine(id);
            Console.WriteLine(title);
            Console.WriteLine(playCount);
        }
    }
}

