﻿//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int num = new Random().Next(100, 1000); // вводим с рандомное число из диапазона
int num2 = num / 10; // делим на 10 и отсекаем третья цифру
int iskomoe = num2 % 10; //ищем остаток от деления на 10 и получаем вторую цифру

Console.WriteLine ($" вторая цифра числа {num} -> {iskomoe}");








