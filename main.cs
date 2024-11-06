using System;

class Program
{
    public static void Main(string[] args)
    {

        //Create account
        BankAccount account = new BankAccount();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Huidig saldo: " + account.getBalance());
            Console.WriteLine("Geld opnemen (voer bedrag in): ");

            decimal amount = Convert.ToDecimal(Console.ReadLine());
            account.subtractFromBalance(amount);
        }

    }
}