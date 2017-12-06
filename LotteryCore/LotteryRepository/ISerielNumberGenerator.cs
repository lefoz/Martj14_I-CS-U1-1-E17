using System.Collections.Generic;

namespace LotteryCore.LotteryRepository
{
    public interface ISerielNumberGenerator
    {
        Dictionary<string, bool> GenerateSerielNumberDictionary(int amount);
    }
}