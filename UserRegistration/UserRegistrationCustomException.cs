using System;


namespace UserRegistration
{
    public class UserRegistrationCustomException:Exception
    {
        ///<param name="message"></param>
        public UserRegistrationCustomException(string message) : base(message)
        {
           
        }
    }
}
