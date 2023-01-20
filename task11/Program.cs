Console.WriteLine("Задайте число:");
int firstNumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число для проверки :");
int secondNumber = int.Parse(Console.ReadLine()!);
if(firstNumber%secondNumber==0){
  Console.WriteLine("Число кратно заданному!");
}
else{
  int remainder = firstNumber%secondNumber;
  Console.WriteLine($"Остаток:{remainder}");
}