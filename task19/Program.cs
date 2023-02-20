Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if(num>9999 && num<100000)
{
  int a0 = num / 10000;
  int a4 = num % 10;
  int x1 = num / 1000;
  int a1 = x1 % 10;
  int x3 = num / 10;
  int a3 = x3 % 10;
    if(a0 == a4 && a1 == a3)
    {
      Console.WriteLine($"{num} палиндром");
    }
    else
    {
      Console.WriteLine($"{num} не палиндром");
    }
}
else
{
  Console.WriteLine($"Число {num} не является пятизначным");
}