namespace Movie.Application.Infrastructure.Commands
{
    public class CommandExecutor
    {
        public CommandExecutionResult Execute(Command command)
        {
            return command.Execute();
        }
    }
}
