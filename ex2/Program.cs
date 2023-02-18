/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int[,] InitMatrix()
{
    int[,] array = new int[3,4];
    Random rnd = new Random();
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
            array[i,j]=rnd.Next(0,100);
        }
    }
    return array;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("Случайный массив целых чисел:");
for(int i=0; i<matrix.GetLength(0);i++)
{
    for (int j=0; j<matrix.GetLength(1);j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
}

int GetNumber()
{

int result=0;
while(true)
{
    Console.WriteLine("Введите целое положительное число:");
    if(int.TryParse(Console.ReadLine(), out result) && result>=0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Некорректный ввод");
    }
}
return result;
}
void ShowPosition (int number, int[,]matrix)
{
    int x=-1;
for (int i=0; i<matrix.GetLength(0);i++)
{
    for (int j=0; j<matrix.GetLength(1); j++)
    {
        if(matrix[i,j]==number)
        {
            Console.WriteLine($"Индекс числа {number} в массиве: ({i}, {j})");
            x=matrix[i,j];
        }
    }
}
if(x==-1)
{
    Console.WriteLine($"Числа {number} нет в массиве");
}
}
int [,] matrix = InitMatrix();
PrintMatrix(matrix);
int number = GetNumber();
ShowPosition(number, matrix);