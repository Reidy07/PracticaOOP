using PracticaOOP.Clases;

class Program
{
    static void Main(string[] args)
    {

        // aqui se crea la informacion de la clase persona y se ejecuta
        Console.WriteLine("______________________:)___________________________________");
        Console.WriteLine("Informacion de la persona");
        Persona persona = new Persona("Juan Pérez", 30, "Madrid");
        persona.Mostrar_Inforamcion();
        Console.WriteLine($"Edad en años: {persona.CalcularEdadEnAnios()}");


        // Aqui se crea la informacion de un estudiante y se muestra
        Console.WriteLine("_______________________:<__________________________________");
        Console.WriteLine("Informacion de el etudiante");
        Estudiante estudiante = new Estudiante("María López", 22, "Barcelona", "Ingeniería Informática", "A12345");
        estudiante.Mostrar_Informacion_Completa();



        // Crear objetos de figuras y calcular sus áreas
        Console.WriteLine("______________________:>___________________________________");
        Console.WriteLine("Area calculada");
        Figura rectangulo = new Rectangulo(5.0, 3.0);
        Figura circulo = new Circulo(4.0);
        Figura triangulo = new Triangulo(6.0, 4.0);

        Console.WriteLine($"\nÁrea del rectángulo: {rectangulo.CalcularArea()}");
        Console.WriteLine($"Área del círculo: {circulo.CalcularArea()}");
        Console.WriteLine($"Área del triángulo: {triangulo.CalcularArea()}");
    }
}
