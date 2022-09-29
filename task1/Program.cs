/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Введите число A");
int userNumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int userNumberB = Convert.ToInt32(Console.ReadLine());
int currentNumber = userNumberA;

for (int count = 1; count <= userNumberB - 1; count++)
{
    currentNumber = userNumberA * currentNumber;
}

Console.WriteLine($"Число {userNumberA}, возведенное в натуральную степень {userNumberB}, равно {currentNumber}");


