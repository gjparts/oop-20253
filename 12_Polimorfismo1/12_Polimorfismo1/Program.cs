namespace _12_Polimorfismo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal("Hipopotamo", "Mamifero", 4, true);
            a1.Imprimir();
            a1.Hablar();

            Gato g1 = new Gato("Tinieblo", true, true);
            g1.Imprimir();
            g1.Hablar();
            g1.Ronronear();
        }
    }
}
