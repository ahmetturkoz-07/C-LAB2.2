int count = 0;
int sum = 0;

Console.Write("Enter number ( 0 to stop): ");
int number = int.Parse(Console.ReadLine()!);

while (number != 0)
{
    count++;
    sum += number;
    Console.Write("Enter number ( 0 to stop): ");
    number = int.Parse(Console.ReadLine()!);
}

if (count > 0)
{
    double average = (double)sum / count;
    Console.WriteLine($"Count : {count}");
    Console.WriteLine($"Sum: {sum}");
    Console.WriteLine($"Average: {average:F2}");
}
else
{
    Console.WriteLine("No number were entered.");
}