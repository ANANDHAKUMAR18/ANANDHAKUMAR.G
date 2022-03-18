using System;
class sid
{
int num1;
public sid()
{
Console.WriteLine("The Name is ANANDHAKUMAR.G");
}
public sid(int num1)
{
this.num1=num1;
}
public static void Main()
{
sid obj=new sid();
sid obj1=new sid(32);
Console.WriteLine(obj1.num1);
}
}