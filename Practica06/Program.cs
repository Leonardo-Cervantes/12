namespace Practica06
{
    public class Program
    {
        static void Main()
        {
            int edad;

            Console.WriteLine("INGRESA TU EDAD PARA SABER TU CATEGORIA");

            edad = Convert.ToInt32(Console.ReadLine());

            switch (edad)
            {
                case int e when e < 12:

                    Console.WriteLine("NIÑO");

                    break;
                case int e when e >= 12 && e <= 17:

                    Console.WriteLine("ADOLESCENTE");

                    break;
                case int e when e >= 18 && e <= 64:

                    Console.WriteLine("ADULTO");

                    break;
                case int e when e >= 65:

                    Console.WriteLine("PAL CEMENTERIO");

                    break;
            }

            Console.ReadLine();

        }
    }
}
