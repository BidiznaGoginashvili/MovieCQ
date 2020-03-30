namespace Movie.Application.Infrastructure.Events
{
    public abstract class EventHandler<TCommand> 
    {
        public abstract void Handle(TCommand command);
    }
}
