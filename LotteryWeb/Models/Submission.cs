using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace LotteryWeb.Models
{
    [Serializable]
    public class Submission
    {
        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; }
        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; }
        [Required]
        [Display(Name = "Email")]
        public string Email { get; }
        [Required]
        [Display(Name = "Phone Number")]
        public string Phonenumber { get; }
        [Required]
        [Display(Name = "Bithdate")]
        public string Birthdate { get; }
        [Required]
        [Display(Name = "Password")]
        public string Password { get; }
        [Required]
        [Display(Name = "Serial NUmber")]
        public IList<string> LotterySerial;
        public DateTime SubmissionDate { get; }

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
        public Submission(string firstName, string lastName, string email, string phonenumber, string birthdate, string password, string lotterySerial)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phonenumber = phonenumber;
            Birthdate = birthdate;
            Password = password;
            LotterySerial.Add(lotterySerial);
            SubmissionDate = DateTime.Now;
        }
    }
}
