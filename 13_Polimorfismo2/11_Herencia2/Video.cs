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
    }
}
