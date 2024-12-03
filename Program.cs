namespace Assignment5_2_3
{
    internal class Program
    {
        // Write a program in C# Sharp to print numbers from n to 1 using recursion.
        static void Main(string[] args)
        {
            RecursiveNaturalNumbersDesc(10);
        }

        // Prints natural numbers from n to 1 in descending order
        static void RecursiveNaturalNumbersDesc(int natNums)
        {
            if (natNums > 0)
            {
                Console.WriteLine(natNums);
                RecursiveNaturalNumbersDesc(natNums - 1);

            }
        }
    }
}
