using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Polimorfismo2
{
    public class Video : Media
    {
        //Propiedades
        public String Codec { get; set; }
        public int Chapters { get; set; }
        public String[] Audio {  get; set; }
        public List<Subtitle> Subtitles { get; set; }

        //Constructor
        public Video(String name, int size, String extension, DateTime creationDate,
            Author author, int duration, String codec, int chapters, String[] audio, List<Subtitle> subtitles)
            : base(name,size, extension, creationDate, author, duration)
        {
            this.Codec = codec;
            this.Chapters = chapters;
            this.Audio = audio;
            this.Subtitles = subtitles;
        }

        //Metodos
        public override void Print()
        {
            base.Print(); //override parcial
            Console.WriteLine($"Codec: {this.Codec}");
            Console.WriteLine($"Chapters: {this.Chapters}");

            //pistas de audio
            if( this.Audio != null) //coleccion no debe de ser null
            {
                if( this.Audio.Length > 0) //solo si hay items
                {
                    Console.WriteLine("Audio tracks:");
                    foreach(String item in this.Audio)
                    {
                        if (item != null) Console.WriteLine($"\t-{item}");
                    }
                }
            }

            //subtitulos
            if( this.Subtitles != null)
            {
                if( this.Subtitles.Count > 0)
                {
                    Console.WriteLine("Subtitles:");
                    foreach(Subtitle item in this.Subtitles)
                    {
                        if(item != null) Console.WriteLine($"\t-{item.Language}");
                    }
                }
            }
        }
    }
}
