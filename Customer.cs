class Customer
{
    public String FirstName;
    public String LastName;

    public Customer(String firstName, String lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    
    public bool IsEqual(Customer customer)
    {
        return this.FirstName == customer.FirstName
            && this.LastName == customer.LastName;
    }

}