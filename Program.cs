// Roberto Astudillo - Don Bosco
public class Estudiante
{

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public void Informacion()
    {
        Console.WriteLine($"Bienvenido: {Nombre} {Apellido} ");
    }

}

// Clase principal del programa

public class Program
{
    public static void Main()
    {
        Estudiante estudiante1 = new Estudiante();
        estudiante1.Nombre = "Roberto";
        estudiante1.Apellido = "Astudillo";
        estudiante1.Informacion();
        Estudiante estudiante2 = new Estudiante();
        estudiante2.Nombre = "Jordan";
        estudiante2.Apellido = "Laferte";
        estudiante2.Informacion();
    }
}
