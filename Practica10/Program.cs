namespace Practica10
{
    public class Program
    {
        static void Main(string[] args)
        {
            int user, bot;

            Console.WriteLine("PIEDRA PAPEL O TIJERA");
            Console.WriteLine("1.PIEDRA");
            Console.WriteLine("2.PAPEL");
            Console.WriteLine("3.TIJERA");

            user = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();

            Console.WriteLine("EL BOT A ELEGIDO:");

            bot = rnd.Next(1, 3);

            Console.WriteLine(bot);

            if (user == 1 && bot == 3 || user == 2 && bot == 1 || user == 3 && bot == 2)
            {
                Console.WriteLine("USTED GANA");
            }
            else if (user == bot)
            {
                Console.WriteLine("NADIE GANA");
            }
            else
            {
                Console.WriteLine("GANA EL BOT");
            }

            Console.ReadLine();
        }
    }
}
