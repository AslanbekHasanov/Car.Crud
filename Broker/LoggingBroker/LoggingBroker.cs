// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Car.Crud.Broker.LoggingBroker;
using System;

namespace Car.Crud
{
    public class LoggingBroker : ILoggingBroker
    {
        public void LogErorr(string message) =>
            Console.WriteLine(message);

        public void LogError(Exception exception) =>
            Console.WriteLine(exception);

        public void LogInformation(string message)=>
            Console.WriteLine(message);
    }
}