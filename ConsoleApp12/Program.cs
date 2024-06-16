int sum = 0;

int n = int.Parse(Console.ReadLine());


Console.Write("The first {0} natural number is :\n", n);
for (int i = 0; i <= n; i++)
{
    Console.Write(i + " ");

    sum += i;
}

Console.WriteLine("The Sum of Natural Number up to {0} terms: {1}", n, sum);