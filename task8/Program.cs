Console.Write("Введи трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);
string stringNumber = Convert.ToString(number);
Console.WriteLine("вторая цифра этого числа:"+stringNumber[1]);