int a = Console.Read();
int b = Console.Read();
int c = Console.Read();
int d = Console.Read();

double result;

if (a < 0)
{
    result = (a + b + c) / d;
}
else if (a == 0)
{
    result = 100 + b * c - d;
}
else if (a > 0)
{
    result = a * b * c * d;
}
else
{
    result = a * b;
}

Console.WriteLine(result);