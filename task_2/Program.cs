// 2.Задать двумерный массив следующим правилом: Aₘₙ = m+n

Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число m:");
int m = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine();
int [,] myArray = new int [n,m];

for (int row = 0; row < n; row++) 
{
  for (int column = 0; column < m; column++)
  {
     myArray [row, column] = row + column; 
     Console.Write($"{myArray [row, column]}" + "\t"); 
  }
  Console.WriteLine();
}


