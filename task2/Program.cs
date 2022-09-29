/*
Задача 27: Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число");
string userNumber = Console.ReadLine();
char[] array = userNumber.ToCharArray();
int sum = 0;
Console.WriteLine($"{array}");

for (int i = 0; i < array.Length; i++)
{
    sum = array[i] + sum;
}

Console.WriteLine($"{sum}");