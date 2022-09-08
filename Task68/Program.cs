// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine($"Введите m и нажмите Enter.");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите n и нажмите Enter.");
int n = Convert.ToInt32(Console.ReadLine());

int FunctionAk(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return FunctionAk(m - 1, 1);
  else return FunctionAk(m - 1, FunctionAk(m, n - 1));
}

int functionAk = FunctionAk(m, n);
Console.Write($"А = {functionAk} ");