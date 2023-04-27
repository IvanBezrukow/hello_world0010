int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num);
int count = 0;
while (num > 0)
{
    count++;
    num = num / 10;
}
Console.WriteLine(count);