// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Запрос чисел от пользователя
Console.Write("Введите число 1:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (number1);

Console.Write("Введите число 2:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (number2); 

int max = number1;
int min = number1;

if(number1 > max) max = number1;
if(number2 > max) max = number2;
if(number1 < min) min = number1;
if(number2 < min) min = number2;

Console.Write("max = ");
Console.WriteLine (max);

Console.Write("min = ");
Console.WriteLine (min);
