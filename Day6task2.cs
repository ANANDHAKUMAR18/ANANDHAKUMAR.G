using System;
class Travel
{
public static void Main()
{
string travel,temperature,cough;
Console.WriteLine("Have u travelled anywhere");
travel=Console.ReadLine();
if(travel=="Yes")
{
 Console.WriteLine("Do u have any temperature");
 temperature=Console.ReadLine();
 if(temperature=="Yes")
 {
  Console.WriteLine("Do u have cough issue");
  cough=Console.ReadLine();
  if(cough=="Yes")
  {
   Console.WriteLine("Do swab test");
  }
  else
  {
  Console.WriteLine("Do home quarantine");
  }
 }
 else
 {
 Console.WriteLine("Do home quanrantine");
 } 
 }
else
Console.WriteLine("You r damn safe");
}
}