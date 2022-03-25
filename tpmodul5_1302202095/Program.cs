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
            SayaTubeVideo a = new SayaTubeVideo("Tutorial Design By Contract – Angelina Yessyca Rahardjo Hadi");
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
            Contract.Requires(title != null);
            Contract.Requires(title.Length < 100);

            this.title = title;
            Random random = new Random();
            id = random.Next(0, 100000);
            playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            try
            {
                if (count >= 10000000) throw new Exception("Input penambahan play count maksimal 10.000.000");
                playCount = playCount + count;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public void PrintVideoDetails()
        {
            Console.WriteLine(id);
            Console.WriteLine(title);
            Console.WriteLine(playCount);

        }
    }
}

