// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите любое число число: ");
int number = int.Parse(Console.ReadLine());

if (number > 99)
{
    while (number > 999)
    {
        number = number / 10; // можно было записать number /= 10
    }

    int thirdNumber = number % 10;
    Console.WriteLine("Третья цифра вашего числа :" + thirdNumber);
}
else
{
    Console.WriteLine("В вашем числе нет третьей цифры");
}
