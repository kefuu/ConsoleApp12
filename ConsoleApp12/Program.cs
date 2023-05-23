namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1 fibonacci numbers & file
            Random random = new Random();
            int[] numbers = new int[100];
            for (int i = 0; i < 100; i++)
                numbers[i] = random.Next(1, 100);

            File.WriteAllLines("prime.txt", numbers.Where(FibonacciNums.IsPrime).Select(x => x.ToString()));
            File.WriteAllLines("fibonacci.txt", numbers.Where(FibonacciNums.IsFibonacci).Select(x => x.ToString()));

            Console.WriteLine("Простих чисел: " + numbers.Count(FibonacciNums.IsPrime));
            Console.WriteLine("Чисел Фібоначчі: " + numbers.Count(FibonacciNums.IsFibonacci));

            // task 2 replace word from file
            ReplaceWord.ReplaceWordFunc(args);

            // task 3 file moderator
            FileModerator.FileModeratorFunc(args);
        }
    }
}
