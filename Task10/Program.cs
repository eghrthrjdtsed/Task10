Random random = new Random();
int randomNumber = random.Next(100, 1000);

Console.WriteLine(randomNumber);

int secondNumber = (randomNumber / 10)% 10;

Console.WriteLine(secondNumber);