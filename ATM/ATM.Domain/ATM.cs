namespace ATM.Domain
{
    /// <summary>
    /// Represents an ATM that executes a specific command.
    /// </summary>
    public class ATM
    {
        /// <summary>
        /// The command to be executed by the ATM.
        /// </summary>
        private ICommand _command;

        /// <summary>
        /// Initializes a new instance of the <see cref="ATM"/> class with the specified command.
        /// </summary>
        /// <param name="command">The command to be executed by the ATM.</param>
        public ATM(ICommand command)
        {
            _command = command;
        }

        /// <summary>
        /// Executes the action associated with the command.
        /// </summary>
        public void Action()
        {
            _command.Execute();
        }
    }
}