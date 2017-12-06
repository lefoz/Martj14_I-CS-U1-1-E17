using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LotteryCore.LotteryDataPresistence
{
    class FileUpStream
    {
        private readonly string _serielNumberFileName = "SerielNumbers.dat";
        private readonly string _submissionsFileName = "SerielNumbers.dat";
        private readonly string _loginsFileName = "SerielNumbers.dat";

        public List<string> LoadSerielNumbersFromFile()
        {
            //Dictionary<string, bool> serielDictionary = new Dictionary<string, bool>();
            string line = "";
            List<string> serielNum = new List<string>();
            using (StreamReader streamReader = new StreamReader(_serielNumberFileName))
            {
              while ((line = streamReader.ReadLine()) != null)
              {
                      serielNum.Add(line);
              }
            }
            return serielNum;
        }

        public void SaveSubmissionsToFile(Dictionary<string, bool> submissions)
        {
            using (StreamReader streamReader = new StreamReader(_submissionsFileName))
            {
                foreach (KeyValuePair<string, bool> kvp in submissions)
                {
                   
                }
            }
        }

        public void SaveLoginsToFile(Dictionary<string, bool> logins)
        {
            using (StreamReader streamReader = new StreamReader(_loginsFileName))
            {
                foreach (KeyValuePair<string, bool> kvp in logins)
                {
                    
                }
            }
        }
    }
}
