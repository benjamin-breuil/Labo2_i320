Bank bank = new Bank();

Customer johnDoe = bank.RegisterCustomer("John", "Doe");
Customer suzetteProust = bank.RegisterCustomer("Suzette", "Proust");
Customer gillesSurchat = bank.RegisterCustomer("Gilles", "Surchat");

BankAccount account1_johndoe = bank.CreateAccount(johnDoe.FirstName, johnDoe.LastName);
BankAccount account2_johndoe = bank.CreateAccount(johnDoe.FirstName, johnDoe.LastName);
BankAccount account1_suzetteProust = bank.CreateAccount(suzetteProust.FirstName, suzetteProust.LastName);

account1_johndoe.Credit(200);
account2_johndoe.Credit(100);
account1_johndoe.Debit(50);
account1_suzetteProust.Credit(100);
account1_suzetteProust.Debit(200);
//account1_johndoe.Debit(50);
//account1_suzetteProust.Credit(50);
account1_johndoe.Transfer(50, account1_suzetteProust);
account1_suzetteProust.Debit(200);
account1_suzetteProust.Transfer(200, account1_johndoe);

bank.GetCustomerSummary(johnDoe);
bank.GetCustomerSummary(suzetteProust);
bank.GetCustomerSummary(gillesSurchat);


