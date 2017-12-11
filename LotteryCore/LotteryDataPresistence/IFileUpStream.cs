using System.Collections.Generic;
using Martj14.Models;

namespace LotteryCore.LotteryDataPresistence
{
    public interface IFileUpStream
    {
        List<string> LoadLoginsFromFile();
        List<string> LoadSerielNumbersFromFile();
        List<Submission> LoadSubmissionsFromFile();
    }
}