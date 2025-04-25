namespace ATM.Domain
{
    /// <summary>
    /// Represents a command to withdraw a specified amount from an account.
    /// </summary>
    public class WithdrawCommand : ICommand
    {
        /// <summary>
        /// The account from which the withdrawal will be made.
        /// </summary>
        private Account _account;

        /// <summary>
        /// The amount to be withdrawn from the account.
        /// </summary>
        private decimal _amount;

        /// <summary>
        /// Initializes a new instance of the <see cref="WithdrawCommand"/> class with the specified account and amount.
        /// </summary>
        /// <param name="account">The account from which the withdrawal will be made.</param>
        /// <param name="amount">The amount to withdraw.</param>
        public WithdrawCommand(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;
        }

        /// <summary>
        /// Executes the withdrawal command by deducting the specified amount from the account balance.
        /// </summary>
        public void Execute()
        {
            _account.Withdraw(_amount);
        }
    }
}