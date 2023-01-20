int max = 0;
for (int number = 89; number != 0; number /= 10)
{
  int remainder = number % 10;
  if (remainder > max) max = remainder;
}
Console.WriteLine(max);




