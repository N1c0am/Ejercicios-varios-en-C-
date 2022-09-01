// See https://aka.ms/new-console-template for more information

Console.WriteLine("*********TIPOS DE DATOS NÚMERICOS********");

System.SByte sb1 = 127;
sbyte sb2 = -128;
Console.WriteLine("1er Número tipo SByte:" + sb1);
Console.WriteLine("2do Número tipo SByte:" + sb2.ToString());

System.Int32 n1 = 1000000000;
int n2 = -1000000000;
Console.WriteLine("1er Número entero: " + n1.ToString());
Console.WriteLine("2do Número entero " + n2);

long l1 = 1000000000000000000;
Console.WriteLine("1er número long: " + l1);

float f1 = 9999999999999.44534533245345f;
Console.WriteLine("Número de tipo float: " + f1);

double d1 = 99999999999999999999999.9999999999999999999999;
Console.WriteLine("Número de tipo double: " + d1);


Console.WriteLine("----------------------------------------");

Console.WriteLine("*********TIPOS DE DATOS DE TEXTO********");

char c1 = 'z';
Console.WriteLine("Char: " + c1);

string s1 = "Hola a los 100 amigos";
Console.WriteLine("String: " + s1);

var v1 = "Hola";
var v2 = 70;
Console.WriteLine("Var :" + v1);
Console.WriteLine("Var: " + v2);


Console.WriteLine("----------------------------------------");
Console.WriteLine("*********TIPOS DE DATOS BOOLEANOS********");

bool b1 = true;
bool b2 = false;
Console.WriteLine("Booleano: " + b1);
Console.WriteLine("Booleano: " + b2);
