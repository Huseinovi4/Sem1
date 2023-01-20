Console.WriteLine("Введите трехначное число:");
int number = int.Parse(Console.ReadLine()!);
int p = number /100;
int r =number%10;
Console.WriteLine($"Получите двухзначное:{p}{r}");