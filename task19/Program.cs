﻿/*Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.

Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.

Для остальных чисел вернуть True или False.


14212 -> False
12821 -> True
234322 -> Число не пятизначное
*/

Console.Clear();
System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 10000;
System.Console.WriteLine(n1);
int n2 = n / 1000 % 10;
System.Console.WriteLine(n2);
int n4 = n / 10 % 10;
System.Console.WriteLine(n4);
int n5 = n % 10;
System.Console.WriteLine(n5);

if (n >= 10000 && n <= 99999)
{
    if (n1 == n5 && n2 == n4)
    {
        System.Console.WriteLine("Да");
    }
    else
    System.Console.WriteLine("Нет");
}
else
{
  System.Console.WriteLine("Не пятизначное число!");
}

