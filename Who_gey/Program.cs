Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "эдик")
{
    Console.WriteLine("Эдик- педик");
}
    else
        if(username.ToLower() == "рома")
        {
            Console.WriteLine("Рома - почти педик");
        }
        else
        {
        Console.Write(username);
        Console.WriteLine(" - не педик");
        }