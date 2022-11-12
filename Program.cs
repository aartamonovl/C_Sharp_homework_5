// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] CreateNewArray(int size)
// {
//     int [] array = new int[size];
//     for(int index = 0; index < size; index++)
//     {
//         array[index] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void ShowArray(int [] array)
// {
//     Console.Write("[");
//     for (int index = 0; index < array.Length; index++)
//     {
//         Console.Write(array[index] + ", ");
//     }
//     Console.Write("\b\b]");
//     Console.WriteLine();
// }

// int CountOfEvenNumber (int [] array)
// {
//     int count = 0;
//     for(int index = 0; index < array.Length; index++)
//     {
//         if(array[index] % 2 == 0) count++;
//     }
//     return count;
// }

// Console.Write("Input a size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());

// if (size > 0)
// {
//     int [] randArray = CreateNewArray(size);
//     ShowArray(randArray);
//     Console.WriteLine($"Count of even numbers from array is {CountOfEvenNumber(randArray)}");
// }
// else Console.WriteLine("Size of array must be greater than 0. Try Again!");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int [] CreateNewArray(int size)
// {
//     int [] array = new int[size];
//     for(int index = 0; index < size; index++)
//     {
//         array[index] = new Random().Next(-9, 10);
//     }
//     return array;
// }

// void ShowArray(int [] array)
// {
//     Console.Write("[");
//     for (int index = 0; index < array.Length; index++)
//     {
//         Console.Write(array[index] + ", ");
//     }
//     Console.Write("\b\b]");
//     Console.WriteLine();
// }

// int SumElemNonEvenIndex (int [] array)
// {
//     int sum = 0;
//     for(int index = 1; index < array.Length; index += 2)
//     {
//         sum += array[index];
//     }
//     return sum;
// }

// Console.Write("Input a size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());

// if (size > 0)
// {
//     int [] randArray = CreateNewArray(size);
//     ShowArray(randArray);
//     Console.WriteLine($"Sum of the elements at non-even position of array is {SumElemNonEvenIndex(randArray)}");
// }
// else Console.WriteLine("Size of array must be greater than 0. Try Again!");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] CreateNewArray(int size)
{
    double [] array = new double[size];
    for(int index = 0; index < size; index++)
    {
        array[index] = new Random().Next(-9, 10) + new Random().NextDouble();
    }
    return array;
}

void ShowArray(double [] array)
{
    Console.Write("[");
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write(array[index] + "; ");
    }
    Console.Write("\b\b]");
    Console.WriteLine();
}

double FindMaxElemArray (double [] array)
{
    double max = array[0];
    for(int index = 1; index < array.Length; index++)
    {
        if(array[index] > max) max = array[index];
    }
    return max;
}

double FindMinElemArray (double [] array)
{
    double min = array[0];
    for(int index = 1; index < array.Length; index++)
    {
        if(array[index] < min) min = array[index];
    }
    return min;
}

Console.Write("Input a size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

if (size > 0)
{
    double [] randArray = CreateNewArray(size);
    ShowArray(randArray);
    double maxElem = FindMaxElemArray(randArray);
    double minElem = FindMinElemArray(randArray);
    Console.WriteLine($"Max: {maxElem}");
    Console.WriteLine($"Min: {minElem}");
    Console.WriteLine($"Diff of the max and min elements of array is {maxElem - minElem}");
}
else Console.WriteLine("Size of array must be greater than 0. Try Again!");