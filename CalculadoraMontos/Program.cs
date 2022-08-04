// See https://aka.ms/new-console-template for more information
Console.WriteLine(" ** CALCULADORA DE MONTOS ** ");
Console.WriteLine(" ");

double precio, monto;
int cantidad;

Console.Write("Ingrese el precio del producto C$: ");
precio = double.Parse(Console.ReadLine());
Console.Write("Ingrese la cantidad seleccionada: ");
cantidad=int.Parse(Console.ReadLine());

monto = precio * cantidad;

Console.WriteLine("-----------------------------------------");
Console.WriteLine("MONTO A CANCELAR C$: "+monto.ToString("0.00"));

Console.ReadLine();
//Ernesto Gabriel Urcuyo Urcuyo.