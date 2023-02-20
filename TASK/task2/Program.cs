//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// определение методов
// 1. метод для ввода числа
// 2. метод для опеделения третьего числа
// 3. метод определяющий наличие третьей цифры

int GetChislo(string messege)
{
    Console.Write(messege +" ");
    return int.Parse(Console.ReadLine());
}
int GetThirdRank(int number)
{
    while (number > 999 )
    {
        number /=10;
    }
    return number % 10;
}

bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    
    }
    return true;
}
int number = GetChislo ("Введите число > ");
if (ValidateNumber (number))
{
    Console.WriteLine (GetThirdRank(number));
}
