// See https://aka.ms/new-console-template for more information
Console.WriteLine(" ** PROMEDIO DE NOTAS ** ");
Console.WriteLine(" ");

string alumno;
int nota1, nota2, nota3;
double promedio;

Console.WriteLine("Ingrese el nombre del alumno: ");
alumno=Console.ReadLine();

Console.WriteLine("Ingrese la nota 1 del alumno  "+ alumno+": ");
nota1=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la nota 2del alumno " + alumno+": ");
nota2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la nota 3 del alumno "+ alumno+": ");
nota3 = int.Parse(Console.ReadLine());

promedio = (nota1 + nota2 + nota3) / 3.0;

Console.WriteLine("-------------------------------------------------");
Console.WriteLine("EL PROMEDIO: "+promedio.ToString("0.00"));

Console.ReadLine();
//E.G.U.U.
