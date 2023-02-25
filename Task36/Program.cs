// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите количество элементов в массиве:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите наименьшую границу массива:");
int numberMin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальную границу массива:");
int numberMax = Convert.ToInt32(Console.ReadLine());
int[] arrayNew = ArrayNew (number, numberMin, numberMax);
Console.WriteLine("В соответствии с введенными сгенерирован следующий массив:");
PrintNewArray(arrayNew);
int sumOddInd = SumOddIndex(arrayNew);
Console.WriteLine();
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях в Вашем массиве: {sumOddInd}");

// Методы
int[] ArrayNew(int num, int min, int max)
{
    Random random = new Random();
    int[] arrayNew = new int[num];
    for (int i = 0; i < arrayNew.Length; i++)
    {
        arrayNew[i] = random.Next(min, max);
    }
    return arrayNew;
}

int SumOddIndex(int[] arrayNew)
{
    int sum = 0;    
    for (int i = 0; i < arrayNew.Length; i++)
    {
        if (i % 2 != 0) sum = sum + arrayNew[i];
    }
    return sum;
}

void PrintNewArray (int[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i < newArray.Length-1) Console.Write($"{newArray[i]}, ");
        if (i == newArray.Length-1) Console.Write($"{newArray[i]}");
    }
}