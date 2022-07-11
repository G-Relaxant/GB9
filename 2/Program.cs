int m = 1;
int n = 14;

if (m < n)
{
    ConsoleWriteWithRecursionNbigM(m, n);
    Console.Write(n);
}
else
{
    if(m == n)
    {
        Console.WriteLine($"Numbers should having different values");
    }
    else
    {
        ConsoleWriteWithRecursionMbigN(m, n);
        Console.Write(m);
    }    
}

void ConsoleWriteWithRecursionNbigM(int a, int b)
{
    if(a < b)
    {
        Console.Write($"{a}, ");
        a++;
        if(a < b)
        {
            ConsoleWriteWithRecursionNbigM(a, b);  // Recursion
        }
    }   
}
void ConsoleWriteWithRecursionMbigN(int a, int b)
{
    if(b < a)
    {
        Console.Write($"{b}, ");
        b++;
        if(b < a)
        {
            ConsoleWriteWithRecursionMbigN(a, b);  // Recursion
        }
    }    
}