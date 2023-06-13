// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    Console.Write($"В этом числе третья цифра - ");
    Console.WriteLine(number % 10);
}
else if (number < 100)
{
    Console.Write($"В этом числе третьей цифры нет");
}

else if (number > 999)
{
    while (number > 999)
    {
        number = number / 10;
    }
    number = number % 10;
    Console.Write($"В этом числе третья цифра - ");
    Console.WriteLine(number);
}
