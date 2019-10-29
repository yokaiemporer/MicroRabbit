using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbit.Domain.Core.Commands;
namespace MicroRabbit.Domain.Core.Commands
{
    public abstract class command : Message
    {
        public DateTime Timestamp{get; protected set;}
    protected command()
    {
        Timestamp = DateTime.Now;
    }
    }
}
