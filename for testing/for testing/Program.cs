using System;
using System.Collections.Generic;

namespace for_testing
{
    class Program
    {

        private static string DecodeMessage(string[] lines)
        {
            List<string> spisokSlov = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                if ((lines[i] == "") || (lines[i] == null)) 
                    continue;

                string[] linesWithoutSpace = lines[i].Split(" ");

                for (int j = 0; j < linesWithoutSpace.Length; j++)
                {
                    string s = linesWithoutSpace[j];

                    if (char.IsUpper(s[0]))
                        spisokSlov.Add(s);
                }


            }

            string stroka = "";

            spisokSlov.Reverse();

            foreach (var e in spisokSlov)
                stroka += e + " ";

            Console.WriteLine(stroka);
            return stroka;

        }
        public static void Main()
        {
            DecodeMessage(new string[] {    "решИла нЕ Упрощать и зашифРОВАтЬ Все послаНИЕ",
                                            "дАже не Старайся нИЧЕГО у тЕбя нЕ получится с расшифРОВкой",
                                            "Сдавайся НЕ твоего ума Ты не споСОбЕн Но может быть",
                                            "если особенно упорно подойдешь к делу",
                                            "",
                                            "будет Трудно конечнО",
                                            "Код ведЬ не из простых",
                                            "очень ХОРОШИЙ код",
                                            "то у тебя все получится",
                                            "и я буДу Писать тЕбЕ еще",
                                            "",
                                            "чао"});
        }

    }
}
