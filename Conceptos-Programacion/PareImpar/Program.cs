using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num;
        Console.WriteLine("DIGITE UN NUMERO: ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("EL NUMERO ES PAR");
        }
        else
        {
            Console.WriteLine("EL NUMERO ES IMPAR");
        }
