// Conditionals
 
/*Console.WriteLine("Ingrese el primer número: ");
int num = int.Parse(Console.ReadLine());
if (num > 0 ) Console.WriteLine("Positivo");
else if ( num < 0 ) Console.WriteLine("Negativo");
else Console.WriteLine("Es cero"); */


//Operators
Console.WriteLine("Ingrese el primer número: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el Segundo número: ");
double b = double.Parse(Console.ReadLine());
const string Indeterminado = "Indeterminado";
Console.WriteLine($"Suma: {a+b}, resta: {a-b}, Multiplicado: {a*b}, División: {(b!=0 ? a/b : Indeterminado)}");