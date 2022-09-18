 
Console.WriteLine("Введите число строк (m)");
if (!int.TryParse(Console.ReadLine()!, out var m))
{
     Console.WriteLine("Введите целое число для определения размера массива!");
}


Console.WriteLine("Введите число столбцов (n)");
if (!int.TryParse(Console.ReadLine()!, out var n))
{
     Console.WriteLine("Введите целое число для определения размера массива!");
}
