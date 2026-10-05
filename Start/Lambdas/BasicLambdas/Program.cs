// LinkedIn Learning Course exercise file for Advanced C# Programming by Joe Marini
// Example file for basic lambda functions

namespace BasicLambdas
{
    // define a few delegate types
    public delegate int MyDelegate(int x);
    public delegate void MyDelegate2(int x, string prefix);

    class Program
    {
        static void Main(string[] args)
        {
            // Create a basic delegate that squares a number
            MyDelegate func1 = (x) => x*x;
            System.Console.WriteLine($"The result of func1 is {func1(5)}");
            // Dynamically change the delegate to something else
            func1 = (x) => x * 10;
            System.Console.WriteLine($"The result of func1 is {func1(5)}");
            // Create a delegate that takes multiple arguments
            MyDelegate2 func2 = (x, y) =>
            {
                System.Console.WriteLine($"The two-arg lambda: {y}:{x*10}");
            };

            func2(25, "some string");
        }
    }
}
