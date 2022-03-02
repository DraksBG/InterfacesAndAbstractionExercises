
using System;
using System.Linq;
using T03.Contracts;
using T03.Exceptions;

namespace T03.Models
{
   public class Smartphone : ICallable, IBrowseable
    {

        public string Call(string number)
        {
            if (!number.All(c => char.IsDigit(c)))
            {
                throw new ArgumentException(ExceptionMesseges.InvalidNumberException);
            }

            return number.Length > 7 ? $"Calling... {number}" : $"Dialing... {number}";
        }

        public string Browse(string url)
        {
            if (url.Any(c => char.IsDigit(c)))
            {
                throw new ArgumentException(ExceptionMesseges.InvalidUrlException);
            }

            return $"Browsing: {url}!";
        }
    }
}
