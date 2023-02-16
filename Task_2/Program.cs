// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//int num = new Random().Next(10, 99999); // вводим с рандомное число из диапазона
Console.WriteLine("Введите число от 1 до 99999");
int num = int.Parse(Console.ReadLine()!); 
int a = 0;
int x = 0;
if (num > 1 && num < 100)
{
    Console.WriteLine ($" третья цифра числа {num} -> отсутствует");
}

if (num > 99 && num < 1000)
{
    x = num % 10; // Нашли остаток от деления на 100
    Console.WriteLine ($" третья цифра числа {num} -> {x}");
}

if (num > 999 && num < 10000)
{
    a = num / 10;
    x = a % 10;
    Console.WriteLine ($" третья цифра числа {num} -> {x}");
}

if (num > 9999 && num < 100000)
{
    a = num / 100;
    x = a % 10;
    Console.WriteLine ($" третья цифра числа {num} -> {x}");
}

