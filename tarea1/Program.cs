using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            String pregunta_primer_numero = "Ingrese el primer número";
            String pregunta_segundo_numero = "Ingrese el segundo número";
            float primer_numero = 0, segundo_numero = 0;

            Console.WriteLine(pregunta_primer_numero);
            primer_numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(pregunta_segundo_numero);
            segundo_numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Primero, calculamos la suma:");
            float suma = primer_numero + segundo_numero;
            Console.WriteLine("El resultado de la resta es: " + suma);

            Console.WriteLine("Segundo, calculamos la resta:");
            float resta = primer_numero - segundo_numero;
            Console.WriteLine("El resultado de la resta es: " + resta);

            Console.WriteLine("Tercero, calculamos la multiplicación: ");
            float multiplica = primer_numero * segundo_numero;
            Console.WriteLine("El resultado de la multiplicación es: " + multiplica);

            Console.WriteLine("Cuarto y último, la división: ");
            float division = Convert.ToInt32(primer_numero) / segundo_numero;
            Console.WriteLine("El resultado de la división es: " + division);

            Console.Write("Presione cualquier tecla para salir :) ...");
            Console.ReadKey();
        }
    }
}
