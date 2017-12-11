﻿using System;
using System.Collections.Generic;
using System.Text;
using LotteryCore.LotteryDataPresistence;

namespace LotteryCore.LotterySecurity
{
    class LoginInformation : ILoginInformation
    {
        //internal Dictionary<string,string> Logins = new Dictionary<string, string>();
        private IFileDownStream saveToFile = new FileDownStream();
        private IFileUpStream loadFromFile = new FileUpStream();

        public void AddLogin(string email, string password, Dictionary<string, string> logins)
        {
            logins.Add(email,password);
            saveToFile.SaveLoginsToFile(email,password);
        }

        public bool CheckLogin(string email, string password, Dictionary<string, string> logins)
        {
            if (logins.ContainsKey(email))
            {
                if (logins[email].Equals(password)) return true;
            }
            return false;
        }

        public void LoadLoginsToDictinary(Dictionary<string, string> Logins)
        {
            List<string> tempList = loadFromFile.LoadLoginsFromFile();
            if (tempList != null|| tempList.Count>0)
            {
                foreach (var item in tempList)
                {

                    int devidIndex = item.IndexOf("|");
                    string email = item.Substring(0, devidIndex);
                    string password = item.Substring(devidIndex + 1);
                    Logins.Add(email, password);
                }
            }
        }
    }
}
