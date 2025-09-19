namespace _01_Fechas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Para manejar fechas vamos a usar el tipo de dato DateTime
            //el cual permite manejar fecha y hora.
            //A partir de .Net 6 existen tambien los tipos DateOnly y TimeOnly
            //que solo manejan fecha y hora respectivamente.
            DateTime hoy = DateTime.Now;
            Console.WriteLine(hoy);

            //las variable de tipo DateTime no aceptan valores null
            //hoy = null;

            //uso de TimeOnly: solo la hora
            TimeOnly hora = TimeOnly.FromDateTime(DateTime.Now);
            Console.WriteLine(hora);

            //uso de DateOnly: solo la fecha
            DateOnly Solofecha = DateOnly.FromDateTime(DateTime.Now);

            //establecer una fecha/hora fijas
            DateTime fecha1 = new DateTime(1982, 10, 15, 17, 33, 24);
            Console.WriteLine(fecha1);

            //fecha fija en DateOnly
            DateOnly fecha2 = new DateOnly(1983, 12, 21);
            Console.WriteLine(fecha2);

            //hora fija en TimeOnly
            TimeOnly hora2 = new TimeOnly(16, 45, 21);
            Console.WriteLine(hora2);

            //convertir fecha a String usando formatos predefinidos
            Console.WriteLine("Fecha corta: "+hoy.ToShortDateString());
            Console.WriteLine("Fecha larga: " + hoy.ToLongDateString());

            //convertir a formato personalizado
            Console.WriteLine("Fecha con formato: "+hoy.ToString("yyyy/MM/dd hh:mm:ss tt"));

            //Convertir String a Fecha
            String ff = "15/10/1982 14:33:25";
            DateTime fecha3 = DateTime.Parse(ff);
            Console.WriteLine(fecha3);

            //operaciones con fechas
            DateTime abc = DateTime.Now;

            //sumar 5 dias a una fecha
            abc = abc.AddDays(5);
            Console.WriteLine(abc);

            //restar 1 mes a abc
            abc = abc.AddMonths(-1);
            Console.WriteLine(abc);

            //extraer una parte de la fecha
            //extrar el mes actual
            int mesActual = DateTime.Now.Month;
            //extrar el dias actual
            int diaActual = DateTime.Now.Day;
            Console.WriteLine($"Mes actual: {mesActual}, dia actual: {diaActual}");

            //extraer año de la fecha abc
            Console.WriteLine($"Año de abc: {abc.Year}");

            /*Ejercicio:
            1) declare dos fechas
            2) la primer fecha sera el dia 1 del mes actual
            3) la segunda fecha sera el ultimo dia del mes actual
            4) imprima ambas fechas*/

            DateTime desde, hasta;
            //primer dia del mes
            desde = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            Console.WriteLine($"Primer dia del mes: {desde}");

            //ultimo dia del mes
            //forma 1:
            hasta = desde.AddMonths(1).AddDays(-1);
            Console.WriteLine($"Ultimo dia del mes: {hasta}");

            //forma 2:
            hasta = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            Console.WriteLine($"Ultimo dia del mes: {hasta}");

            //Importante: DaysInMonth permite en C# saber cuantos dias tiene un Mes/Año determinado
            //cuantos dias tiene Febrero de 2024?
            int diasFebrero2024 = DateTime.DaysInMonth(2024, 2);
            Console.WriteLine(diasFebrero2024);

            //Comparacion de fechas
            try
            {
                //leer dos fechas en la consola
                DateTime a, b;
                Console.Write("Digite la fecha A: ");
                a = DateTime.Parse( Console.ReadLine() );
                Console.Write("Digite la fecha B: ");
                b = DateTime.Parse(Console.ReadLine());

                if( a == b ) //en C# se puede comparar dos objetos usando ==
                    Console.WriteLine("A y B son iguales");
                else
                    Console.WriteLine("A y B son distintas");

                if (a > b)
                    Console.WriteLine("A es mayor que B");
                else
                    Console.WriteLine("B es mayor que A");

                //Obtener la diferencia en tiempo para dos fechas y horas
                TimeSpan diferencia;
                if (a > b)
                    diferencia = a - b;
                else
                    diferencia = b - a;

                Console.WriteLine("Dif. en dias entre A y B: "+diferencia.Days);
                Console.WriteLine("Dif. en segundos entre A y B: " + diferencia.TotalSeconds);
                Console.WriteLine("Dif. en minutos entre A y B: " + diferencia.TotalMinutes);
            }
            catch (Exception ex)
            {
                Console.WriteLine("No digito una fecha en el formato correcto: Año/Mes/Dia o Dia/Mes/Año");
            }
        }
    }
}
