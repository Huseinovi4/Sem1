int x = 0;
for (int m = 89; m != 0; m /= 10)
{
  int r = m % 10;
  if (r > x) x = r;
}
Console.WriteLine(x);




