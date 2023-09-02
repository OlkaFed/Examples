//1. Создаем метод, который будет формировать массив:
void FullArray(int[] collection)
{
    int legth = collection.Length; 
    int index = 0; 
    while(index<legth)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

//2. Создаем метод, который будет печатать массив 
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0; 
    while(position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    //Если заданного элемента нет, то выдаст позицию -1, что можно интерпретировать как заданный элемент не найден.

    while(index<count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];
//3. Зададим массив, в котором будет 10 элементов 

//Вызываем первый метод:
FullArray(array);
//Вызываем второй метод:
PrintArray(array);
Console.WriteLine(); 
//Выводит пустую строчку

int pos = IndexOf(array, 4);
Console.WriteLine(pos);

//int[] array  = {1, 12, 31, 4, 18, 15, 16, 17, 18};

//возвращает длину (кол-во элементов) массива:
//int n = array.Length; 
//int find = 18; 

//int index = 0; 

//while (index < n) 
//{
//    if (array[index] == find)
//    {
//        Console.WriteLine(index);
        //break - если не нужно выписывать все элементы из условия, остановись на первом 
//        break;
//    }
//    index++;
//}
