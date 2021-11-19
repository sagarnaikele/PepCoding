using System;

public class Sieve_of_Eratosthenes_PrimeNumbers
{

    public static void Main()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        PrintPrimeNumbersTill(num);
    }

    public static void PrintPrimeNumbersTill(int num)
    {
        int primeArr = new int[num];
        for (int i = 2; i < primeArr.Length; i++)
        {
            if (!primeArr[i])
                for (int j = i; j * i < primeArr.Length; j++)
                {
                    primeArr[j * i] = true;
                }
        }
        foreach (var item in primeArr.Where(e => !e))

    }

}