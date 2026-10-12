using System; 

namespace MiPrimerClase
{
    class Program
    {
        static void Main()
        {
            // Tipos de variables

            string nombre= "Levi Joel";
            int edad=36;
            bool es_estudiante=true;
            DateTime fecha_nacimiento= DateTime.Now;
            float estatura = 1.70f;
            decimal peso = 70.1m;
            double promedio_semestre4 = 4.9;
                        
            Console.WriteLine($"El estudiante {nombre} tiene {edad} años,");
            Console.WriteLine($"su fecha de nacimiento es {fecha_nacimiento}, ");
            Console.WriteLine($"su estatura es {estatura} metros, ");
            Console.WriteLine($"su peso es {peso} kg ");
            Console.WriteLine($"y su promedio del semestre 4 es {promedio_semestre4}.");

        }
    }
}
