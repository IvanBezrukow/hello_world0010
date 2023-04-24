Console.Write("Введите ваше имя: ");
string username = Console.ReadLine(); 
if (username.ToLower() == "lera")
{
    Console.WriteLine("Hello, my darling Lera");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}