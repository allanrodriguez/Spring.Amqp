using RabbitMQ.Client.Exceptions;
using System;

namespace Spring.Amqp.Rabbit.Connection
{
    public interface IConnectionFactory
    {
        event EventHandler<IConnection> ConnectionCreated;
        event EventHandler<IConnection> ConnectionClosed;
        event EventHandler<OperationInterruptedException> ConnectionShutDown;

        string Host { get; }

        int Port { get; }

        string VirtualHost { get; }

        string Username { get; }

        /// <summary>
        /// Returns a separate connection factory for publishers.
        /// </summary>
        IConnectionFactory PublisherConnectionFactory { get; }

        /// <summary>
        /// Returns true if simple publisher confirms are enabled.
        /// </summary>
        bool IsSimplePublisherConfirms { get; }

        /// <summary>
        /// Returns true if publisher confirms are enabled.
        /// </summary>
        bool IsPublisherConfirms { get; }

        /// <summary>
        /// Return true if publisher returns are enabled.
        /// </summary>
        bool IsPublisherReturns { get; }

        IConnection CreateConnection();
    }
}
