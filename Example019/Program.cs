// Задача 19: 
// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
Console.Write("Введите пятизначное число: ");
string Number = Console.ReadLine();
int size = Number.Length;
if (size < 5 || size > 5)
{
    Console.WriteLine("Введенное число не соответствует условию.");
}
else
{
    if (Number[1] == Number[3])
    {
        if (Number[0] == Number[4])
        {
            Console.WriteLine("Число " + Number + " является палиндромом.");
        }
    }
    else
    {
        Console.WriteLine("Число " + Number + " НЕ является палиндромом.");
    }
}