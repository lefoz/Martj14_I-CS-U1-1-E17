using LotteryWeb.Models;

namespace LotteryCore
{
    interface ILotteryController
    {
        bool AddSerialToExistingSubmisson(string email, string serial);
        void AddSubmission(Submission submission);
    }
}