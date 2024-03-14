// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using System;

namespace Car.Crud.Broker.LoggingBroker
{
    internal interface ILoggingBroker
    {
        void LogErorr(string message);
        void LogInformation(string message);
        void LogError(Exception exception);

    }
}
