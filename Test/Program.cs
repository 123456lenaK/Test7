
/*int [,] matrix = new int [4, 4];
for (int i = 0; i <  4; i++)
{
    for (int j = 0; j <  4; j++)
    {
        Console.Write ($"{matrix[i, j]} ");
    }
Console.WriteLine ();    
}*/
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
} }

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);//[1; 10)
        }
}
}
int[,] matrix = new int[3, 4];
//PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine ("Введите номер строки  ");
int numberStr = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("Введите номер столбца  ");
int numberCol = Convert.ToInt32 (Console.ReadLine ());
findElement (numberStr, numberCol);
void findElement (int a, int b)
{
Console.WriteLine ($"номер строки {a}");
Console.WriteLine ($"номер столбца {b}");
if (a < matrix.GetLength (0)  && b < matrix.GetLength (1)) 
Console.WriteLine (matrix [a, b]);
else 
Console.WriteLine ($"{a},{b} нет такого");
}

