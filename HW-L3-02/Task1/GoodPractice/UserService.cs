using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.GoodPractice
{
    public class UserService
    {
        private readonly UserRepository _repository;
        private readonly EmailService _emailService;

        public UserService(UserRepository repository, EmailService emailService)
        {
            _repository = repository;
            _emailService = emailService;
        }

        public void RegisterUser(string username, string email)
        {
            _repository.Save(username, email);
            _emailService.SendEmail(email);
        }
    }

}
