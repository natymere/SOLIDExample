using System;

namespace SingleResponsibilityPrinciple
{
    interface IUser
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string email);
        // void LogError(string error);
        // bool SendEmail(string emailContent);
    }

    interface ILogger
    {
        void LogError(string error);
    }

    interface IEmail
    {
        void SendEmail(string emailContent);
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}