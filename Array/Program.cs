int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int[] numbers = { 1, 2, 3, 4, 5, 60, 7, 8, 9 };
int max = Max(Max(numbers[0], numbers[1], numbers[2]),
    Max(numbers[3], numbers[4], numbers[5]),
    Max(numbers[6], numbers[7], numbers[8])
    );
Console.WriteLine(max);