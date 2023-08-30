Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "олька")
{
Console.WriteLine("Ура, это же Олька!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}