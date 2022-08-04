// See https://aka.ms/new-console-template for more information
Console.WriteLine(" *** CONTROL DE VENTAS *** ");
Console.WriteLine(" ");

//Variables 
double ic, id, ipc;
int u;
Console.WriteLine(" ");

//Entrada
Console.Write("Ingrese el valor del producto: C$");
ic = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de unidades a comprar: ");
u = int.Parse(Console.ReadLine());
Console.WriteLine(" ");

//Proceso
id = ic * 0.11;
ipc = ic - id;

//Salida
Console.WriteLine("---------------------------------------");
Console.WriteLine("El importe con reducción: C$" + id.ToString());
Console.WriteLine("El importe total a pagar: C$" + ipc.ToString());
Console.WriteLine(" *** PRESIONE [enter] PARA FINALIZAR *** ");
Console.ReadLine();