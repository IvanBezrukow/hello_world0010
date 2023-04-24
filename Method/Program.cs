int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 1; 
int a2 = 12; 
int a3 = 5; 
int b1 = 7; 
int b2 = 78; 
int b3 = 451; 
int c1 = 103;
int c2 = 43; 
int c3 = 2;
int max = Max(Max(a1, b1, c1), Max(b1, b2, b3), Max(c1, c2, c3));
Console.WriteLine(max);