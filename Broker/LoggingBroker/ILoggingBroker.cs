// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

namespace Car.Crud.Broker.LoggingBroker
{
    internal interface ILoggingBroker
    {
        void LogInformation(string message);
        void LogError(Exception exception);

    }
}
