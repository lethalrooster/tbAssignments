using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tbAssignments
{
    class Program
    {
        //static bool ValidateWithControlNumber(string socialSecurityNumber)
        //{
        //    string s = socialSecurityNumber.Replace('-', '\0');

        //    int[] intssc = new int[] { s[0], s[1], s[2], s[3], s[4], s[5], s[6], s[7], s[9] };
        //    int[] multipliers = new int[] { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
        //    List<int> result = new List<int>();

        //    for (int i = 0; i < intssc.Length; i++)
        //    {
        //        int sum = intssc[i] * multipliers[i];

        //    }



        //    int lastNumber = (10 - (sum % 10)) % 10;

        //    return true;
        //}

        //static bool ValidateSSC(string socialSecurityNumber)
        //{
            
        //    if (socialSecurityNumber.Length != 13 && socialSecurityNumber.Length != 11)
        //    {
        //        return false;
        //    }

        //    ValidateWithControlNumber(socialSecurityNumber);

        //    return true;
        //}

        /// <summary>Check if person, from given social security number (in format <c>yyyymmdd-xxxx</c>) is older than given value </summary>
        /// <returns>True if age older than given value and false if age less than given value</returns>
        static bool IsOlderThanMinAge(string socialSecurityNumber, int minAge)
        {

            DateTime thisDay = DateTime.Today;
            DateTime newDat = thisDay.AddYears(-minAge);

            //string[] splittedssn = socialSecurityNumber.Split(new char[] { '-' });

            int year = int.Parse(socialSecurityNumber.Substring(0, 4));
            int month = int.Parse(socialSecurityNumber.Substring(4, 2));
            int day = int.Parse(socialSecurityNumber.Substring(6, 2));

            DateTime sscDate = new DateTime(year, month, day);
            
            if (newDat.CompareTo(sscDate) >= 0)
            {
                return true;
            }

            return false;
        }   

        static void Main(string[] args)
        {
            int minAge = 2;

            Console.WriteLine($"Skriv in personens personnummer (yyyymmdd-xxxx), för att kontrollera om personen får köpa. (Lägsta ålder är: {minAge})");
            //string socialSecurityNumber = Console.ReadLine();
            if (IsOlderThanMinAge("20181117-XXXX", minAge))
            {
                Console.WriteLine($"Personen är äldre än {minAge}");
            }
            else
            {
                Console.WriteLine($"Personen är yngre än {minAge}");
            }
        }
    }
}
