
class BankAccount
{
    private decimal balance;

    public BankAccount()
    {
        balance = 100;
    }

    public decimal getBalance()
    {
        return balance;
    }

    public void addToBalance(decimal amount)
    {
        balance += amount;
    }

    public bool subtractFromBalance(decimal amount)
    {
        if (amount < balance)
        {
            balance -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }
}

