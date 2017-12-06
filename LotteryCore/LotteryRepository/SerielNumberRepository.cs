using System;
using System.Collections.Generic;
using System.Text;

namespace LotteryCore.LotteryRepository
{
    class SerielNumberRepository
    {
        private Dictionary<string, bool> _lotteryDictionary = new Dictionary<string, bool>();

        public void GenerateNewSerielNumbers(int amount)
        {
            ISerielNumberGenereter newGenereter = new SerielNumberGenereter();
            _lotteryDictionary = newGenereter.GenerateSerielNumberDictionary(amount);
        }


        public bool SerielNumbersFromFile()
        {
            //_lotteryDictionary = 
            return false;

        }


        public bool SerielNumbersToFile()
        {
            //_lotteryDictionary = 
            return false;

        }
        /// <summary>
        /// Checks Dictionary for serielnumber
        /// If Dictionary contains serielnumber, its value reprencents if this serielnumber has been submitted
        /// If true = unsubmitted return, value is set to false and the method returns 2
        /// If false = already submitted and the method returns 1
        /// If the Dictionary do not contain serielnumber the method returns 0  
        /// </summary>
        /// <param name="serielnumber"></param>
        /// <returns></returns>
        public int LookUpSerielNumber(string serielnumber)
        {
            int lookUpConfirmation = 0;
            if (_lotteryDictionary.ContainsKey(serielnumber))
            {
                if (_lotteryDictionary[serielnumber].Equals(true))
                {
                    _lotteryDictionary[serielnumber] = false;
                    lookUpConfirmation = 2;
                    return lookUpConfirmation;
                }
                else
                {
                    lookUpConfirmation = 1;
                    return lookUpConfirmation;
                }
            }
            return lookUpConfirmation;
        }

    }
}
