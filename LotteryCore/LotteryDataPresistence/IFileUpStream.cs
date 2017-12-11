using System.Collections.Generic;
using LotteryWeb.Models;

namespace LotteryCore.LotteryDataPresistence
{
    public interface IFileUpStream
    {
        List<string> LoadLoginsFromFile();
        List<string> LoadSerielNumbersFromFile();
        List<Submission> LoadSubmissionsFromFile();
    }
}