namespace Practica08
{
    public class Program
    {
        static void Main()
        {
            int month; 

            Console.WriteLine("SELECCIONE UN MES DEL AÑO");
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

            switch (month)
            {
                case int n when (month == 1 || month == 2 || month == 3):
                    Console.WriteLine("ES PRIMAVERA");
                    break;

                case int n when (month == 4 || month == 5 || month == 6):
                    Console.WriteLine("ES VERANO");
                    break;
                case int n when (month == 7 || month == 8 || month == 9):
                    Console.WriteLine("ES OTOÑO");
                    break;

                case int n when (month == 10 || month == 11 || month == 12):
                    Console.WriteLine("ES INVIERNO");                    
                    break;

                case int n when (month > 12 || month < 0):
                    Console.WriteLine("ESE MES NO EXISTEN PELAO");
                    break;
            }

            Console.ReadLine();
            
        }
    }
}
