using System;

Console.WriteLine("Informe o promeiro valor!");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o promeiro valor!");
int b = Convert.ToInt32(Console.ReadLine());

int r;

try
{
    r = a / b;
    Console.WriteLine($"O resultado é {r}");
}catch(Exception e) 
{
    Console.WriteLine("Não é permitido divisão por zero!");
}