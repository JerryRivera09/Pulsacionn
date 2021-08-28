using System;
using Logica;
namespace Pulsacionn
{
    class Program
    {
        static void Main(string[] args)
        {
            string identificacion, nombre;
            int edad;
            string sexo;


            Console.WriteLine("CALCULAR PULSACION!!!");
            Console.WriteLine("DIGITE LA IDENTIFICACION: ");
            identificacion = Console.ReadLine();
            Console.WriteLine("DIGITE SU NOMBRE: ");
            nombre = Console.ReadLine();
            Console.WriteLine("DIGITE SU EDAD: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE SU SEXO: ");
            sexo = Console.ReadLine();

            Pulsacion pulsacion = new Pulsacion(identificacion, nombre, edad, sexo);
            pulsacion.calcularPulsacion();
            Console.WriteLine($"SEÑOR(A) {pulsacion.Persona.Nombre} DE ACUERDO CON SU EDAD {pulsacion.Persona.Edad} SU PULSACION ES {pulsacion.Persona.Pulsacion} ");

        }
    }
}
