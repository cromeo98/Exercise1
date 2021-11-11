using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentYear = DateTime.Now.Year;

            string fiscalCode;

            //get user fiscalcode
            Console.WriteLine("Inserisci il tuo codice fiscale");
            fiscalCode = Console.ReadLine();
            //Console.WriteLine(fiscalCode);

            //normalize
            fiscalCode = fiscalCode.ToUpper();

            //set correct length
            int correctLength;
            correctLength = 16;

            //verify user fiscal code length
            int fiscalCodeLength = fiscalCode.Length;

            //while length is incorrect ask for input fiscalcode
            if (fiscalCodeLength == correctLength)
            {
                Console.WriteLine("La lunghezza è giusta");
            }
            else
            {
                while (fiscalCodeLength != correctLength)
                {
                    Console.WriteLine("La lunghezza è sbagliata, riprova");
                    fiscalCode = Console.ReadLine();
                    fiscalCodeLength = fiscalCode.Length;
                }
                //Console.WriteLine("La lunghezza è corretta");
            };

            //get year
            string year;
            year = fiscalCode.Substring(6, 2);
            //Console.WriteLine(year);

            int yearNumber = int.Parse(year);

            if (yearNumber < 21)
            {
                yearNumber = int.Parse(year) + 2000;
            }
            else
            {
                yearNumber = int.Parse(year) + 1900;
            };

            //get age
            int age = currentYear - yearNumber;

            Console.WriteLine("L'età è: " + age);
            Console.WriteLine("L'anno di nascita è: " + year);

            //get month
            string month = fiscalCode.Substring(8, 1);
            //Console.WriteLine(month);

            //switch to get month from letter of fiscalcode
            string monthOfBirth = "";

            switch (month)
            {
                case "A":
                    monthOfBirth = "Gennaio";
                    break;
                case "B":
                    monthOfBirth = "Febraury";
                    break;
                case "C":
                    monthOfBirth = "March";
                    break;
                case "D":
                    monthOfBirth = "April";
                    break;
                case "E":
                    monthOfBirth = "May";
                    break;
                case "H":
                    monthOfBirth = "June";
                    break;
                case "L":
                    monthOfBirth = "July";
                    break;
                case "M":
                    monthOfBirth = "August";
                    break;
                case "P":
                    monthOfBirth = "September";
                    break;
                case "R":
                    monthOfBirth = "October";
                    break;
                case "S":
                    monthOfBirth = "November";
                    break;
                case "T":
                    monthOfBirth = "December";
                    break;
                default:
                    Console.WriteLine("Il mese non è corretto");
                    break;
            }

            Console.WriteLine("Il mese di nascita è: " + monthOfBirth);

            //rmocrs98e25f205f

            string day = fiscalCode.Substring(9, 2);
            int dayAsNum = int.Parse(day);

            int dayOfBirth = 0;
            string gender = "";

            if (dayAsNum > 0 && dayAsNum <= 31)
            {
                dayOfBirth = dayAsNum;
                gender = "M";
                Console.WriteLine("Il giorno di nascita è: " + dayOfBirth);
                Console.WriteLine("Il sesso è: " + gender);
            }
            else if (dayAsNum >= 40 && dayAsNum <= 71)
            {
                dayOfBirth = dayAsNum - 40;
                gender = "F";
                Console.WriteLine("Il giorno di nascita è: " + dayOfBirth);
                Console.WriteLine("Il sesso è: " + gender);
            }
            else
            {
                Console.WriteLine("Il giorno di nascita non è corretto");
            }
        }
    }
}
