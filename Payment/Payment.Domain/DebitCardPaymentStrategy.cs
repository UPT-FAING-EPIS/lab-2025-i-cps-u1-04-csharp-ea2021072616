namespace Payment.Domain
{
    /// <summary>
    /// Represents a payment strategy for handling debit card payments.
    /// </summary>
    public class DebitCardPaymentStrategy : IPaymentStrategy
    {
        /// <summary>
        /// Processes a payment using a debit card.
        /// </summary>
        /// <param name="amount">The amount to be paid using the debit card.</param>
        /// <returns>
        /// Returns <c>true</c> to indicate that the payment was successfully processed.
        /// </returns>
        public bool Pay(double amount)
        {
            Console.WriteLine("Customer pays Rs " + amount + " using Debit Card");
            return true;
        }
    }
}