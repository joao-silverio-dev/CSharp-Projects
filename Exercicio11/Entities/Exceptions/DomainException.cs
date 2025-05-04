using System;

namespace Exercicio11.Entities.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
            
        }
    }
}