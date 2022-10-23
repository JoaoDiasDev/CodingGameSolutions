int N = int.Parse(Console.ReadLine());
var result = new List<string>(new string[N]);


// Write an answer using Console.WriteLine()
// To debug: Console.Error.WriteLine("Debug messages...");

for (int i = 0; i < N; i++)
{
    if (i == 0)
    {
        for (int j = 0; j <= result.Count; j++)
        {
            result[i] += "#";
        }
    }
    else if (i == N - 1)
    {
        for (int j = 0; j <= result.Count; j++)
        {
            result[i] += "#";
        }
    }
    else if (i != 0 && i != N - 1)
    {
        result[i] += "#";
        for (int j = 0; j < result.Count - 1; j++)
        {
            result[i] += " ";
        }
        result[i] += "#";
    }
    else
    {
    }
}

foreach (var item in result)
{
    Console.WriteLine(item);
}

Console.ReadLine();
