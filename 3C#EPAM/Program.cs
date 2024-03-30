Console.WriteLine("A:");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("B:");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("A --> B");
if (A >= B)
{
    for (int i = A; i >= B; i--)
    {
        Console.WriteLine(i);
    }
}
else
{
    for (int i = B; i >= A; i--) 
    {
        Console.WriteLine(i);
    }
}