// Задача 52 :Задайте двумерный массив из целых чисел. найдите среднее арифметическое элементов в каждом столбце

Console.Write("Введите количество строк m: "); 
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m,n];

FillArray(array);
PrintArray(array);

Console.WriteLine("Средние значения по столбцам равны ");

for (int j=0; j<n; j++)
{
        double sum = 0;
        double average = 0;
        for (int i = 0; i < m; i++)
        {
            sum += array[i, j];
        }
        average = sum/ m;
        Console.Write(Math.Round(average,2)  + "     ");   
}

void PrintArray(double[,] matr) 
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($" {matr[rows, columns]} ");   
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr) 
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[rows,columns] = new Random().Next(1,11); 
        }
        Console.WriteLine();
    }
}
