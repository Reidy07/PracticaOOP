using System;

namespace PracticaOOP.Clases
{
    public class Estudiante : Persona
    {
        public string Carrera { get; set; }
        public string Matricula { get; set; }

        public Estudiante(string nombre, int edad, string ciudad, string carrera, string matricula) : base(nombre, edad, ciudad)
        {

            Carrera = carrera;
            Matricula = matricula;
        }
        public void Mostrar_Informacion_Completa()
        {
            Mostrar_Inforamcion();
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Matricula: {Matricula}");
        }
    }
}

