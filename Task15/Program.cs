Console.Write("Введите число обозначающее день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
bool findWeekEnd(int weekDay)
{
    bool numberDay;
    if ((weekDay == 6) ^ (weekDay == 7))
    {
        numberDay = true;
    }
    else
    {
        numberDay = false;
    }
    return numberDay;
}

if (findWeekEnd(day) == true)
{
    Console.WriteLine("Это выходной день недели");
}
else
{
    Console.WriteLine("Это рабочий день недели");
}