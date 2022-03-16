using System;
class vattax
{
public virtual void calculateTax()
{
int value1=200;
float vat=(float)(value1*(1+0.2));
Console.WriteLine("the VAT tax is");
Console.WriteLine(vat);
}
}
class gsttax:vattax
{
public override void calculateTax()
{
int value2=250;
float gst=float(value2*0.25);
Console.WriteLine("the GST tax is ");
Console.WriteLine(gst);
}
}
class inherit
{
public static void Main()
{
gsttax obj=new gsttax();
vattax obj2=new vattax();
obj.calculateTax();
obj2.calculateTax();
}
}
