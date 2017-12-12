using System.Collections.Generic;
using LotteryCore.Model;

namespace LotteryCore.LotteryDataPresistence
{
    public interface IFileUpStream
    {
        List<string> LoadLoginsFromFile();
        List<string> LoadSerielNumbersFromFile();
        List<Submission> LoadSubmissionsFromFile();
    }
}