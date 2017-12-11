namespace LotteryCore.LotteryRepository
{
    public interface ISerielNumberRepository
    {
        void GenerateNewSerielNumbers(int amount);
        int LookUpSerielNumber(string serielnumber);
        bool SerielNumbersFromFile();
        void SerielNumbersToFile();
    }
}