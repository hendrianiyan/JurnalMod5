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
    class SayaTubeUser (String title)
    {
        Debug.Assert(title.Leght <=200,"panjang tidak title tidak kurang dari 200 karakter");
        Debug.Assert(title != null, "Judul tidak boleh Null");

        int.this playCount= checked(this.GetTotalVideoplayCount +1)
        int id;
        List<SayaTubeVideo> uploadedVideo;
        string Username;

        public SayaTubeUser(string profile)
        {
            this.Username = profile;
            Random generate = new Random();
            this.id = generate.Next(0, 100000);

        }

        public void GetTotalVideoplayCount()
        {
            int dataplayCount = 0;
            foreach (SayaTubeVideo video in uploadedVideo)
            {
                dataplayCount = dataplayCount + video.GetPlaycount();
            }
        }

        public void addVideo(SayaTubeVideo data)
        {
            uploadedVideo.Add(data);
        }


        public void printAllvideoplayCount()
        {

            for (int i = 0; i < uploadedVideo.Count; i++)
            {
                Console.WriteLine("username:" + Username);
                Console.WriteLine("video:" + (i + 1) + ":" + uploadedVideo[i]);
            }

        }







    }
}
