// Задача 23:
// Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125
Console.Write("Введите число целое N: ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number < 1)
{
    Console.WriteLine("Число меньше 1, что не соотвествует условию.");
}
Console.Write("Таблица кубов от 1 до " + Number + ": ");
for (int i = 1; i <= Number; i++)
{
    Console.Write(Math.Pow(i, 3) + " ");
}   