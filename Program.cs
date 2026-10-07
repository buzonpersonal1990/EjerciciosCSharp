using System; 

namespace MiPrimerClase
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hola, por favor ingresa tu nombre:");
            string? nombre = Console.ReadLine();
            Console.WriteLine($"¡¿Hola {nombre}, bienvenido a este espacio de aprendizaje en C#!");

        }
    }
}