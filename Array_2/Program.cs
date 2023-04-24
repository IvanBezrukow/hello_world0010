int[] array = { 1, 12, 3, 44, 99, 61, 70, 8, 99, 101, 11 };
int n = array.Length;
int find = 99;
int index = 0; 
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
