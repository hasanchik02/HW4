// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum (int num)
{
    int i = 0;

    while (num != 0)
{
   int a = num %10;
   num = num /10;
   int result = a + i;
   i = result;
}
    return i;
}

int number = ReadNumber("Введите число:");
int result = Sum(number);
Console.WriteLine(result);

