// See https://aka.ms/new-console-template for more information
/*clases*/
// var rect= new Rectangulo();
// rect.Base = 20;
// rect.Altura = 40;
// Console.WriteLine($"El Area es : {rect.Area()}");
// Console.WriteLine($"el Perimetro es: {rect.Perimetro()}");
/*End Clases*/

var cuadr= new Cuadrado();
cuadr.Base = 20;
cuadr.Altura = 40;
Console.WriteLine($"El Area es : {cuadr.Area()}");
Console.WriteLine($"El Perimetro es: {cuadr.Perimetro()}");
Console.WriteLine($"El lado es: {cuadr.lado}");
class Rectangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }
     public double Area() => Base * Altura;
     public double Perimetro() => 2 * Base + 2 * Altura;
}

class Cuadrado : Rectangulo
{
    public double lado
    {
        set {Base = value; Altura = value;}
        get {return Base;}
    }
}
