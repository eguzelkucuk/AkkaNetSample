using Akka.Actor;
using OnlineOrdering.Common.Messages;
using System;

namespace OnlineOrdering.Common.Actors
{
    /// <summary>
    /// Responsible for processing order
    /// </summary>
    public class ProcessOrder : ReceiveActor
    {
        public ProcessOrder()
        {
            Receive<Order>(m => Console.WriteLine("Order received for processing. {0}", m));
        }
    }
}