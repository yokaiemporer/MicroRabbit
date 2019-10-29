using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MicroRabbit.Domain.Core.Commands;
using MicroRabbit.Domain.Core.Events;
using RabbitMQ.Client.Impl;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;
        //Add @ before event to make a non predefined keyword but a custom keyword in c#
        void Publish<T>(T @event) where T : EventArgs;
        //T-stands for event type,TH-stands for Event Handler
        void Subscribe<T, TH>()
            where T : Event
            where TH:IEventHandler<T>;
    }
}
