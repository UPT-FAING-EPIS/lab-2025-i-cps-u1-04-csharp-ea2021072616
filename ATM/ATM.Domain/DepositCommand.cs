namespace ATM.Domain
{
    /// <summary>
    /// Represents a command to deposit a specified amount into an account.
    /// </summary>
    public class DepositCommand : ICommand
    {
        /// <summary>
        /// The account where the deposit will be made.
        /// </summary>
        private Account _account;

        /// <summary>
        /// The amount to be deposited into the account.
        /// </summary>
        private decimal _amount;

        /// <summary>
        /// Initializes a new instance of the <see cref="DepositCommand"/> class with the specified account and amount.
        /// </summary>
        /// <param name="account">The account where the deposit will be made.</param>
        /// <param name="amount">The amount to deposit.</param>
        public DepositCommand(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;
        }

        /// <summary>
        /// Executes the deposit command by adding the specified amount to the account balance.
        /// </summary>
        public void Execute()
        {
            _account.Deposit(_amount);
        }        
    }
}