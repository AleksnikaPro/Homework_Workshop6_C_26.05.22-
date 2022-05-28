// 3.В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

Console.WriteLine("Введите количество строк n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов m: ");
int m = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine();
int [,] myArray = new int [n,m];
for (int i = 0; i < n; i++)
{
  for (int j = 0; j < m; j++)
  {
     Console.Write($"{myArray[i,j]} ");
  }
  Console.WriteLine();
}
Console.WriteLine();
Console.Write($"Исходный массив ");
Console.WriteLine();
for (int i = 0; i < n; i++)
{
  for (int j = 0; j < m; j++)
  {
     myArray[i,j] = new Random().Next(0,10);
     Console.Write($"{myArray[i,j]} ");
  }
  Console.WriteLine();
}
Console.WriteLine();
Console.Write($"Массив с элементами в квадрате, у которых оба индекса четные");
Console.WriteLine();
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
  {
    if (i % 2 == 0 
        & j % 2 == 0 
        & i !=0 
        & j!=0)
        myArray[i,j] = myArray[i,j] * myArray[i,j];
        Console.Write($"{myArray[i,j]} ");     
  }
  Console.WriteLine();
}
 Console.WriteLine();




