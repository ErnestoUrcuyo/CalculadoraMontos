// See https://aka.ms/new-console-template for more information
Console.WriteLine(" ** CAPITAL DE LA EMPRESA ** ");
Console.WriteLine(" ");

//Variables
double monto1, monto2, monto3, montotal;
double porc1, porc2, porc3;

//Entrada
Console.Write("Ingrese el monto del primer socio: C$");
monto1 = double.Parse(Console.ReadLine());
Console.Write("Ingrese el monto del segundo socio: C$");
monto2 = double.Parse(Console.ReadLine());
Console.Write("Ingrese el monto del tercer socio: C$");
monto3 = double.Parse(Console.ReadLine());

//Proceso
montotal = monto1 + monto2 + monto3;
porc1 = monto1 * 100 / montotal;
porc2 = monto2 * 100 / montotal;
porc3 = monto3 * 100 / montotal;
Console.WriteLine(" ");

//Salida
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("El monto total del capital formado es: " + montotal.ToString());
Console.WriteLine("Porcentaje del primer socio: " + porc1.ToString() + "%");
Console.WriteLine("Porcentaje del segundo socio: " + porc2.ToString() + "%");
Console.WriteLine("Porcentaje del tercer socio: " + porc3.ToString() + "%"); Console.WriteLine(" "+"\n ");

Console.WriteLine(" ** PRESIONE TECLA [enter] PARA FINALIZAR ** "); Console.ReadLine();

//E.G.U.U.


