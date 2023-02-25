// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Введите число элементоа в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите нижнюю границу массива: ");
int numberMin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхнюю границу массива: ");
int numberMax = Convert.ToInt32(Console.ReadLine());
double[] arrayNew = NewArray(number, numberMin, numberMax);
Console.WriteLine("В соответствии с запросом у Вас следующий массив:");
PrintArray(arrayNew);
Console.WriteLine();
double findMin = FindMin(arrayNew);
double findMax = FindMax(arrayNew);
double diffMaxMin = Math.Round(findMax, 1, MidpointRounding.ToZero) - Math.Round(findMin, 1, MidpointRounding.ToZero);
Console.WriteLine($"Разница между максимальным ({findMax}) и минимальным ({findMin}) значениями Вашего массива: {diffMaxMin}");


// Методы
double[] NewArray(int num, int min, int max)
{
    Random random = new Random();
    double[] newArray = new double[num];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = Math.Round((random.NextDouble() * (max - min) + min), 1, MidpointRounding.ToZero);
    }
    return newArray;
}
// double DiffMaxMin(double[] newArray)                 // Поиск разницы между макс и мин значениями массива в одном методе 
// {
//     double max = newArray[0];
//     double min = newArray[0];
//     for (int i = 0; i < newArray.Length; i++)
//     {
//         if (newArray[i] >= max) max = newArray[i];
//         if (newArray[i] <= min) min = newArray[i];
//     }
//     double result = Math.Round(max - min, 1, MidpointRounding.ToZero);
//     return result;
// }

double FindMax (double[] newArray)
{
    double max = newArray[0];
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i] >= max) max = newArray[i];
    }
    return max;
}

double FindMin (double[] newArray)
{
    double min = newArray[0];
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i] <= min) min = newArray[i];
    }
    return min;
}


void PrintArray(double[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i < newArray.Length - 1) Console.Write($"{newArray[i]} | ");
        if (i == newArray.Length - 1) Console.Write($"{newArray[i]}");
    }
}
