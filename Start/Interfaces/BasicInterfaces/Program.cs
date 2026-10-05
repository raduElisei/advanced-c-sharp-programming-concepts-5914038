// LinkedIn Learning Course exercise file for Advanced C# Programming by Joe Marini
// Example file for implementing basic interfaces

namespace BasicInterfaces
{
    // TODO: Define an IStorable interface that provides the ability to load and
    // save the information for an object
    public interface IStorable
    {
        void Save();
        void Load();
        bool NeedsSave { get; set; }
    }

    // TODO: Implement IStorable on the Document class
    class Document : IStorable
    {
        private string name;
        public bool NeedsSave { get; set; }

        public Document(string s)
        {
            name = s;
            Console.WriteLine("Created a document with name '{0}'", s);
        }

        // TODO: Implement the IStorable interface methods and properties
        public void Save()
        {
            System.Console.WriteLine("Document saved.");
        }

        public void Load()
        {
            System.Console.WriteLine("Document loaded.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Document d = new Document("Test Document");

            // TODO: Exercise the IStorable interface
            d.Load();
            d.Save();
            d.NeedsSave = false;
        }
    }
}
