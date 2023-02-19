// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число, а проверю, является ли оно палиндромом: ");
int number = int.Parse(Console.ReadLine());

if (number < 10000 || number >= 100000)
{
    Console.WriteLine("Введите пятизначное число");
}
else
{
    int figure1 = number / 10000;
    int figure2 = number / 1000 % 10;    
    int figure4 = number % 100 / 10;
    int figure5 = number % 10;

    if (figure1 == figure5 && figure2 == figure4)
    {
        Console.WriteLine("Да, это полиндром");
    }
    else
    {
        Console.WriteLine("Нет, это не полиндром");
    }
}
