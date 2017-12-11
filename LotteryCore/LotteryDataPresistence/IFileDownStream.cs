using System.Collections.Generic;
using Martj14.Models;

namespace LotteryCore.LotteryDataPresistence
{
    public interface IFileDownStream
    {
        void SaveLoginsToFile(string email,string password);
        void SaveSerielNumbersToFile(Dictionary<string, bool> serielnumbers);
        void SaveSubmissionsToFile(List<Submission> submissions);
    }
}