using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {

        int numero1, numero2, numero3, mayor;
        Console.WriteLine("DIGITE EL PRIMER NUMERO: ");
        numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("DIGITE EL SEGUNDO NUMERO: ");
        numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("DIGITE EL TERCER NUMERO: ");
        numero3 = Convert.ToInt32(Console.ReadLine());

        if (numero1 >= numero2 && numero1 >= numero3)
        {
            mayor = numero1;
            Console.WriteLine("EL PRIMER NUMERO ES MAYOR: ");
        }
        else if (numero2 >= numero1 && numero2 >= numero3)
        {
            mayor = numero2;
            Console.WriteLine("EL SEGUNDO NUMERO ES EL MAYOR: ");
        }
        else
        {
            mayor = numero3;
            Console.WriteLine("EL TERCER NUMERO ES EL MAYOR: ");
        }
    }
}

