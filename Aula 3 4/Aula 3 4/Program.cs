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



