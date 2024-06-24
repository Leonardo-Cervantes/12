namespace Practica04
{
    public class Program
    {
        static void Main()
        {
            int x, y, z;

            Console.WriteLine("INGRESA EL PRIMER LADO DEL TRIANGULO");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INGRESA EL SEGUNDO LADO DEL TRIANGULO");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INGRESA EL TERCER LADO DEL TRIANGULO");
            z = Convert.ToInt32(Console.ReadLine());

            if (x == y && y == z)
            {
                Console.WriteLine("ES UN TRIANGULO EQUILATERO");
            } 
            else if (x != y && y != z)
            {
                Console.WriteLine("ES UN TRIANGULO ESCALENO");
            } 
            else if ( x == y && y != z)
            {
                Console.WriteLine("ES UN TRIANGULO ISOCELES");
            }
            
            Console.ReadLine();
        }
    }
}
