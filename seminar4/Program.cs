// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Promt(string messange)
{
    System.Console.Write(messange);
    string read = System.Console.ReadLine();
    int result = int.Parse(read);
    return result;
}

int Count (int a, int b)
{
int naturalnumber = 1;
    for (int i = 0; i < b; i++)
    {
    naturalnumber *= a;
    }
    return naturalnumber;
}

bool Validate (int b)
{
    if (b <= 0)
    {
    Console.WriteLine("Число b должно быть больше нуля");
    return false;
    }
    return true;
}

int a = Promt("Введите число a: ");
int b = Promt("Введите число b: ");

if(Validate(b))
{
    Console.WriteLine("Число " + a + " в степени " + b + " равно "+ (Count(a, b)) + ".");
}
