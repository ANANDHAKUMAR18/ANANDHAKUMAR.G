using System;
class addsub
{
public void add()
{
int n1=23;
int n2=40;
Console.WriteLine("the result of addition is");
Console.WriteLine(n1+n2);
Console.WriteLine("the result of addition is");
Console.WriteLine(n1-n2);
}
}
class muldiv:addsub
{
public void mul()
{
int n1=23;
int n2=50;
Console.writeLine("the result of multiplication");
Console.WriteLine(n1*n2);
Console.WriteLine("the result of division is");
Console.WriteLine(n1/n2);
}
}
class inherit
{
public static void Main()
{
muldiv obj=new muldiv();
obj.add();
obj.mul();
}
}