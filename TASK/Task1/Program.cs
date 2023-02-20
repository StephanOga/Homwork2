// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// 456 -> 5
// 782 -> 8
// 918 -> 1


int GetChislo(string messege)
{
    Console.Write(messege +" ");
    return int.Parse(Console.ReadLine());
}
int  namber = GetChislo ("Введите трехзначное чило ");

    if (namber < 100 || namber >=1000)
    {
        Console.WriteLine("Вы ввели не трех значное чилос, повторите ввод");
        return;
    } 
Console.WriteLine("Введеное число " + namber);
int secondRank = namber / 10 % 10;
Console.WriteLine("Вторая цифра " + secondRank);