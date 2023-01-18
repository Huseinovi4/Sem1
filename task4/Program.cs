Console.WriteLine("Введите первое число:");
int firstNumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int secondNumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число:");
int thirdNumber = int.Parse(Console.ReadLine()!);
int maxNumber = firstNumber;
if(secondNumber>firstNumber){
  maxNumber=secondNumber;
}
if(thirdNumber>maxNumber){
  maxNumber=thirdNumber;
}
else{

}
Console.WriteLine($"Максимальное из трех чисел:{maxNumber}");