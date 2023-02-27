// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Pow(int A, int B)
{
int result = 1;
for (int i = 0; i < B; i++)
{
result *= A;
}
return result;
}

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());

int PowResult = Pow(A, B);

Console.WriteLine(A + " в степени " + B + " будет " + PowResult);
