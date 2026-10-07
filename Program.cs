using System; 

namespace MiPrimeraClase
{
    class Program
    {
        static void Main()
        {
            int numero=5;
            for (int i=1; i<=12; i++)
            {
                int resultado=numero*i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }  
            
        }
    }
}
