using System;
class Ebill
{
public static void Main()
{
int a,price,unit;
Console.WriteLine("Enter the no of units");
unit=Convert.ToInt32(Console.ReadLine());
if(unit<=200)
{
price=unit*2;
}
else if(unit>200 && unit<=350)
{
a=unit-200;
price=400+(a*3);
}
else if(unit>350 && unit<=500)
{
a=unit-350;
price=850+(a*5);
}
else
{
a=unit-500;
price=1600+(a*7);
}
Console.WriteLine("the amount to be paid"+price);
}
}