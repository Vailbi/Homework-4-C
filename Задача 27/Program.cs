/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int number1 = Input("Введите число: ");

int Input (string x)
{
    Console.Write(x);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum (int A)
{
    int result = 0;
    int B = 0;

    while(A != 0)
    {
        B = A % 10;
        A = A / 10;
        result = result + B;
    }
        Console.WriteLine(result);
        return result;
}

Sum(number1);
