using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Asignment
{
    public class PrimeMinister {
        string PrimeMinisterName;
        int PrimeMinisterYear;

        public string Name
        {
            get { return PrimeMinisterName; }
            set { PrimeMinisterName = value; }
        }

        public int Year
        {
            get { return PrimeMinisterYear; }
            set { PrimeMinisterYear = value; }
        }
        public override string ToString()
        {
            return "PrimeMinisterName:-" + Name + " " + "Year:-" + Year;
        }
        public PrimeMinister(string name,int year)
        {
           this.Name = name;
           this.Year = year;
        }
    }
    class Program
    {
        static Dictionary<string, PrimeMinister> obj = new Dictionary<string, PrimeMinister>();
        static void Main(string[] args)
        {
            DictionaryInit();

            Console.WriteLine("Prime Minister in 2004:- Manmohan Singh");
            

            Console.WriteLine("\nAfter Added :-");
            obj["forth"] = new PrimeMinister("Narendra Modi",2014);
            foreach (var primeMini in obj.Values)
                Console.WriteLine(primeMini);
            Console.WriteLine("\nReadOnly:-");
            var ReadOnly = new ReadOnlyDictionary<string, PrimeMinister>(obj);
            foreach (var primeMini in ReadOnly.Values)
                Console.WriteLine(primeMini);


            Console.WriteLine("\nSorted:-");
            obj = obj.OrderBy(r => r.Value.Year).ToDictionary(r => r.Key, r => r.Value);
            foreach (var primeMini in obj.Values)
                Console.WriteLine(primeMini);
            
        }

        public static void DictionaryInit()
        {
            obj.Add("First", new PrimeMinister("Atal Bihari Vajpayee", 1998));
            obj.Add("second", new PrimeMinister("Narendra Modi", 2014));
            obj.Add("third", new PrimeMinister("Manmohan Singh", 2004));
        }
    }
}  
