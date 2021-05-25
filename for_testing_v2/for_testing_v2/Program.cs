using System;
using System.Collections.Generic;
using System.Threading;

namespace listOfEmails
{
    class Program
    {

        private static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
        {

            var dictionary = new Dictionary<string, List<string>>();

            foreach (var e in contacts)
            {
                string[] parsedString = new string[2];
                var listOfMails = new List<string>();
                string name, email;
                
                parsedString = e.Split(":");
                email = parsedString[1];

                if (parsedString[0].Length >= 2)
                    name = parsedString[0].Substring(0, 2);
                else
                    name = parsedString[0].Substring(0, 1);

                listOfMails.Add(parsedString[1]);

                if (name.Length == 1)
                {
                    if (!dictionary.ContainsKey(name))
                        dictionary.Add(name, listOfMails);
                    else
                        dictionary[name].Add(email);
                }

                else if (name.Length >= 2)
                {
                    if (!dictionary.ContainsKey(name))
                        dictionary.Add(name, listOfMails);
                    else
                        dictionary[name].Add(email);
                }
            }

            return dictionary;
        }

        static void Main()
        {


            OptimizeContacts(new List<string> { "AB:ABasss@gmail",
                                                "BC:BCdadsads@yandex",
                                                "CDE:CDE@mail",
                                                "ABBA:ABBAsdasdds@rambler",
                                                "CDKL:CDKLsdasd@mail",
                                                "BCFT:BCFTsddasd@yandex",
                                                });





        }
    }
}
