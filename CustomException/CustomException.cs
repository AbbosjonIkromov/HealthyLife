using System;
namespace CustomException
{
    public class InvalidUserCredentialsException : Exception
    {
        public const string Code = "invalid_user_credentials";

        public InvalidUserCredentialsException() : base("Username or password is incorrect") { }
    }
}