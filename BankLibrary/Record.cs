namespace BankLibrary
{
    public class Record
    {
        // Auto-implemented properties
        public int Account { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }

        // Parameterless constructor sets members to default values
        public Record() : this(0, string.Empty, string.Empty, 0M)
        {
        }

        // Overloaded constructor sets members to parameter values
        public Record(int accountValue, string firstNameValue, string lastNameValue, decimal balanceValue)
        {
            Account = accountValue;
            FirstName = firstNameValue;
            LastName = lastNameValue;
            Balance = balanceValue;
        }
    }
}
