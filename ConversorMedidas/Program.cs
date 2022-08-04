// See https://aka.ms/new-console-template for more information
Console.WriteLine(" ** CONVERSOR DE MEDIDAS ** ");
Console.WriteLine(" ");

//Variables
double mts, cmts, pulgadas, pies, yardas;

//Entrada
Console.Write("Ingrese los metros solicitados: ");
mts=double.Parse(Console.ReadLine());

//Procedimiento
cmts = mts * 100;
pulgadas = cmts / 2.54;
pies = pulgadas / 12;
yardas = pies / 3;
Console.WriteLine(" ");

//Salida
Console.WriteLine("-------------------------------------------------------------------------------------"); Console.WriteLine(" ");
Console.WriteLine("La converción de metros a centímetros es: " + cmts.ToString());
Console.WriteLine("La converción de metros a pulgadas es: " + pulgadas.ToString());
Console.WriteLine("La converción de metros a pies es: " + pies.ToString());
Console.WriteLine("La converción de metros a yardas es: "+ yardas.ToString()); Console.WriteLine(" ");

Console.WriteLine(" ** PRESIONE TECLA [ENTER] PARA FINALIZAR ** "); Console.ReadLine();
//E.G.U.U.