// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = number / 10 % 10;

if (number >=100 && number <1000)
{
Console.WriteLine($"Вторая цифра числа -> {secondDigit}");
}
else
Console.WriteLine("Некорректный ввод!");



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// int Prompt = number;

// int ThirdNumber(int number)
// {
// while (number > 999)
// {
// number /= 10;
// }
// return number % 10;
// }

// bool CheckNumber(int number)
// {
// if (number < 100)
// return false;
// else return true;
// }

// if (CheckNumber(number) != true)
// System.Console.WriteLine("Третьей цифры нет");
// else
// System.Console.WriteLine($"Третья цифра числа -> {ThirdNumber(number)}");



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите номер дня недели");
// int number = Convert.ToInt32(Console.ReadLine());

// int dayOff = number;

// bool IsDayOff(int dayOff)
// {
//     if (dayOff > 5)
//     {
//         return true;
//     }
//     return false;
// }

// bool CheckDayOff(int number)
// {
//     if (number > 0 && number <= 7)
//     {
//         return true;
//     }
//     Console.WriteLine("Это не день недели");
//     return false;
// }

// if (CheckDayOff(dayOff))
// {
//     if (IsDayOff(dayOff))
//     {
//         Console.WriteLine("Да, выходной!");
//     }
//     else
//     {
//         Console.WriteLine("Нет, не выходной!");
//     }
// }
