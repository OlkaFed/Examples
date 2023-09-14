//Вид 1. Метод, который ничего не принимает, но возвращает (выводит) что-то.
//void Method1() 
//{    Console.WriteLine("Автор");}
//Вызвать метод: Method1();

//Вид 2. Метод, который что-то принимает, что-то возвращает: 
//void Method2(string msg)
//{    Console.WriteLine(msg);}
//Method2("Текст сообщения");

//Вид 3. Метод который принимает, но не возвращает: Нужно указать тип данных, в данном случае int 
//int Method3()
//{    return DateTime.Now.Year;}
//int year = Method3();
//Console.WriteLine(year); 

//Вид 4. Принимает и возвращает: 
//string Method4(int count, char c)
//{    int i=0; 
//    string rezult = String.Empty; //переменная rezult будет пустой строкой 
//    while(i<count)
//    {        rezult = rezult + c;
//        i = i++;}
//    return rezult;}
//string rez = Method4(10,"qwerty");
//Console.WriteLine(rez); 

//Цикл FOR 
//string Method5(int count, char c)
//{    string rezult = String.Empty; //переменная rezult будет пустой строкой 
//    for(i=0, i<count, i++)
//    {        rezult = rezult + c;    }
//    return rezult;}
//string rez = Method5(10,"qwerty");
//Console.WriteLine(rez); 

//Таблица умножения или Цикл в Цикле 

for(int i=2; i<=10; i++)
{
    for(int j=2; j<=10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
}