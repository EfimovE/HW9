// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"




void NatNumber(int num, int count)
{
  if (count > num) return;
  NatNumber(num, count + 1);
  Console.Write($"{count} ");
}


Console.WriteLine("Введите число N и нажмите Enter: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
NatNumber(num, count);

