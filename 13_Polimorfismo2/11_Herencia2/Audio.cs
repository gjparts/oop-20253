using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Polimorfismo2
{
    public class Audio : Media
    {
        //Propiedades
        public String Artist { get; set; }
        public String Album { get; set; }
        public int Year { get; set; }
        public int Track {  get; set; }

        //Constructor
        public Audio(String name, int size, String extension, DateTime creationDate,
            Author author, int duration, String artist, String album, int year, int track)
            :base(name,size,extension,creationDate,author,duration)
        {
            this.Artist = artist;
            this.Album = album;
            this.Year = year;
            this.Track = track;
        }

        //Metodos
        public override void Print()
        {
            base.Print(); //override parcial
            Console.WriteLine($"Artist: {this.Artist}");
            Console.WriteLine($"Album: {this.Album}");
            Console.WriteLine($"Year: {this.Year}");
            Console.WriteLine($"Track: {this.Track}");
        }
    }
}
