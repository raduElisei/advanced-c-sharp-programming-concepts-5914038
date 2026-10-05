// LinkedIn Learning Course exercise file for Advanced C# Programming by Joe Marini
// Example file for explicit interfaces

namespace ExplicitInterfaces
{
    interface Intf1
    {
        void SomeMethod();
    }
    interface Intf2
    {
        void SomeMethod();
    }

    // TODO: Implement two interfaces with conflicting methods
    class InterfaceTest : Intf1, Intf2
    {
        // TODO: Implement Intf1 and Intf2 SomeMethod
        void Intf1.SomeMethod()
        {
            Console.WriteLine("This is Intf1's SomeMethod");
        }
        void Intf2.SomeMethod()
        {
            Console.WriteLine("This is Intf2's SomeMethod");
        }

        public void SomeMethod()
        {
            Console.WriteLine("This is the class SomeMethod");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            InterfaceTest testclass = new InterfaceTest();
            testclass.SomeMethod();

            // TODO: Call SomeMethod in the two interfaces
            Intf1 i1 = testclass as Intf1;
            i1.SomeMethod();

            Intf2 i2 = testclass as Intf2;
            i2.SomeMethod();
        }
    }
}
