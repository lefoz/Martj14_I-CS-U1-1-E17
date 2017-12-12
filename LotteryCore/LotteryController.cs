using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using LotteryCore.LotteryDataPresistence;
using LotteryCore.LotteryRepository;
using LotteryCore.LotterySecurity;
using LotteryCore.Model;




namespace LotteryCore
{
    class LotteryController : ILotteryController
    {
        
        private ILoginInformation loginInformation;
        private ISerielNumberRepository serielNumberRepository;
        private IFileDownStream putDownStream;
        private IFileUpStream getFileUpStream;
        private List<Submission> submissionList;
        private Dictionary<string, string> logins;
        private Dictionary<string, bool> lotteryDictionary;

        public LotteryController()
        {
            loginInformation = new LoginInformation();
            serielNumberRepository = new SerielNumberRepository();
            putDownStream = new FileDownStream();
            getFileUpStream = new FileUpStream();
            logins = new Dictionary<string, string>();
            lotteryDictionary = new Dictionary<string, bool>();
            submissionList = new List<Submission>();
            submissionList = getFileUpStream.LoadSubmissionsFromFile();
            loginInformation.LoadLoginsToDictinary(logins);
            serielNumberRepository.SerielNumbersFromFile(lotteryDictionary);

        }
        public void AddSubmission(Submission submission)
        {
            if (CheckForPriorRegistration(submission.LastName, submission.Email, submission.Birthdate))
            {
                int serielchecker = serielNumberRepository.LookUpSerielNumber(submission.LotterySerial[0], lotteryDictionary);
                switch (serielchecker)
                {
                    case 0:
                        //Seriel number do not exist
                        break;
                    case 1:
                        //Seriel has already been claimed
                        break;
                    case 2:
                        //Seriel is unclamied, now being claimed by this submission
                        submissionList.Add(new Submission(submission.FirstName, submission.LastName, submission.Email, submission.Phonenumber, submission.Birthdate, submission.Password, submission.LotterySerial[0]));
                        loginInformation.AddLogin(submission.Email, submission.Password, logins);
                        putDownStream.SaveSubmissionsToFile(submissionList);
                        break;
                    default:
                        break;
                }

            }
        }

        private bool CheckForPriorRegistration(string lastName, string email, string birthdate)
        {
            var alreadyPresent = submissionList.Where(x => x.Email.Equals(email) && x.LastName.Equals(lastName) && x.Birthdate.Equals(birthdate));
            if (!alreadyPresent.Any()) return true;
            return false;
        }

        public bool AddSerialToExistingSubmisson(string email, string serial)
        {
            int result = serielNumberRepository.LookUpSerielNumber(serial, lotteryDictionary);
            if (result == 2)
            {
                foreach (var sub in submissionList)
                {
                    if (sub.Email.Equals(email)) sub.LotterySerial.Add(serial);
                    return true;
                }
            }
            return false;
        }
    }
}
