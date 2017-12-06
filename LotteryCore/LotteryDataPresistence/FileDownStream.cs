using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LotteryCore.LotteryDataPresistence
{
    public class FileDownStream
    {
        private readonly string _serielNumberFileName = "SerielNumbers.dat";
        private readonly string _submissionsFileName = "SerielNumbers.dat";
        private readonly string _loginsFileName = "SerielNumbers.dat";

        public void SaveSerielNumbersToFile(Dictionary<string, bool> serielnumbers)
        {
            using (StreamWriter streamWriter = new StreamWriter(_serielNumberFileName))
            {
                foreach (KeyValuePair<string, bool> kvp in serielnumbers)
                {
                    string save = kvp.Key+"|"+kvp.Value;
                    streamWriter.WriteLine(save);
                }
            }
        }

        public void SaveSubmissionsToFile(Dictionary<string, bool> submissions)
        {
            using (StreamWriter streamWriter = new StreamWriter(_submissionsFileName))
            {
                foreach (KeyValuePair<string, bool> kvp in submissions)
                {
                    string save = kvp.Key + "|" + kvp.Value;
                    streamWriter.WriteLine(save);
                }
            }
        }

        public void SaveLoginsToFile(Dictionary<string, bool> logins)
        {
            using (StreamWriter streamWriter = new StreamWriter(_loginsFileName))
            {
                foreach (KeyValuePair<string, bool> kvp in logins)
                {
                    string save = kvp.Key + "|" + kvp.Value;
                    streamWriter.WriteLine(save);
                }
            }
        }
    }
}
