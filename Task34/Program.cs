// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите количество символов в массиве:");
int numberDigit = Convert.ToInt32(Console.ReadLine());
int[] newArray = NewArray(numberDigit, 100, 999);
Console.WriteLine("Ваш массив, состоящий из случайных положительных трехзначных чисел:");
PrintArray(newArray);
Console.WriteLine();
int numberEven = NumberEven(newArray);
Console.WriteLine($"Количество четных чисел в Вашем массиве: {numberEven}");

//Методы 
int[] NewArray(int num, int min, int max)
{
    Random random = new Random();
    int[] arrayNew = new int[num];
    for (int i = 0; i < num; i++)
    {
        arrayNew[i] = random.Next(min, max + 1);
    }
    return arrayNew;
}

int NumberEven(int[] arrayNew)
{
    int count = 0;
    for (int i = 0; i < arrayNew.Length; i++)
    {
        if (arrayNew[i] % 2 == 0) count = count + 1;
    }
    return count;
}

void PrintArray(int[] arrayNew)
{
    for (int i = 0; i < arrayNew.Length; i++)
    {
        if (i < arrayNew.Length-1) Console.Write($"{arrayNew[i]}, ");
        if (i == arrayNew.Length-1) Console.Write($"{arrayNew[i]}");
    }
}