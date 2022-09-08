// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine($"Введите М и нажмите Enter.");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите N и нажмите Enter.");
int n = Convert.ToInt32(Console.ReadLine());
int temp = m;
if (m > n) 
{
  m = n; 
  n = temp;
}
SummEl(m, n, temp=0);
void SummEl(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов -> {sum} ");
    return;
  }
  SummEl(m, n - 1, sum);
}

