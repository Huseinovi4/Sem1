Console.WriteLine("введите первое число");
int firstNum = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите второе число:");
int secondNum = int.Parse(Console.ReadLine()!);
if (firstNum == secondNum*secondNum){
  Console.WriteLine("является квадратом второго чила");
}
else{
  Console.WriteLine("не является квадратом второго числа");
}