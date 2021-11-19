using System;

class Pattern1
{
public static void Main(){

int range= Convert.ToInt32( Console.ReadLine());
for (int i = 1; i <= range; i++)
{
    for (int j = 1; j < i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
    
}


}
}