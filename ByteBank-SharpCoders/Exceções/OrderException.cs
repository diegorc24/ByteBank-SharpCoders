using System.Runtime.Serialization;

namespace ByteBank_SharpCoders.Exceções
{
    public class OrderException : Exception
    {    
        public OrderException(string message) : base(message)
        {
        }      
    }
}