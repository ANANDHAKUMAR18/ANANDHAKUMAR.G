using System;
class products
{
public static void Main()
{
string [][] products=new string [4][];
products[0]=new string[]{"list"};
products[1]=new string[]{"a"};
products[2]=new string[]{"b"};
products[3]=new string[]{"c"};
for(int i=0;i<products.Length;i++)
{
   for(int j=0;j<products[i].Length;j++)
   Console.Write(products[i][j]+ "\t");
   Console.WriteLine();
}
}
}