/* Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.*/

// Запрос числа от пользователя
Console.Write("Введите число :");
int limit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(limit);
int count = 1;

while (count < limit)
{
    count++;
    if (count % 2 == 0)
    Console.WriteLine(count);
}
