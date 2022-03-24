int N = Convert.ToInt32(Console.ReadLine());

//your code goes here
for (int i = 1; i <= N; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine('*');
        continue;
    }


    Console.WriteLine(i);
