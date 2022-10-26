// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Показывает таблицу кубов от 1 до {num} -> ");

int i = 1;
int y = 1;

while(i < (num * num * num))
{
    i = y * y * y;
    Console.Write(i + ", ");
    y++;
}