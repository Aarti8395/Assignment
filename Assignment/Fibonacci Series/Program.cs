
Console.WriteLine("Enter number of terms ");
int n = Convert.ToInt32(Console.ReadLine());

int first = 0, second = 1, next;
Console.Write("Fibonacci series: ");
for (int i = 0; i < n; i++)
{
    Console.Write(first + " ");
            
    next = first + second;
    first = second;
    second = next;
}
Console.ReadKey();