static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        float interestRate = 0.0F;
        if (balance < 0)
            interestRate = 3.213F;
        else if (balance < 1000)
            interestRate = 0.5F;
        else if (balance >= 1000 && balance < 5000)
            interestRate = 1.621F;
        else if (balance >= 5000)
            interestRate = 2.475F;

        return interestRate;

        throw new NotImplementedException("Please implement the (static) SavingsAccount.InterestRate() method");
    }

    public static decimal Interest(decimal balance)
    {
        decimal interestRate = (decimal)InterestRate(balance);
        decimal interest = (interestRate * balance) / 100;
        return interest;
        throw new NotImplementedException("Please implement the (static) SavingsAccount.Interest() method");
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        decimal interest = Interest(balance);
        return balance + interest;
        throw new NotImplementedException("Please implement the (static) SavingsAccount.AnnualBalanceUpdate() method");
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int minNumOfYears = 0;

        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            minNumOfYears++;
        }

        return minNumOfYears;
    }
}
