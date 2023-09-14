// Сортировка 

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

//Опишем метод, который выводит на экран наш массив 
void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i=0; i<count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//Опишем метод, который будет упорядочивать наш массив 
void SelectionSort(int[] array) 
{
    for(int i=0; i<array.Length-1; i++)
    {
        int MinPosition = i; 
        for(int j=i+1; j<array.Length; j++)
        {if(array[j]<array[MinPosition]) //Для сортировки от большего к меньшему нужно изменить знак{if(array[j]>array[MinPosition])}
        {MinPosition = j;}}

        int temporary = array[i];
        array[i] = array[MinPosition];
        array[MinPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);