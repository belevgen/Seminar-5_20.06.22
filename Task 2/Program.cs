// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

int [] CreateAndFillArr(int large, int min, int max)
{
    int [] array = new int [large];
    for (int iffil = 0; iffil < array.Length; iffil++)
    {
        array [iffil] = new Random ().Next(min, max + 1);
    }
    return array;
}
void printArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}
int SumOddPositions(int[] arr)
{
    int SumOdd = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        SumOdd += arr[i];
    }
return SumOdd;
}

int[] myArray = CreateAndFillArr(10, 0, 10);
printArr(myArray);
var sum = SumOddPositions(myArray);
System.Console.WriteLine($"Суммв чисел на нечетных позициях => {sum}");

