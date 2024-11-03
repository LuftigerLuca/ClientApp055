using System;

namespace De.HsFlensburg.ClientApp055.Services.MessageBus
{
    public interface IServiceBus
    {
        void Register<TNotification>(object listener, Action action);
        void Send<TNotification>(TNotification notification);
        void Unregister<TNotification>(object listener);
    }
}