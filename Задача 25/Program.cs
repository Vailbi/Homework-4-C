/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int number1 = Input("Введите число: ");
int number2 = Input("Введите степень: ");

Degree(number1,number2);

int Input (string x)
{
    Console.Write(x);
    return Convert.ToInt32(Console.ReadLine());
}

int Degree (int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result*A;
    }
    Console.WriteLine(result);
    return A;
}

