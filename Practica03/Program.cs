namespace Practica03
{
    public class Program
    {
        static void Main()
        {

            int salario, anos;
            double bono, totalsalario; 
            
            Console.WriteLine("INGRESA TU SALARIO");

            salario = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("INGRESA LOS AÑOS DE ANTIGUEDAD");

            anos = Convert.ToInt32 (Console.ReadLine());

            if (anos > 10)
            {
                bono = 0.10;

                totalsalario = (salario * bono) + salario;

                Console.WriteLine($"SU SALARIO ES {salario} MAS SU BONO DEL 10% {totalsalario}");
            }
            else if (anos >= 5 && anos <= 10)
            {
                bono = 0.07;

                totalsalario = (salario * bono) + salario;

                Console.WriteLine($"SU SALARIO ES {salario} MAS SU BONO DEL 7% {totalsalario}");

            } else
            {
                bono = 0.05;

                totalsalario = (salario * bono) + salario;

                Console.WriteLine($"SU SALARIO ES {salario} MAS SU BONO DEL 5% {totalsalario}");
            }

            Console.ReadLine();
            
        }
    }
}
