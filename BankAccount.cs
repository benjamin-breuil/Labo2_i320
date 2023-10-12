class BankAccount {
    public Customer Owner;
    public float Balance;
    public int AccountNumber;

    public BankAccount(Customer owner, float balance)
    {
        Owner = owner;
        Balance = balance;
    }

    public void Credit(float montant)
    {
        Balance += montant;
        Console.WriteLine($"Compte de {Owner.FirstName} {Owner.LastName} : +{montant}");
    }

    public bool Debit(float montant)
    {
        if(Balance >= montant)
        {
            Balance -= montant;
            Console.WriteLine($"Compte de {Owner.FirstName} {Owner.LastName}: -{montant}");
            return true;
        } 
        else
        {
            Console.WriteLine($"Compte de {Owner.FirstName} {Owner.LastName}: solde insuffisant ({montant})");
            return false;
        }
    }

    public bool Transfer(float montant, BankAccount bankAccount){
        
        if(Balance >= montant)
        {
            //bankAccount.Balance += montant;
            //Balance -= montant;
            Debit(montant);
            bankAccount.Credit(montant);

            Console.WriteLine($"Transfert du compte de {Owner.FirstName} {Owner.LastName} au compte de {bankAccount.Owner.FirstName} {bankAccount.Owner.LastName} réussi : {montant}");
            return true;
        }
        else
        {
            
            Console.WriteLine($"Transfert du compte de {Owner.FirstName} {Owner.LastName} au compte de {bankAccount.Owner.FirstName} {bankAccount.Owner.LastName} échoué: solde insuffisant ({montant})");
            return false;
        }
    }
}