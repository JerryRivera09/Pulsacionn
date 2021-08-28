using System;
using Datos;
namespace Logica
{
    public class Pulsacion
    {

        public Persona Persona { get; set; }
        public Pulsacion(string nombre, string identificacion, int edad, string sexo)
        {
            Persona = new Persona(nombre, identificacion, edad, sexo);

        }
        public void calcularPulsacion()
        {
            if (Persona.Sexo.ToUpper().Equals("F"))
            {
                Persona.Pulsacion = (220 - Persona.Edad) / 10;
            }
            else if (Persona.Sexo.ToUpper().Equals("M"))
            {
                Persona.Pulsacion = (210 - Persona.Edad) / 10;
            }
            else
            {
                Persona.Pulsacion = 0;
            }
        }
    }
}
