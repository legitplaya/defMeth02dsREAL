class Program
{
    static void Main(string[] args)
    {
        Computer computer = new Computer();

        int[] ints = [101, 7, 1710, 47, 1312];

        Console.WriteLine(computer.Min(ints));
        Console.WriteLine(ints.Min());

        Console.WriteLine(ints.Max());
        Console.WriteLine(computer.Max(ints));

        Console.WriteLine(ints.Sum());
        Console.WriteLine(computer.Sum(ints));

        Console.WriteLine(ints.Average());
        Console.WriteLine(computer.Avg(ints));
        Console.ReadKey();
    }
}