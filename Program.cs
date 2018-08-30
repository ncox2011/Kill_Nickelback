using System;
using System.Collections.Generic;

namespace Kill_Nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string band, string song)> goodSongs = new List<(string band, string song)>();
            HashSet<(string band, string song)> allSongs = new HashSet<(string band, string song)>(){
                {("Jimmy Eat World", "Hear you me")},
                {("Nickelback", "How you Remind ME")},
                {("Nickelback", "Photograph")},
                {("Nickelback", "Far Away")},
                {("Ben Howard", "I Forget Where We Were")},
                {("Erick Baker", "Stay Awhile")},
                {("The XX", "Dare You")},
                {("Banks", "Crowded Places")},
                {("Leon Bridges", "Beyond")}
            };

            foreach ((string band, string song) song in allSongs)
            {
                if(song.band != "Nickelback"){
                    goodSongs.Add((song.band, song.song));
                }
            }
            foreach ((string band, string song) song in goodSongs)
            {
                Console.WriteLine($"{song.band} sings the song {song.song} and it is good music!!");
            }
        }
    }
}
