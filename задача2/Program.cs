// Напишите программу, которая на вход принимает три числа и выдаёт, какое число самое большое.

// Запрос чисел от пользователя
Console.Write("Введите число 1:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (number1);

Console.Write("Введите число 2:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (number2); 

Console.Write("Введите число 3:");
int number3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (number3);

int max = number1;

if(number1 > max) max = number1;
if(number2 > max) max = number2;
if(number3 > max) max = number3;

Console.Write("max = ");
Console.WriteLine (max);

