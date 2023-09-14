// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Promt(string messange)
{
    System.Console.Write(messange);
    string read = System.Console.ReadLine();
    int result = int.Parse(read);
    return result;
}

int SumNumber( int a)
{
   int sumNumberresult = 0;
   {
    while (a > 0)
    {
        sumNumberresult = sumNumberresult + a % 10;
        a = a/10;
    }
    return sumNumberresult;
   }
}

int a = Promt("Введите число: ");
Console.WriteLine(SumNumber(a));