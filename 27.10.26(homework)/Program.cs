namespace _27._10._26_homework_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTask1------------");
            int[] number = { 50, 30, 20, 10, 100 };
            Array arr = new Array(number);

            Console.WriteLine($"Less 20: {arr.Less(20)}");
            Console.WriteLine($"Greater 20: {arr.Greater(20)}");



            Console.WriteLine("\nTask2----------");
            int[] number2 = { 10, 20, 25, 30, 50, 73, 15 };
            Array arr2 = new Array(number2);

            Console.WriteLine("Even numbers:");
            arr2.ShowEven();

            Console.WriteLine("Odd numbers:");
            arr2.ShowOdd();

        }
    }
}
