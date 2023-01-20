Console.WriteLine("Введите трехначное число:");
int number = int.Parse(Console.ReadLine()!);
int firstNumber = number /100;
int secondNumber =number%10;
Console.WriteLine($"Получите двухзначное число:{firstNumber}{secondNumber}");