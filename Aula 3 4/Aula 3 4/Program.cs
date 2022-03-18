// See https://aka.ms/new-console-template for more information

//Exercicio 1

Console.WriteLine("Bem-vindos ao C#");
Console.WriteLine("");


//Exercicio 2 

string nome = "alunos";
string msg = "Bem-vindos";
//1 METODO
Console.WriteLine("Caros {0} sejam {1} ao C#!",nome, msg);

//2 METODO
Console.WriteLine("Caros " + nome + " sejam " + msg + " ao C#!");
Console.WriteLine("");

//Exercicio 3

Console.WriteLine("Ana Ruivo".PadLeft(20) + "Porto".PadLeft(10));
Console.WriteLine("Joaquina Pinto".PadLeft(20) + "Aveiro".PadLeft(10));
Console.WriteLine("Miguel Costa".PadLeft(20) + "Braga".PadLeft(10));
Console.WriteLine("");

//Exercício 4

Console.WriteLine("Ana Ruivo".PadRight(20) + "Porto");
Console.WriteLine("Joaquina Pinto".PadRight(20) + "Aveiro");
Console.WriteLine("Miguel Costa".PadRight(20) + "Braga");
Console.WriteLine("");

//Exercicio 5

Console.WriteLine("Ana Ruivo \t Porto");
Console.WriteLine("Joaquina Pinto \t Aveiro");
Console.WriteLine("Miguel Costa \t Braga");
Console.WriteLine("");

//Exercicio 6

Console.WriteLine(4 + 3 * (15 - 2));
Console.WriteLine(40 / 9);
Console.WriteLine(40 % 3);
Console.WriteLine("");

//Exercicio 7

double x = Math.Pow(3,5);
Console.WriteLine(x);
double y = Math.Sqrt(125);
Console.WriteLine(y);
double z = Math.Ceiling(4.1);
Console.WriteLine(z);
double t =Math.Round(Math.Sin(30*Math.PI/180),2);
Console.WriteLine(t);
Console.WriteLine("");

//Exercício 8

bool a = 4 == 5;
Console.WriteLine(a);
bool b = 4 != 6;
Console.WriteLine(b);
bool c = 4 > 5;
Console.WriteLine(c);
bool d = 4 < 5 && 6 < 10;
Console.WriteLine(d);
bool e = 40 < 50 || 60 > 90;
Console.WriteLine(e);
bool f = !(40 < 50 || 60 > 90);
Console.WriteLine(f);
Console.WriteLine("");

//Exercicio 9

string str = "Bom dia,";
string str1 = " tudo bem?";
Console.WriteLine("O comprimento da string '{0}' é {1}", str, str.Length);
Console.WriteLine(str + str1);
Console.WriteLine(str.ToUpper());
Console.WriteLine(str.Substring(3));
Console.WriteLine(str.IndexOf("dia"));
Console.WriteLine(str.CompareTo(str1));
Console.WriteLine(str1.Trim());
Console.WriteLine("");

//Exercicio 10 

sbyte x1 = 34;
byte y1 = 250;
short z1 = 32000;
ushort var1 = 60000;
int var2 = 1000000012;
uint var3 = 3500000000;
long var4 = 1532333333334581239;
ulong var5 = 14532333333334581239;

Console.WriteLine(x1);
Console.WriteLine(y1);
Console.WriteLine(z1);
Console.WriteLine(var1);
Console.WriteLine(var2);
Console.WriteLine(var3);
Console.WriteLine(var4);
Console.WriteLine(var5);
Console.WriteLine("");


//Exercicio 11

float var6 = 345.3456;
double var7 = 6.89765432127865;
decimal var8 = 1234567897654300.14567896543;

Console.WriteLine(var6);
Console.WriteLine(var7);
Console.WriteLine(var8);
Console.WriteLine("");


//Exercicio 12

char var9 = 'O';
string var10 = "Tiago Filipe";
bool var11;
bool var12;

Console.WriteLine(var9);
Console.WriteLine(var10);

Console.WriteLine("");


//Exercicio 16

double aa = 4.78905;
double bb = 4.7;
double cc = 5.8954;
double dd = 5;



double roundaa = Math.Round(aa);
double roundbb = Math.Round(bb);
double roundcc = Math.Round(cc);
double rounddd = Math.Round(dd);



Console.WriteLine(roundaa);
Console.WriteLine(roundbb);
Console.WriteLine(roundcc);
Console.WriteLine(rounddd);
Console.WriteLine("");

//Exercicio 17















































