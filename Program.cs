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
            var promedio_semestre5 = 4.8;
            const string carrera = "Ingeniería en Sistemas Computacionales";
                        
            Console.WriteLine($"El protagonista de hoy se llama {nombre} tiene {edad} años,");
            Console.WriteLine($"es estudiante? {es_estudiante}, ");
            Console.WriteLine($"su fecha de nacimiento es {fecha_nacimiento}, ");
            Console.WriteLine($"su estatura es {estatura} metros, ");
            Console.WriteLine($"su peso es {peso} kg ");
            Console.WriteLine($"y su promedio del semestre 4 es {promedio_semestre4}.");
            Console.WriteLine($"y su promedio del semestre 5 es {promedio_semestre5}.");
            Console.WriteLine($"y su carrera es {carrera}.");

            // Casting implicito y explicito
            // Implicito
            int numero1 = 10;
            double numero2 = numero1; // Casting implicito. Este no da error porque 
            // un int puede ser convertido a double sin perder información.
            Console.WriteLine($"El valor de numero2 es: {numero2}"); 

            // Explicito
            double numero3 = 9.8;
            int numero4 = (int)numero3; // Casting explicito. Este puede dar error porque
            // un double puede perder información al ser convertido a int.  
            Console.WriteLine($"El valor de numero4 es: {numero4}");

            char letra = 'A';
            int codigoAscii = letra; // Casting implicito. No da error porque un char puede ser convertido a int sin perder información.
            Console.WriteLine($"El valor de codigoAscii es: {codigoAscii}");

            string texto = "123456";
            int numero5 = int.Parse(texto); // Casting explicito. Debe ser un string que contenga un número válido 
            // para poder convertirlo a int.
            // int.Parse() es un método que convierte un string a int.
            Console.WriteLine($"El valor de numero5 es: {numero5}");

            string textoDecimal = "99,83";
            double numero6 = double.Parse(textoDecimal); // Casting explicito. Debe ser un string que contenga un número válido
            // para poder convertirlo a double.
            // double.Parse() es un método que convierte un string a double.
            Console.WriteLine($"El valor de numero6 es: {numero6}");



        }
    }
}
