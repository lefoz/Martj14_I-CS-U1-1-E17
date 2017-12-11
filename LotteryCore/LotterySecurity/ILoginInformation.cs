namespace LotteryCore.LotterySecurity
{
    interface ILoginInformation
    {
        void AddLogin(string email, string password);
        bool CheckLogin(string email, string password);
        void LoadLoginsToDictinary();
    }
}