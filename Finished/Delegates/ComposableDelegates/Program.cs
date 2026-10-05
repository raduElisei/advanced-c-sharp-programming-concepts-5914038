// LinkedIn Learning Course exercise file for Advanced C# Programming by Joe Marini
// Example file for composable delegates


namespace ComposableDelegates
{
    // declare the delegate type
    public delegate void MyDelegate(int arg1, ref int arg2);

    class Program
    {
        static void func1(int arg1, ref int arg2)
        {
            arg2 += 20;
            System.Console.WriteLine($"arg 2 is {arg2}");
            string result = (arg1 + arg2).ToString();
            Console.WriteLine("The number is: " + result);
        }

        static void func2(int arg1, ref int arg2)
        {
            string result = (arg1 * arg2).ToString();
            Console.WriteLine("The number is: " + result);
        }

        static void Main(string[] args)
        {
            MyDelegate? f1 = func1;
            MyDelegate? f2 = func2;
            MyDelegate? f1f2 = f1 + f2;

            int a = 10;
            int b = 20;

            // call each delegate and then the chain
            Console.WriteLine("Calling the first delegate");
            f1(10, ref b);
            Console.WriteLine("Calling the second delegate");
            f2(10, ref b);
            Console.WriteLine("\nCalling the chained delegates");
            f1f2(10, ref b);

            // subtract off one of the delegates
            Console.WriteLine("\nCalling the unchained delegates");
            f1f2 -= f1;
            f1f2(20, ref b);
        }
    }
}
