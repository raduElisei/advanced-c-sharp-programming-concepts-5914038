// LinkedIn Learning Course exercise file for Advanced C# Programming by Joe Marini
// Example file for built-in .NET interfaces

// TODO: Include the namespace that contains INotifyPropertyChanged
using System.ComponentModel;

namespace NETInterfaces;

interface IStorable
{
    void Save();
    void Load();
    Boolean NeedsSave { get; set; }
}

// TODO: Implement INotifyPropertyChanged
class Document : IStorable, INotifyPropertyChanged
{
    private string name;
    private Boolean mNeedsSave = false;

    // TODO: INotifyPropertyChanged requires the implementation of 1 event
    public event PropertyChangedEventHandler PropertyChanged;
    // TODO: Define a utility function to call the PropertyChanged event
    private void NotifyPropChange(string PropName)
    {
        PropertyChanged(this, new PropertyChangedEventArgs(PropName));
    }
    public Document(string s)
    {
        name = s;
        Console.WriteLine("Created a document with name '{0}'", s);
    }

    public string DocName
    {
        get { return name; }
        set
        {
            name = value;
            NotifyPropChange("DocName");
        }
    }

    public void Save()
    {
        Console.WriteLine("Saving the document");
    }

    public void Load()
    {
        Console.WriteLine("Loading the document");
    }

    public Boolean NeedsSave
    {
        get { return mNeedsSave; }
        set
        {
            mNeedsSave = value;
            NotifyPropChange("NeedsSave");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Document d = new Document("Test Document");

        // TODO: implement a delegate to handle the PropertyChanged event
        d.PropertyChanged += delegate (object sender, PropertyChangedEventArgs e)
        {
            System.Console.WriteLine($"Document prop changed {e.PropertyName}");
        };

        // Change a couple properties to trigger the event
        d.DocName = "My Document";
        d.NeedsSave = true;
    }
}
