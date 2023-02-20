/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
подзадачи:
1. метод ввода числа
2.метод определяющий выходной или рабочий день
3.метод проверяющий что ввели день недели от 0 до 7
*/

int GetChislo(string text)
{
    Console.Write(text);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool WeekendDay(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool ReallyWeekDay(int number)
{
    if (number > 0 && number <=7)
    {
        return true;
    }
    Console.WriteLine ("Вы ввели не верный день недели");
    return false;
}

int weekDay = GetChislo ("Введите день нели -");
if (ReallyWeekDay(weekDay))
{
    if(WeekendDay(weekDay))
    {
        Console.WriteLine("Ура выходной");
    }
    else 
    {
        Console.WriteLine("Рабочий день");
    }
}