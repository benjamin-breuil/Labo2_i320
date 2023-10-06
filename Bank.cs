class Bank {
    public List<Customer> Customers = new List<Customer>();
    public List<BankAccount> BankAccounts = new List<BankAccount>();

    public Customer RegisterCustomer(String firstName, String lastName)
    {
        Customer newCustomer = new Customer(firstName, lastName); 

        bool CustomerExists = false;

        foreach (Customer customer in Customers)
        {
            if (newCustomer.IsEqual(customer))
            {
                CustomerExists = true;
                break; 
            }
        }

        if (!CustomerExists)
        {
            Customers.Add(newCustomer);
        }
            return newCustomer;
    }

    public BankAccount CreateAccount(String firstName, String lastName)
    {

        Customer AccountOwner = null;

        int index = 0;
        foreach(Customer customer in Customers)
        {
            if (customer.FirstName == firstName && customer.LastName == lastName)
            {
                AccountOwner = customer; 
                break; 
            }
         index++;
        }

        if (AccountOwner == null)
        {
               AccountOwner = RegisterCustomer(firstName, lastName);
        }

        BankAccount newBankAccount = new BankAccount(AccountOwner, 0);
        BankAccounts.Add(newBankAccount);
        return newBankAccount;
    }

    public List<BankAccount> GetCustomerSummary(Customer customer)
    {
        List<BankAccount> CustomerAccount = new List<BankAccount>();
        int index = 1;
        float total = 0;
        Console.WriteLine("«-------------");
        Console.WriteLine($"{customer.FirstName} {customer.LastName}");
        foreach(BankAccount bankAccount in BankAccounts)
        {
            if(bankAccount.Owner.IsEqual(customer))
            {
                CustomerAccount.Add(bankAccount);
                Console.WriteLine($"- Compte #{index++} : {bankAccount.Balance}");
                total += bankAccount.Balance;
            }
        }
        Console.WriteLine($"Fortune totale : {total}");
        Console.WriteLine("--------------»");

        return CustomerAccount;
    }

}