// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Promt(string messange)
{
    System.Console.Write(messange);
    string read = System.Console.ReadLine();
    int result = int.Parse(read);
    return result;
}

int [] Genereit(int Length, int minValue, int maxValue)
{
    int [] array = new int [Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array [i] = random.Next(minValue, maxValue +1); 
    }
    return array;
}

void Print (int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
     System.Console.Write($"{array[array.Length - 1]}");
     System.Console.WriteLine("]");
}

int Length = Promt("Длина массива: ");
int minValue = Promt("Минимадьное значение: ");
int maxValue = Promt("Максимальное значение: ");
int [] array = Genereit(Length, minValue, maxValue);
Print(array);