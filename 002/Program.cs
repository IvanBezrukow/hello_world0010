Console.WriteLine("Введите 1 число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int num2 = Convert.ToInt32(Console.ReadLine());
int ost = num1%num2;
if (ost == 0)
{
    Console.WriteLine("Делистя без остатка");
}
else
    Console.WriteLine($"остаток есть и он = {ost}");