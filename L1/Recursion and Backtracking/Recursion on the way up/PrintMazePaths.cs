using System;

class PrintSusbSesquence
{
public static void Main(){

PrintSS("abc","");

}



//abc
//"",a,b,c,ab,ac,bc
private static void PrintSS(string original, string temp)
{
if(original.Length==0)
{
Console.WriteLine(temp);
return;
}
PrintSS(original, temp);
PrintSS(original, temp+original[i]);

}
}