// LinkedIn Learning Course exercise file for Advanced C# Programming by Joe Marini
// Example file for Event Challenge

namespace EventsChallenge;

class PiggyBank
{
    private decimal _BalanceAmount;
    public event EventHandler<PiggyBankChangedBalanceEventArgs>? BalanceChanged;

    protected virtual void OnBalanceChanged(PiggyBankChangedBalanceEventArgs e)
    {
        BalanceChanged?.Invoke(this, e);
    }

    public decimal TheBalance
    {
        set
        {
            decimal oldBalance = _BalanceAmount;
            _BalanceAmount = value;
            OnBalanceChanged(new PiggyBankChangedBalanceEventArgs(oldBalance, _BalanceAmount));
        }
        get
        {
            return _BalanceAmount;
        }
    }
}

public class PiggyBankChangedBalanceEventArgs : EventArgs
{
    public decimal OldBalance { get; }
    public decimal NewBalance { get; }


    public PiggyBankChangedBalanceEventArgs(decimal oldBalance, decimal newBalance)
    {
        OldBalance = oldBalance;
        NewBalance = newBalance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        decimal[] testValues = { 250, 1000, -750, 100, -200 };

        PiggyBank pb = new PiggyBank();
        pb.BalanceChanged += (_, e) =>
        {
            System.Console.WriteLine($"Balance changed from {e.OldBalance:C} to {e.NewBalance:C}");
        };

        foreach (decimal testValue in testValues)
        {
            pb.TheBalance += testValue;
        }

        Console.WriteLine($"Final value is {pb.TheBalance}");
    }
}
