namespace ATM.Domain
{
    /// <summary>
    /// Defines a command interface with a method for executing a command.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Executes the command.
        /// </summary>
        void Execute();
    }
}