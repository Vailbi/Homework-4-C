/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вывод сделать отдельным методом.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(9);
    
}

int Output (int[] A)

{
int result = 0;
Console.Write("[");
    for (int i = 0; i < A.Length-1; i++)
    {
    result = A[i];
    Console.Write(result + ", ");
    }
Console.Write(A[A.Length-1]);
Console.Write("]");
return result;
    
}

Output(array);

