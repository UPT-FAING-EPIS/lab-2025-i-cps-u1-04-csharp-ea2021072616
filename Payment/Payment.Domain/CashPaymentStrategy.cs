namespace Payment.Domain
{
    /// <summary>
    /// Represents a payment strategy for handling cash payments.
    /// </summary>
    public class CashPaymentStrategy : IPaymentStrategy
    {
        /// <summary>
        /// Processes a payment using cash.
        /// </summary>
        /// <param name="amount">The amount to be paid in cash.</param>
        /// <returns>
        /// Returns <c>true</c> to indicate that the payment was successfully processed.
        /// </returns>
        public bool Pay(double amount)
        {
            Console.WriteLine("Customer pays Rs " + amount + " By Cash");
            return true;
        }
    }
}