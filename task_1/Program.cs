// 1.Показать двумерный массив размером m×n заполненный вещественными числами

Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите число m:");
int m = int.Parse(Console.ReadLine()?? "0");

double [,] myArray = new double [n,m];
for (int row = 0; row < n; row++) 
{
  for (int column = 0; column < m; column++)
  {
    myArray [row, column] = new Random().NextDouble()* 10; 
  }
}
for (int row = 0; row < myArray.GetLength(0); row++) 
{
  for (int column = 0; column < myArray.GetLength(1); column++)
  {
      Console.Write($"{Math.Round((myArray[row,column]), 2)}" + "\t");  
  } 
  Console.WriteLine(); 
}