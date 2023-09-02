Console.Write("Enter number a : ");
string strNum = Console.ReadLine();
int a = int.Parse(strNum);

Console.Write("Enter number b : ");
strNum = Console.ReadLine();
int b = int.Parse(strNum);

if(a>b)
{
Console.WriteLine($"Max:" + a + ",Min:" + b);
}
else
{
Console.WriteLine($"Max: {b}, Min: {a}");
}
