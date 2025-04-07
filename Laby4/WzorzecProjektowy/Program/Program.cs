using System;

public class Customer
{
    public string Name { get; set; }
    public decimal Savings { get; set; }
    public bool HasActiveLoans { get; set; }
    public int CreditScore { get; set; }
}

// Podsystem 1
public class BankService
{
    public bool HasSufficientSavings(Customer customer)
    {
        Console.WriteLine($"Sprawdzanie oszczędności klienta: {customer.Savings} zł");
        return customer.Savings >= 5000;
    }
}

// Podsystem 2
public class LoanService
{
    public bool HasLoans(Customer customer)
    {
        Console.WriteLine($"Czy klient ma aktywne pożyczki? {customer.HasActiveLoans}");
        return !customer.HasActiveLoans;
    }
}

// Podsystem 3
public class CreditService
{
    public bool HasCredit(Customer customer)
    {
        Console.WriteLine($"Punktacja kredytowa klienta: {customer.CreditScore}");
        return customer.CreditScore >= 600;
    }
}

// Fasada
public class CreditEligibilityFacade
{
    private BankService _bankService;
    private LoanService _loanService;
    private CreditService _creditService;

    public CreditEligibilityFacade()
    {
        _bankService = new BankService();
        _loanService = new LoanService();
        _creditService = new CreditService();
    }

    public bool IsEligibleForCredit(Customer customer)
    {
        if (_bankService.HasSufficientSavings(customer))
        {
            return _loanService.HasLoans(customer);
        }
        else
        {
            return _loanService.HasLoans(customer) && _creditService.HasCredit(customer);
        }
    }
}

// Klient
public class Program
{
    public static void Main(string[] args)
    {
        var customer = new Customer
        {
            Name = "Jan Kowalski",
            Savings = 5500m,
            HasActiveLoans = true,
            CreditScore = 650
        };

        var creditFacade = new CreditEligibilityFacade();

        bool eligible = creditFacade.IsEligibleForCredit(customer);

        Console.WriteLine($"\nCzy {customer.Name} kwalifikuje się do kredytu? {(eligible ? "TAK" : "NIE")}");
    }
}
