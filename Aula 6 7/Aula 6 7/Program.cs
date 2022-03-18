// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Exercicio 1 

int N = 5;
int i;
float soma=0;

for (i=0; i<=N; i++)
{
    soma = soma + i;
    
}
Console.WriteLine(soma);
Console.WriteLine("");

//Exercicio 2

int A;
int B;

Console.WriteLine("Limite inferior: ");
A = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Limite superior: ");
B = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("");

for (int x = A; x <= B; x++) 


    if (x % 2 == 1)
        
    Console.WriteLine(x);
Console.WriteLine("");

//Exercicio 3

int larg, comp = 0;
char space = ' ';
char cross = 'X';



Console.WriteLine("Largura?");
larg = Convert.ToInt16((Console.ReadLine()));
Console.WriteLine("Comprimento?");
comp = Convert.ToInt16((Console.ReadLine()));

for (int w = 0; w <= larg; w++)
{
    Console.Write(cross);
}

Console.WriteLine();

for (int j = 0; j <= comp; j++)
{
    Console.Write(cross);

    for (int k = 0; k <= larg; k++)
    {
        Console.Write(space);
    }

    Console.WriteLine(cross);
}
for (int l = 0; l <= larg; l++)
{
    Console.Write(cross);
}
Console.WriteLine("");

//Exercicio 4

for (int p = 0; p <= 3; p++)
{
    Console.WriteLine("OXOXOX");
    Console.WriteLine("XOXOXO");
}
Console.WriteLine();

//Exercicio 5

Console.WriteLine("Numero fatorial desejado?");
int num = Convert.ToInt16((Console.ReadLine())); ;  

int fatorial = 1; 

for (int n = 1; n <= num; n++)
{
    fatorial = fatorial * n;
}
Console.WriteLine("Fatorial: " + fatorial); Console.WriteLine();

//Exercicio 6

int numeroAnterior = 0;
int numeroAtual = 1;
int fibonacci;


for (int q = 0; q <= 20; q++)
{
    fibonacci = numeroAnterior + numeroAtual;
    Console.WriteLine(fibonacci);
    numeroAnterior = numeroAtual;
    numeroAtual = fibonacci;
}

//Exercicio 7




