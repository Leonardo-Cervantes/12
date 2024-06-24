namespace Practica01
{
    public class Program
    {
        static void Main()
        {
            int nota;
            string calificacion;

            Console.WriteLine("INGRESE LA CALIFICACION(1-100):");

            nota = Convert.ToInt32(Console.ReadLine());

            switch (nota)
            {
                case int n when n > 100:

                    Console.WriteLine("CALIFICACION INVALIDA");

                    break;

                case int n when (n >= 90 && n <= 100):

                    calificacion = "A";

                    Console.WriteLine($"SU CALIFICACION ES {calificacion}");
                    break;

                case int n when (n >= 80 && n <= 89):

                    calificacion = "B";

                    Console.WriteLine($"SU CALIFICACION ES {calificacion}");

                    break;

                case int n when (n >= 70 && n <= 79): 

                    calificacion = "C";

                    Console.WriteLine($"SU CALIFICACION ES {calificacion}");
                    
                    break;

                case int n when (n >= 60 && n <= 69):

                    calificacion = "D";

                    Console.WriteLine($"SU CALIFICACION ES {calificacion}");

                    break;

                case int n when n < 60: 

                    calificacion = "F";

                    Console.WriteLine($"SU CALIFICACION ES {calificacion}");

                    break;
            }

            Console.ReadKey();

        }
    }
}
