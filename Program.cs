using System;
using System.Diagnostics;

namespace modul5_1302200104
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class sayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public sayaTubeVideo(string title)
        {
            Random random = new Random();
            this.id = random.Next(0, 100000);
            this.playCount = 0;

            Debug.Assert(title.Length != 0, "title tidak boleh kosong");
            Debug.Assert(title.Length < 100, "title terlalu panjang");
        }
        public void IncreaseplayCount(int angka)
        {
            playCount = playCount + angka;
        }
        public int Playcount => playCount;

        public string GetTitle()
        {
            return title;
        }

        public void printVideoDetails()
        {
            Console.WriteLine("title: " + title);
            Console.WriteLine("id: " + id);
            Console.WriteLine("playCount:" + playCount);
        }
    }
    class SayaTubeUser
    {
        public int id;
        public string username;

    }
}