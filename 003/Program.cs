string CheckCoord(int num)
{
    string result = "";
    if (num == 1)
        result = "x>0, y>0";
    else if (num == 2)
        result = "x<0, y>0";
    else if (num == 3)
        result = "x<0, y<0";
    else if (num == 4)
        result = "x>0, y<0";
    return result;
}




try
{
    Console.WriteLine("Введите номер координатной четверти");
    int num = Convert.ToInt32(Console.ReadLine());
    string res = CheckCoord(num);
    if (res != "")
        Console.WriteLine($"Координаты могут быть такими: {CheckCoord(num)}");
    else
        Console.WriteLine("Были введены некорректные значения");
}
catch
{
    Console.WriteLine("Можно вводить лишь целочисленные значения");
}