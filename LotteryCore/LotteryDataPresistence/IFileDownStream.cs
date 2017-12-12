using System.Collections.Generic;
using LotteryCore.Model;

namespace LotteryCore.LotteryDataPresistence
{
    public interface IFileDownStream
    {
        void SaveLoginsToFile(string email,string password);
        void SaveSerielNumbersToFile(Dictionary<string, bool> serielnumbers);
        void SaveSubmissionsToFile(List<Submission> submissions);
    }
}