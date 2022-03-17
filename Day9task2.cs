using System;
abstract class Calculator
{
public abstract void Arithmetic();
}

class Addition:Calculator
{
public override void Arithmetic( )
{
int a=30;
int b=40;
int sum;
Console.WriteLine("ADD");
sum=a+b;
Console.WriteLine(sum);
}
}


class Subtract:Calculator
{
public override void Arithmetic()
{
 int c=30;
 int d=30;
int sub;
Console.WriteLine("SUB");
sub=d-c;
Console.WriteLine(sub);
}
}


class Multiply:Calculator
{
public override void Arithmetic()
{
 int e=30;
int f=50;
int mul;
Console.WriteLine("MUL");
mul=e*f;
Console.WriteLine(mul);
}
}


class Divide:Calculator
{
public override void Arithmetic()
{
int g=30;
int h=40;
int div;
Console.WriteLine("DIV");
div=g/h;
Console.WriteLine(div);
}
}
class task
{
public static void Main()
{
Addition aobj = new Addition();
aobj.Arithmetic();
Subtract sobj = new Subtract();
sobj.Arithmetic();
Multiply mobj = new Multiply();
mobj.Arithmetic();
Divide dobj = new Divide();
dobj.Arithmetic();

}
} 