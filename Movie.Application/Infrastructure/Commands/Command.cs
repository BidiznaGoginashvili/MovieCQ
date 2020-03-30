using System;

namespace Movie.Application.Infrastructure.Commands
{
    public abstract class Command
    {
        public abstract CommandExecutionResult Execute();

        protected CommandExecutionResult Fail(Exception exception)
        {
            return new CommandExecutionResult
            {
                Success = false,
                Exception = exception
            };
        }

        protected CommandExecutionResult Ok()
        {
            return new CommandExecutionResult
            {
                Success = true,
                Exception = null
            };
        }
    }
}
