using System.Collections.Generic;

namespace LotteryCore.LotterySecurity
{
    interface ILoginInformation
    {
        void AddLogin(string email, string password, Dictionary<string, string> Logins);
        bool CheckLogin(string email, string password, Dictionary<string, string> Logins);
        void LoadLoginsToDictinary(Dictionary<string, string> Logins);
    }
}