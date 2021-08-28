using System;

namespace Datos
{    
        public class Persona
        {
            public Persona(string identificacion, string nombre, int edad, string sexo)
            {
                Identificacion = identificacion;
                Nombre = nombre;
                Edad = edad;
                Sexo = sexo;
            }

            public string Identificacion { get; set; }
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string Sexo { get; set; }
            public int Pulsacion { get; set; }

        }
    }

