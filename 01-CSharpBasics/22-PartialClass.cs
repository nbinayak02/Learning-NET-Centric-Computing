using System;
namespace PartialClass{
    public partial class Song{
        private string songname;
        private string singer;

        public Song(string songname, string singer){
            this.songname = songname;
            this.singer = singer;
        }
    }

   public partial class Song{
        public void PrintSong(){
            Console.WriteLine("Song: {0} Singer: {1}",songname,singer);
        }
    }

    class Program{
        public static void Main(){
        Song s = new Song("Rukum Maikot","SD Yogi");
        s.PrintSong();
        }


    }
}

