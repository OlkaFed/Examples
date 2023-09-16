//String.Empty 
//table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
//table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]

//string[,] table = new string[2,5]; 
//table[1,2] = "слово";
//for (int rows = 0; rows < 2; rows++)
//{
//    for (int columns = 0; columns < 5; columns++)
//    {
//        Console.Write($"-{table[rows,columns]}-");
//    }
//    Console.WriteLine();
//}

void PrintArray(int[,] matr) //МЕтод, который печатает 2мерный массив
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FullArray(int[,] matr) //МЕтод, формирует 2мерный массив случайных чисел
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); //[1,10]
            //Console.Write($"{matr[i,j]} ");
        }
        //Console.WriteLine();
    }
}

int[,] matrix = new int[3,4];
PrintArray(matrix);
FullArray(matrix);
Console.WriteLine();;
PrintArray(matrix);
