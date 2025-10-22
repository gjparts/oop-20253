namespace _09_Multiplicidad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Barrio bar1 = new Barrio("Villas del Sol", "Oeste", "12345");
                Barrio bar2 = new Barrio("Quinta San Miguel", "Choloma", "11111");

                Direccion dir1 = new Direccion(bar1);
                dir1.Calle = "Principal";
                dir1.Avenida = "5";
                dir1.Casa = "1033";

                Empresa e1 = new Empresa("Sistemas 2G", new Direccion(bar2), "12345678");
                //Note que la direccion de e1 se hizo como objeto de un solo uso

                Persona per1 = new Persona("1234123412345", "Gerardo Portillo", "9999-9999");
                per1.Direccion = dir1;
                per1.EmpresaLabora = e1;
                per1.Imprimir();

                Persona per2 = new Persona("11111111111","Filomeno Colinas","no tiene");
                per2.Imprimir();

                Persona per3 = new Persona("77777777","Estebancito Maravilla","56781234");
                
                //la direccion de per3 va a ser un objeto de un solo uso, y el barrio de esa
                //direccion tambien sera un objeto de un solo uso
                per3.Direccion = new Direccion(new Barrio("Barrio Lempira","Centro","1234"));
                //la Direccion de per3 como es un objeto de un solo uso se accede
                //a ella a traves de su ruta:
                per3.Direccion.Calle = "10";
                per3.Direccion.Avenida = "3";
                per3.Direccion.Casa = "Junto al pajaro azul";

                //La empresa donde trabaja tambien la vamos a poner como variable de un uso
                per3.EmpresaLabora = new Empresa("Pricesmart", new Direccion(new Barrio("Jardines", "Oeste", "")), "777");
                per3.EmpresaLabora.Direccion.Calle = "Bulevard UNAH";
                per3.EmpresaLabora.Direccion.Avenida = "Ave el playon";

                Mascota mas1 = new Mascota("Tinieblo","Gato");
                Mascota mas2 = new Mascota("Paquito", "Loro");
                Mascota[] arr1 = { mas1, null, mas2, new Mascota("Rambo","Perro") };
                per3.Mascotas = arr1;

                Diploma diplo1 = new Diploma("INFOP", "Reparacion de maquina de coser");
                Diploma diplo2 = new Diploma("INFOP", "Torno y fresa");
                List<Diploma> list1 = new List<Diploma>();
                list1.Add(diplo1);
                list1.Add(diplo2);
                list1.Add(new Diploma("UDEMY", "Curso de flutter"));
                per3.Diplomas = list1;

                per3.Imprimir();

                Persona per4 = new Persona("1111111111","Ludovico P. Luche","12341234");
                Persona per5 = new Persona("7777777777", "Federica P. Luche", "9876543");
                Persona per6 = new Persona("4234534556", "Ludoviquito P. Luche", "");
                Persona per7 = new Persona("1231231313", "Junior P. Luche", "");
                Persona per8 = new Persona("8765433445", "Bibi P. Luche", "");

                per4.Conyuge = per5;
                
                List<Persona> list2 = new List<Persona>();
                list2.Add(per6);
                list2.Add(per7);
                list2.Add(per8);

                per4.Hijos = list2;
                per4.Imprimir();

                //ahora la per5
                per5.Conyuge = per4;
                per5.Hijos = per4.Hijos; //es posible relacionar colecciones entre objetos
                per5.Imprimir();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
