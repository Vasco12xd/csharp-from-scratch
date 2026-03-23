// Clases

/* var rect = new Rectangulo();
rect.Base = 20;
rect.Altura = 40;
Console.WriteLine($"El area es: {rect.Area()}");
Console.WriteLine($"El Perimetro es: {rect.Perimetro()}");
 */

var cuadr = new Cuadrado();
cuadr.Base = 20;
cuadr.Altura = 40;
Console.WriteLine($"El area es: {cuadr.Area()}");
Console.WriteLine($"El Perimetro es: {cuadr.Perimetro()}");
Console.WriteLine($"El Lado es: {cuadr.Lado}");

class Rectangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }
    public double Area() => Base * Altura;
    public double Perimetro() => 2 * Base + 2 * Altura;
}

class Cuadrado : Rectangulo
{
    public double Lado
    {
        set { Base = value; Altura = value;}
        get { return Base;}
    }
};

