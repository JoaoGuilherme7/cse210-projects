using System;

public class BankAccount
{
    private decimal balance;

    public BankAccount(decimal initialBalance){
        balance = initialBalance;
    }

    public decimal GetBalance() { return balance; }

    public void Deposit(decimal amount) {
        if (amount > 0){
            balance += amount;
            Console.WriteLine($"Deposited: {amount}. New balance: {this.balance}");
        }
        else
            Console.WriteLine("Deposit amount must be positive.");
    }

    public void Withdraw(decimal amount){
        if (amount > 0 && amount <= this.balance){
            balance -= amount;
            Console.WriteLine($"Withdrew: {amount}. New balance: {this.balance}");
        }
        else
            Console.WriteLine("Invalid withdrawal amount.");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(1000);
        account.Deposit(200);
        account.Withdraw(150);
        Console.WriteLine($"Final Balance: {account.GetBalance()}");
        // should display 1050
    }
}
