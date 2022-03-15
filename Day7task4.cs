using System;
class Avgmark
{
public static void Main()
{
int [] marks=new int[]{55,77,45,66,90};
int avg,sum=0;
for(int i=0;i<5;i++)
{
 sum=sum+marks[i];
 
}
avg=sum/5;
Console.WriteLine("the total and percentage of 5subjects is");
Console.WriteLine(avg);
Console.WriteLine(sum);
}
}
