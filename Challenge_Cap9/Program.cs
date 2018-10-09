using System;
using System.Text.RegularExpressions;

namespace Challenge_Cap9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValid = true;

            do
            {
                Console.WriteLine("Email:");
                string value = Console.ReadLine();
                isValid = value.EmailIsValid();
                if (!isValid)
                    Console.WriteLine("Invalid!");
                Console.WriteLine();

            } while (!isValid);

            do
            {
                Console.WriteLine("Phene Number:");
                string value = Console.ReadLine();
                isValid = value.PhoneNumberIsValid();
                if (!isValid)
                    Console.WriteLine("Invalid!");
                Console.WriteLine();

            } while (!isValid);

            do
            {
                Console.WriteLine("Date of Birty:");
                string value = Console.ReadLine();
                isValid = value.DateBirthIsValid();
                if (!isValid)
                    Console.WriteLine("Invalid!");
                Console.WriteLine();

            } while (!isValid);

            do
            {
                Console.WriteLine("Zip Code(BR):");
                string value = Console.ReadLine();
                isValid = value.BrZipCodeIsValid();
                if (!isValid)
                    Console.WriteLine("Invalid!");
                Console.WriteLine();

            } while (!isValid);

            do
            {
                Console.WriteLine("Website:");
                string value = Console.ReadLine();
                isValid = value.WebSiteIsValid();
                if (!isValid)
                    Console.WriteLine("Invalid!");
                Console.WriteLine();

            } while (!isValid);


        }
    }


    public static class ExtensionForValidateInput
    {
        public static bool EmailIsValid(this string value)
        {
            string pattern = @"^\w+[a-zA-Z0-9]+([-._][a-z0-9]+)*@([a-z0-9]+)\.\w{2,4}";
            return Regex.IsMatch(value, pattern);
        }

        public static bool PhoneNumberIsValid(this string value)
        {
            string pattern = @"^(\([0-9]{2}\))\s([9]{1})?([0-9]{4})-([0-9]{4})$";
            return Regex.IsMatch(value, pattern);
        }

        public static bool DateBirthIsValid(this string value)
        {
            string pattern = @"^\d{2}-\d{2}-\d{4}";
            return Regex.IsMatch(value, pattern);
        }

        public static bool BrZipCodeIsValid(this string value)
        {

            string pattern = @"\d{5}[-]\d{3}";
            return Regex.IsMatch(value, pattern);
        }

        public static bool WebSiteIsValid(this string value)
        {
            //Retirado da internet - não atende todos os cenários.
            string pattern = @"^http(s)?://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$";
            return Regex.IsMatch(value, pattern);
        }
    }



}
