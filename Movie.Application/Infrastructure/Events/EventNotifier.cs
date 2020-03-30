using System;
using System.Linq;
using System.Reflection;

namespace Movie.Application.Infrastructure.Events
{
    public class EventNotifier
    {
        public void Notify<TCommand>(TCommand command)
        {
            InvokeHandler<TCommand>(command);
        }

        protected void InvokeHandler<TCommand>(TCommand command)
        {
            try
            {
                Invoke(command);
            }
            catch (Exception exception) 
            {

            }
        }

        protected void Invoke<TCommand>(TCommand command)
        {
            var handler = Assembly.GetExecutingAssembly().GetTypes()
                           .Where(t => t.IsSubclassOf(typeof(EventHandler<TCommand>))).FirstOrDefault();

            var instance = Activator.CreateInstance(handler);

            var parameters = new object[] { (TCommand)Activator.CreateInstance(typeof(TCommand)) };

            handler.GetMethod("Handle").Invoke(instance, parameters);
        }
    }
}
