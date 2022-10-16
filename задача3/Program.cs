/* Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка)*/

// Запрос чисел от пользователя
Console.Write("Введите число 1:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (number1);

if (number1 % 2 == 0) 

{
Console.WriteLine("Число четное");   
}

else
{
Console.WriteLine("Число нечётное");
}
