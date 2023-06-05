using System;

try
{
    Console.WriteLine("Informe o promeiro valor!");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Informe o promeiro valor!");
    int b = Convert.ToInt32(Console.ReadLine());

    int r = a / b;
    Console.WriteLine($"O resultado é {r}");
}
catch (DivideByZeroException e)
{
    Console.WriteLine($"Não é permitido divisão por zero! {e.Message}");
}
catch (InvalidCastException e)
{
    Console.WriteLine($"Conversão de string para letra não é permitida! {e.Message}");
}
catch (Exception e)
{
    Console.WriteLine($"Ocorreu um erro! {e.Message}");
}