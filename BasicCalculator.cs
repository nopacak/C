/*do
{
    Console.Write("x = ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.Write("y = ");
    int y = Convert.ToInt32(Console.ReadLine());

    int sum = x + y;
    Console.WriteLine("Result: {0}", sum);
}
while (true);
Console.ReadLine();*/

do
{
    Console.Write("x = ");
    string str = Console.ReadLine();
    if (str == "exit")
        break;

    int x = Convert.ToInt32(str);

    Console.Write("y = ");
    int y = Convert.ToInt32(Console.ReadLine());

    int sum = x + y;
    Console.WriteLine("Result: {0}", sum);
}
while (true);
Console.ReadLine();
