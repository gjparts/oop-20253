namespace _13_Polimorfismo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author aut1 = new Author("Gerardo", "califik.com", "");
            Author aut2 = new Author("Metallica", "", "");

            Document doc1 = new Document("Informe", 230400, "pdf", DateTime.Now, aut1, DateTime.Now, 2000);
            doc1.Print();

            DateTime fecha1 = new DateTime(2011, 12, 21);
            Audio au1 = new Audio("One", 5123123, "mp3", fecha1, aut2, 5, "Metallica", "...And Justice For All", 1988, 4);
            au1.Print();

            String[] pistas = { "Español", "Ingles", "Chino"};

            List<Subtitle> subtitulos = new List<Subtitle>();
            subtitulos.Add(new Subtitle("Español", null));
            subtitulos.Add(new Subtitle("Ingles", new Author("GNULA", "", "")));

            Video vid1 = new Video("Flow", 234567544, "mp4", DateTime.Now, aut1, 180, "H264", 5, pistas, subtitulos);
            vid1.Print();
        }
    }
}
