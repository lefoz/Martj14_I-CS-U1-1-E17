﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using LotteryCore.LotteryDataPresistence;
using LotteryCore.LotterySecurity;
using LotteryWeb.Models;

namespace LotteryCore.LotteryRepository
{
    public class SubmissionRepository : ISubmissionRepository
    {
        //ISerielNumberRepository serielRepo = new SerielNumberRepository();
        //ILoginInformation loginInformation = new LoginInformation();
        //IFileDownStream putDownStream = new FileDownStream();
        ////IFileUpStream getFileUpStream = new FileUpStream();
        ////List<Submission> submissionList;
        

        //public void AddSubmission(Submission submission, List<Submission> submissionList)
        //{
        //    if (CheckForPriorRegistration(submission.LastName, submission.Email, submission.Birthdate, submissionList))
        //    {
        //        int serielchecker = serielRepo.LookUpSerielNumber(submission.LotterySerial[0]);
        //        switch (serielchecker)
        //        {
        //            case 0:
        //                //Seriel number do not exist
        //                break;
        //            case 1:
        //                //Seriel has already been claimed
        //                break;
        //            case 2:
        //                //Seriel is unclamied, now being claimed by this submission
        //                submissionList.Add(new Submission(submission.FirstName,submission.LastName,submission.Email,submission.Phonenumber,submission.Birthdate,submission.Password,submission.LotterySerial[0]));
        //                loginInformation.AddLogin(submission.Email,submission.Password);
        //                putDownStream.SaveSubmissionsToFile(submissionList);
        //                break;
        //            default:
        //                break;
        //        }

        //    }
        //}

        //private bool CheckForPriorRegistration(string lastName, string email, string birthdate, List<Submission> submissionList)
        //{
        //    var alreadyPresent = submissionList.Where(x => x.Email.Equals(email) && x.LastName.Equals(lastName)&&x.Birthdate.Equals(birthdate));
        //    if (!alreadyPresent.Any()) return true;
        //    return false;
        //}

        //public bool AddSerialToExistingSubmisson(List<Submission> submissionList, string email, string serial)
        //{
        //    int result = serielRepo.LookUpSerielNumber(serial);
        //    if (result == 2)
        //    {
        //        foreach (var sub in submissionList)
        //        {
        //           if(sub.Email.Equals(email)) sub.LotterySerial.Add(serial);
        //           return true;
        //        }
        //    }
        //    return false;
        //}
    }
}
