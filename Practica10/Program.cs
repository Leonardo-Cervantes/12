namespace Practica10
{
    public class Program
    {
        static void Main()
        {
            int user, bot;
            string usertag = "", bottag = "";

            Console.WriteLine("PIEDRA PAPEL O TIJERA");
            Console.WriteLine("1.PIEDRA");
            Console.WriteLine("2.PAPEL");
            Console.WriteLine("3.TIJERA");

            user = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();

            bot = rnd.Next(1, 3);

            Console.WriteLine(bot);

            if (user == 1)
            {
                usertag = "PIEDRA";
            } else if (user == 2)
            {
                usertag = "PAPEL";
            } else
            {
                usertag = "TIJERA";
            }

            if (bot == 1)
            {
                bottag = "PIEDRA";
            } else if (bot == 2)
            {
                bottag = "PAPEL";
            } else
            {
                bottag = "TIJERA";
            }

            Console.WriteLine($"EL USUARIO HA ELEGIDO: {usertag}");
            Console.WriteLine($"EL BOT A ELEGIDO: {bottag}");

            if (user == 1 && bot == 3 || user == 2 && bot == 1 || user == 3 && bot == 2)
            {

                Console.WriteLine("USTED GANA");
            }
            else if ((user > 3 || user < 1) || (bot > 3 || bot < 1))
            {
                Console.WriteLine("NUMERO NO PERMITIDO");
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
