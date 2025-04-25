using System;

namespace ATM.Domain
{
    /// <summary>
    /// Represents a bank account with basic operations such as deposit and withdrawal.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// The maximum allowable amount for a single deposit transaction.
        /// </summary>
        public const decimal MAX_INPUT_AMOUNT = 10000;

        /// <summary>
        /// Gets or sets the unique account number.
        /// </summary>
        public int AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the current balance of the account.
        /// </summary>
        public decimal AccountBalance { get; set; }

        /// <summary>
        /// Withdraws a specified amount from the account balance.
        /// </summary>
        /// <param name="amount">The amount to withdraw.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when the withdrawal amount exceeds the current account balance.
        /// </exception>
        public void Withdraw(decimal amount)
        {
            if (amount > AccountBalance) 
                throw new ArgumentException("The input amount is greater than balance.");
            AccountBalance -= amount;            
        }

        /// <summary>
        /// Deposits a specified amount into the account balance.
        /// </summary>
        /// <param name="amount">The amount to deposit.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when the deposit amount exceeds the maximum allowable limit.
        /// </exception>
        public void Deposit(decimal amount)
        {
            if (amount > MAX_INPUT_AMOUNT) 
                throw new ArgumentException("The input amount is greater than maximum allowed.");
            AccountBalance += amount;            
        }
    }
}