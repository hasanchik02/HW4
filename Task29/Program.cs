// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем

// int FillArray (int size)
// {
//     int [] arr = new int [size];

//     for (int i = 0; i < arr.Length; i++)
//     {
//         int number = Convert.ToInt32(Console.ReadLine());
//         arr[i] = number;
//     }
//     return arr;
// }

// int [] array = FillArray(8);
// Console.WriteLine(string.Join(",", array));

int [] arr = new int [8];
Console.WriteLine("Введите массив из 8 чисел:");

for (int i = 0; i < arr.Length; i++)
{
    int number = Convert.ToInt32(Console.ReadLine());
    arr[i] = number;
}

Console.WriteLine("Ваш введенный массив:");
Console.Write(string.Join(",", arr));



