namespace Payment.Domain
{
    /// <summary>
    /// Represents a payment strategy for handling credit card payments.
    /// </summary>
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        /// <summary>
        /// Processes a payment using a credit card.
        /// </summary>
        /// <param name="amount">The amount to be paid using the credit card.</param>
        /// <returns>
        /// Returns <c>true</c> to indicate that the payment was successfully processed.
        /// </returns>
        public bool Pay(double amount)
        {
            Console.WriteLine("Customer pays Rs " + amount + " using Credit Card");
            return true;
        }
    }
}