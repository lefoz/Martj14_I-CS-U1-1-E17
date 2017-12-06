using System;
using System.Collections.Generic;
using System.IO;


namespace TestApp
{
    class Program
    {
        private readonly string[] _serielLetters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        private Random _random;
        private int _amountOfSerielNumbers { get; set; }
        private readonly string _serielNumberFileName = "SeNumTest.dat";


        public Dictionary<string, bool> GenerateSerielNumberDictionary(int amount)
        {
            Dictionary<string, bool> _serielDictionary = new Dictionary<string, bool>();
            _random = new Random();
            _amountOfSerielNumbers = amount;
            while (_serielDictionary.Count<100)
            {
                string serielnumber = _serielLetters[_random.Next(0, 26)] + _random.Next(0, 10) + _random.Next(0, 10) +
                                      _random.Next(0, 10);
                if (!_serielDictionary.ContainsKey(serielnumber))
                {
                    _serielDictionary.Add(serielnumber, true);
                }
            }
            return _serielDictionary;
        }

        public void SaveSerielNumbersToFile(Dictionary<string, bool> serielnumbers)
        {
            using (StreamWriter streamWriter = new StreamWriter(_serielNumberFileName))
            {
                foreach (KeyValuePair<string, bool> kvp in serielnumbers)
                {
                    string save = kvp.Key + ";" + kvp.Value;
                    streamWriter.WriteLine(save);
                }
            }
            Console.WriteLine("saved to file!");
        }

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
        static void Main(string[] args)
        {
            Program p = new Program();
            Dictionary<string, bool> testDic = new Dictionary<string, bool>();
            List<string> test = new List<string>();
            testDic = p.GenerateSerielNumberDictionary(100);
            foreach (KeyValuePair<string,bool> kvp in testDic)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                
            }
            Console.WriteLine(testDic.Count);
           

            p.SaveSerielNumbersToFile(testDic);
            

            test = p.LoadSerielNumbersFromFile();
            foreach (var item in test)
            {
                Console.WriteLine(item); 
            }
            Console.ReadKey();
        }
    }
}
