// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNum(int Number)
{
    int Result = 0;
    while (Number > 0)
    {
        Result += Number % 10;
        Number = Number / 10;
    }
    return Result;
}

Console.Write("Введите ваше число, а я посчитаю сумму всех его чисел: ");
int Number = int.Parse(Console.ReadLine());

int SumNumResult = SumNum(Number);

Console.WriteLine("Сумма всех чисел равна " + SumNumResult);
