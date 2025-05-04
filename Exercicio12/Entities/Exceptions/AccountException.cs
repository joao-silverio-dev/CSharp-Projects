using System;

namespace Exercicio12.Entities.Exceptions
{
    public class AccountException : ApplicationException
    {
        public AccountException(string message) : base(message) {}
    }
}