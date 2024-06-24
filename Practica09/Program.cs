namespace Practica09
{
    public class Program
    {
        static void Main()
        {
            int peso;
            string categoria = "";
            double imc,alturacm, altura; 

            Console.WriteLine("INGRESA TU ALTURA EN CENTIMETROS");

            altura = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("INGRESA TU PESO EN KG");

            peso = Convert.ToInt32 (Console.ReadLine());

            alturacm = altura / 100;

            imc = peso / (alturacm * alturacm);

            if (imc <= 18.5)
            {
                categoria = "BAJO PESO";
                Console.WriteLine($"SU CATEGORIA ES {categoria}");
            } else if (imc > 18.5 && imc <= 24.9)
            {
                categoria = "PESO NORMAL";
                Console.WriteLine($"SU CATEGORIA ES {categoria}");
            } else if (imc >= 25 && imc <= 29.9)
            {
                categoria = "SOBREPESO";
                Console.WriteLine($"SU CATEGORIA ES {categoria}");
            } else if (imc > 30)
            {
                categoria = "OBESIDAD";
                Console.WriteLine($"SU CATEGORIA ES {categoria}");
            }

            Console.ReadLine();
        }
    }
}
