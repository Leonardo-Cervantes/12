namespace Practica05
{
    public class Program
    {
        static void Main(string[] args)
        {
            int dia; 

            Console.WriteLine("SELECCIONA UN NUMERO (1-7)");
            

            dia = Convert.ToInt32(Console.ReadLine());

            if (dia == 1)
            {
                Console.WriteLine("ES LUNES");
            } else if (dia == 2)
            {
                Console.WriteLine("ES MARTES");
            } else if (dia == 3)
            {
                Console.WriteLine("ES MIERCOLES");
            } else if (dia == 4)
            {
                Console.WriteLine("ES JUEVES");
            } else if (dia == 5)
            {
                Console.WriteLine("ES VIERNES");
            } else if (dia == 6)
            {
                Console.WriteLine("ES SABADO");
            } else if (dia == 7)
            {
                Console.WriteLine("ES DOMINGO");
            } else
            {
                Console.WriteLine("ERROR");
            }

            Console.ReadLine();

        }
    }
}
