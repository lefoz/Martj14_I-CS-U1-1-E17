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
        private readonly string _serielNumberFileName = "SerielNumbers.dat";
        private readonly string _loginsFileName = "Logins.dat";


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

        public bool SerielNumbersFromFile(Dictionary<string, bool> _lotteryDictionary)
        {

            List<string> serielnumbers = LoadSerielNumbersFromFile();
            foreach (var item in serielnumbers)
            {
                string seriel = item.Substring(0, 4);
                string value = item.Substring(5);
                _lotteryDictionary.Add(seriel, Convert.ToBoolean(value));

            }
            if (_lotteryDictionary.Count > 99) return true;
            return false;
        }

        public void SaveLoginsToFile(string email, string password)
        {
            using (StreamWriter streamWriter = new StreamWriter(new FileStream(_loginsFileName, FileMode.Append)))
            {

                string save = email + "|" + password;
                streamWriter.WriteLine(save);

            }
        }

        [Serializable]
        public class Salesman
        {
            public string name, address, email;
            public int sales;

            public Salesman(string name, string adr, string email, int sale)
            {
                this.name = name;
                this.address = adr;
                this.email = email;
                this.sales = sale;
            }
        }

   
        static void Main(string[] args)
        {
            //Program p = new Program();
            //p.SaveLoginsToFile("admin","admin");
            //Dictionary<string, bool> testDic = new Dictionary<string, bool>();
            //List<string> test = new List<string>();
            //testDic = p.GenerateSerielNumberDictionary(100);
            //foreach (KeyValuePair<string, bool> kvp in testDic)
            //{
            //    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);

            //}
            //Console.WriteLine(testDic.Count);


            //p.SaveSerielNumbersToFile(testDic);


            //test = p.LoadSerielNumbersFromFile();
            //foreach (var item in test)
            //{
            //    Console.WriteLine(item); 
            //}
            //Console.ReadKey();
            //testDic.Clear();
            //Console.WriteLine(p.SerielNumbersFromFile(testDic));
            //foreach (KeyValuePair<string, bool> kvp in testDic)
            //{
            //    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);

            //}
            //Console.WriteLine(testDic.Count);
            //Console.ReadKey();

            //Logins
            //List<string> stringList = new List<string>();
            //stringList.Add("eeeee|ppppp");
            //stringList.Add("xxxx|zzzzzzz");
            //foreach (var item in stringList)
            //{
            //    int d = item.IndexOf("|");
            //    Console.WriteLine(item.Substring(0,d));
            //    Console.WriteLine(item.Substring(d+1));
            //}
            //Console.ReadKey();

            //List<Submission> submissionList = new List<Submission>();
            //string serializationFile = Path.Combine("Submissions.bin");
            //List<Salesman> salesmanreturn;

            //serialize
            //using (Stream stream = File.Open(serializationFile, FileMode.Create))
            //{
            //    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

            //    bformatter.Serialize(stream, submissionList);
            //}

            //deserialize
            //using (Stream stream = File.Open(serializationFile, FileMode.Open))
            //{
            //    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

            //    salesmanreturn = (List<Salesman>)bformatter.Deserialize(stream);
            //}
            //foreach (var item in salesmanreturn)
            //{
            //    Console.WriteLine(item.name+" "+item.address+" "+item.email+" "+item.sales);
            //}
            //Console.ReadKey();

        }
    }
}
