using System;
class multi
{
public static void Main()
{
int n,num;
Console.WriteLine("Enter the value for N");
n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the value of n");
num=Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=n;i++)
{
Console.WriteLine("{0}*{1}={2}",num,i,num*i);
}
}
}