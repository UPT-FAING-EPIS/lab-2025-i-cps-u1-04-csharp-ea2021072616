namespace Payment.Domain
{
    /// <summary>
    /// Defines a strategy for processing payments.
    /// </summary>
    public interface IPaymentStrategy
    {
        /// <summary>
        /// Processes a payment with the specified amount.
        /// </summary>
        /// <param name="amount">The amount to be paid.</param>
        /// <returns>
        /// Returns <c>true</c> if the payment was successfully processed; otherwise, <c>false</c>.
        /// </returns>
        bool Pay(double amount);
    }
}