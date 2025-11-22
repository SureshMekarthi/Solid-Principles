using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles
{
    internal class UserRegisterService
    {
        private readonly EmailValidation _emailValidation;
        private readonly UserRepository _userRepository;
        private readonly EmailNotification _emailNotification;

        public UserRegisterService()
        {
            _emailValidation = new EmailValidation();
            _userRepository = new UserRepository();
            _emailNotification = new EmailNotification();
        }

        public void RegisterUser(string email)
        {
            if (!_emailValidation.IsValidateEmail(email))
            {
                throw new Exception("Invalid email address");
            }
            _userRepository.SaveUser(email);
            _emailNotification.SendWelcomeEmail(email);
        }
    }
}
