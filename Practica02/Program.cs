namespace Practica02
{
    public class Program
    {
        static void Main()
        {

            int month;

            Console.WriteLine("ESCRIBE EL MES SI");
            Console.WriteLine("1.ENERO");
            Console.WriteLine("2.FEBRERO");
            Console.WriteLine("3.MARZO");
            Console.WriteLine("4.ABRIL");
            Console.WriteLine("5.MAYO");
            Console.WriteLine("6.JUNIO");
            Console.WriteLine("7.JULIO");
            Console.WriteLine("8.AGOSTO");
            Console.WriteLine("9.SEPTIEMBRE");
            Console.WriteLine("10.OCTUBRE");
            Console.WriteLine("11.NOVIEMBRE");
            Console.WriteLine("12.DICIEMBRE");

            month = Convert.ToInt32(Console.ReadLine());

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                Console.WriteLine("TIENE 31 DIAS");
            }
            else if (month == 2) 
            {

                Console.WriteLine("TIENE 28 DIAS");
            } 
            else 
            {
                Console.WriteLine("TIENE 30 DIAS");
            }

            Console.ReadLine();
        }
    }
}
