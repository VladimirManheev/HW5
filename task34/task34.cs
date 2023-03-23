// Задайте массив заполненный случайными положительными
//  трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2








Console.Clear();
Console.Write($"n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
inputArray(array);
printArray(array);
Console.WriteLine(ReleaseArray(array));

void inputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 1000); //[0;999]
}

int ReleaseArray(int[] array)
{
    int count= 0;
     for (int i = 0; i <array.Length;i++)
            if (array[i]%2 ==0)
                count++;
    return count;          
  
        
}

void printArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}