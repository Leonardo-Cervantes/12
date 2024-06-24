namespace Practica11
{
    public class Program
    {
        static void Main()
        {

            // Escriba un programa en C# que solicite al usuario un número entero y responda si es un número primo o no.
            int x; 

            Console.WriteLine("Ingrese un número entero:");
            x = Convert.ToInt32(Console.ReadLine());

            bool esPrimo = true;

            if (x <= 1)
            {
                esPrimo = false; // Números menores o iguales a 1 no son primos
            }
            else if (x == 2)
            {
                esPrimo = true; // 2 es primo
            }
            else if (x % 2 == 0)
            {
                esPrimo = false; // Números pares distintos de 2 no son primos
            }
            else
            {
                // Verificar divisibilidad desde 3 hasta la raíz cuadrada de x
                for (int i = 3; i <= Math.Sqrt(x); i += 2)
                {
                    if (x % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }

                    //ITERANDO CADA VALOR DE X 

                    //for (int i = 2; i < x; i++)
                    //{
                    //    if (x % i == 0)
                    //    {
                    //        esPrimo = false;
                    //        break; // Si encontramos un divisor, x no es primo, podemos salir del bucle
                    //    }
                    //}

                }
            }

            if (esPrimo)
            {
                Console.WriteLine("ES PRIMO");
            }
            else
            {
                Console.WriteLine("NO ES PRIMO");
            }

            Console.ReadLine();
        }
    }
}
