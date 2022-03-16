using System;
class poly
{
public void userpass()
{
Console.WriteLine("Username");
string usern=Console.ReadLine();
Console.WriteLine("Password");
string passw=Console.ReadLine();
}
public void userpass(int n1, int n2)
{
Console.WriteLine("MembershipId");
Console.WriteLine(n1);
Console.WriteLine("Pin1");
Console.WriteLine(n2);
 }
public void userpass(double n1,int n2)
{
Console.WriteLine("Phone number");
Console.WriteLine(n1);
Console.WriteLine("Pin2");
Console.WriteLine(n2);
}


public static void Main()
{
poly obj=new poly();
obj.userpass();
obj.userpass(1234,1234);
obj.userpass(9176457407,1234);
Console.WriteLine("validation done");
}}	