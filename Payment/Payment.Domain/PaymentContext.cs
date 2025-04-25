namespace Payment.Domain
{
    /// <summary>
    /// Represents the context for processing payments using a specified payment strategy.
    /// </summary>
    public class PaymentContext
    {
        /// <summary>
        /// The payment strategy to be used for processing payments.
        /// </summary>
        private IPaymentStrategy PaymentStrategy;

        /// <summary>
        /// Sets the payment strategy to be used by the context.
        /// </summary>
        /// <param name="strategy">The payment strategy to use.</param>
        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            PaymentStrategy = strategy;
        }

        /// <summary>
        /// Processes a payment using the currently set payment strategy.
        /// </summary>
        /// <param name="amount">The amount to be paid.</param>
        /// <returns>
        /// Returns <c>true</c> if the payment was successfully processed; otherwise, <c>false</c>.
        /// </returns>
        public bool Pay(double amount)
        {
            return PaymentStrategy.Pay(amount);
        }
    }
}