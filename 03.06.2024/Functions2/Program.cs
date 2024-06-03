using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
using System.Text;

namespace Functions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "heYder";
            string lastName = "alizade";
            string domain = "gmail.com";


            string formatName = ConverToCapitalLetter(firstName);
            string formatLastName = ToUpperLetter(lastName);

        string newEmail = $"{formatName}.{formatLastName}@{domain}";

            Console.WriteLine(newEmail);

            //ToUpperLetter(firstName);
        }

        public static string ConverToCapitalLetter(string firstName)
        {
            char firstletter = firstName[0];
            string formattedName = "";

            for (int i = 0; i < firstName.Length; i++)
            {
                if (i == 0)
                {
                    if ((char)firstName[i] >= 65 && (char)firstName[i] <= 90)
                    {
                        formattedName = formattedName + (char)(firstName[i]);
                    }

                    else if ((char)firstName[i] >= 97 && (char)firstName[i] <= 122)
                    {
                        formattedName = formattedName + (char)(firstName[i] - 32);
                    }
                }
                else
                {
                    if ((char)firstName[i] >= 65 && (char)firstName[i] <= 90)
                    {
                        formattedName = formattedName + (char)(firstName[i] + 32);
                    }

                    else
                    {
                        formattedName = formattedName + (char)(firstName[i]);
                    }
                }
            }
            Console.WriteLine(formattedName);
            return formattedName;
        }

        public static string ChangeSymb(string str, char oldSymb, char newSymb)
        {
            string formattedName = "";

            for (int i = 0; i < str.Length; i++)
            {
                if ((char)str[i] == oldSymb)
                {
                    formattedName = formattedName + (newSymb);
                }
                else
                {
                    formattedName = formattedName + str[i];

                }
            }
            Console.WriteLine(formattedName);

            return str;
        }

        public static string ToUpperLetter(string str)
        {
            string formattedName = "";

            for (int i = 0; i < str.Length; i++)
            {
                if ((char)str[i] >= 65 && (char)str[i] <= 90)
                {
                    formattedName = formattedName + (char)(str[i]);
                }

                else if ((char)str[i] >= 97 && (char)str[i] <= 122)
                {
                    formattedName = formattedName + (char)(str[i] - 32);
                }
            }
            Console.WriteLine(formattedName);
            return formattedName;
        }

    }
}
