namespace Payment.Domain
{
    /// <summary>
    /// Provides services for processing payments using different payment strategies.
    /// </summary>
    public class PaymentService
    {
        /// <summary>
        /// Processes a payment based on the selected payment type and amount.
        /// </summary>
        /// <param name="SelectedPaymentType">The type of payment selected (e.g., CreditCard, DebitCard, Cash).</param>
        /// <param name="Amount">The amount to be paid.</param>
        /// <returns>
        /// Returns <c>true</c> if the payment was successfully processed; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Thrown when an invalid payment option is selected.
        /// </exception>
        public bool ProcessPayment(int SelectedPaymentType, double Amount)
        {
            // Create an instance of the PaymentContext class
            PaymentContext context = new PaymentContext();

            // Set the appropriate payment strategy based on the selected payment type
            if (SelectedPaymentType == (int)PaymentType.CreditCard)
            {
                context.SetPaymentStrategy(new CreditCardPaymentStrategy());
            }
            else if (SelectedPaymentType == (int)PaymentType.DebitCard)
            {
                context.SetPaymentStrategy(new DebitCardPaymentStrategy());
            }
            else if (SelectedPaymentType == (int)PaymentType.Cash)
            {
                context.SetPaymentStrategy(new CashPaymentStrategy());
            }
            else
            {
                throw new ArgumentException("You Select an Invalid Payment Option");
            }

            // Finally, call the Pay method
            return context.Pay(Amount);
        }
    }

    /// <summary>
    /// Represents the different types of payment methods available.
    /// </summary>
    public enum PaymentType
    {
        /// <summary>
        /// Payment using a credit card.
        /// </summary>
        CreditCard = 1,

        /// <summary>
        /// Payment using a debit card.
        /// </summary>
        DebitCard = 2,

        /// <summary>
        /// Payment using cash.
        /// </summary>
        Cash = 3,
    }
}