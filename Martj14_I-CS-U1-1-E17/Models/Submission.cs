using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Martj14.Models
{
    public class Submission
    {
        private string _firstName { get; set; }
        private string _lastName { get; set; }
        private string _email { get; set; }
        private string _phonenumber { get; set; }
        private string _birthdate { get; set; }
        private string _password { get; set; }
        private string _lotterySerial { get; set; }
        private DateTime _submissionDate { get; set; }

        /// <summary>
        /// Model for Submission
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="phonenumber"></param>
        /// <param name="birthdate"></param>
        /// <param name="password"></param>
        /// <param name="lotterySerial"></param>
        /// <param name="submissionDate"></param>
        public Submission(string firstName, string lastName, string email, string phonenumber, string birthdate, string password, string lotterySerial, DateTime submissionDate)
        {
        _firstName = firstName;
        _lastName = lastName;
        _email = email;
        _phonenumber = phonenumber;
        _birthdate = birthdate;
        _password = password;
        _lotterySerial = lotterySerial;
        _submissionDate = DateTime.Now;
    }
}
}
