using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace ExceptionCustom
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                throw new UserLoggedInException("User is logged in");
            }
            catch (UserLoggedInException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }

    [Serializable]
    public class UserLoggedInException : Exception 
    { 
        public UserLoggedInException() : base()
        {

        }
        public UserLoggedInException(string message) : base(message)
        {

        }

        public UserLoggedInException(string msg, Exception innerException) 
            : base(msg, innerException)
        {

        }

        public UserLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }

}
