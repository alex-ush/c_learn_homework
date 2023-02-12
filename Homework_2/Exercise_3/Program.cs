// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число - порядковый номер дня недели: ");
int number = int.Parse(Console.ReadLine());

if (number > 7)
{
    Console.WriteLine("В неделе всего 7 дней");
}
else
{
    if (number > 5)
    {
        Console.WriteLine("Это выходной");
    }
    else
    {
        Console.WriteLine("Нет, не выходной");
    }
}
