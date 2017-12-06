using System.Collections.Generic;

namespace LotteryCore.LotteryRepository
{
    interface ISerielNumberGenereter
    {
        Dictionary<string, bool> GenerateSerielNumberDictionary(int amount);
    }
}