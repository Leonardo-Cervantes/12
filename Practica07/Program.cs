namespace Practica07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int dia, duracion;

            double precioxmin,totalpagar; 

            Console.WriteLine("INGRESE EL DIA DE LA LLAMADA");
            Console.WriteLine("1.LUNES");
            Console.WriteLine("2.MARTES");
            Console.WriteLine("3.MIERCOLES");
            Console.WriteLine("4.JUEVES");
            Console.WriteLine("5.VIERNES");
            Console.WriteLine("6.SABADO");
            Console.WriteLine("DOMINGO");

            dia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("INGRESE LA DURACIÓN DE LA LLAMADA");

            duracion = Convert.ToInt32(Console.ReadLine());


            if (duracion < 10)
            {
                precioxmin = 0.05;

            }else
            {
                precioxmin = 0.08;
            }
            

            if (dia == 1 || dia == 2 || dia == 3 || dia == 4 || dia == 5)
            {
               
                totalpagar = duracion * precioxmin;
                Console.WriteLine($"EL TOTAL A PAGAR ES {totalpagar}");

            } else
            {
                precioxmin = 0.10;
                totalpagar = duracion * precioxmin;

                Console.WriteLine($"EL TOTAL A PAGAR ES {totalpagar}");
            }

            Console.ReadLine();

        }
    }
}
