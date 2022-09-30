/*
Задача 27: Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());
int[] array = userNumber.ToString().Select(t=>int.Parse(t.ToString())).ToArray();
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    sum = array[i] + sum;
}

Console.WriteLine($"Сумма цифр введенного числа {sum}");