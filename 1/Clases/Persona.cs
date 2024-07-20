using System;

namespace PracticaOOP.Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Ciudad { get; set; }
        public Persona(string nombre, int edad, string ciudad)
        {
            Nombre = nombre;
            Edad = edad;
            Ciudad = ciudad;
        }
        public void Mostrar_Inforamcion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad} Años");
            Console.WriteLine($"Ciudad: {Ciudad}");
        }        
        public int CalcularEdadEnAnios()
        {
            return Edad;
        }
    }
}
