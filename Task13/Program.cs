int findThirdDigit(int Number)
{
    while (Number / 100 > 9)
    {
        Number = Number / 10;
    }
    int thirdDigit = Number%10;
    return thirdDigit;
}

int result = -1;

Console.Write("Введите число - ");
int newNumber = Convert.ToInt32(Console.ReadLine());

if (newNumber / 100 > 0)
{
    result = findThirdDigit(newNumber);
    Console.Write("Третья цифра - ");
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("третьей цифры нет");
}