using System;
using System.Linq;

namespace AdditionalTask
{
    internal class Dictionary
    {
        private string[] rusArray = new string[5];
        private string[] engArray = new string[5];
        private string[] ukrArray = new string[5];

        public Dictionary()
        {
            rusArray[0] = "книга"; engArray[0] = "book"; ukrArray[0] = "книга";
            rusArray[1] = "ручка"; engArray[1] = "pen"; ukrArray[1] = "ручка";
            rusArray[2] = "солнце"; engArray[2] = "sun"; ukrArray[2] = "сонце";
            rusArray[3] = "яблоко"; engArray[3] = "apple"; ukrArray[3] = "яблоко";
            rusArray[4] = "стол"; engArray[4] = "table"; ukrArray[4] = "стіл";
        }

        public string this[string inputWord]
        {
            get
            {
                if (rusArray.Contains(inputWord))
                {
                    int index = Array.IndexOf(rusArray, inputWord);
                    return $"RUS: {rusArray[index]} -> ENG: {engArray[index]}; UKR: {ukrArray[index]}.";
                }
                else if (engArray.Contains(inputWord))
                {
                    int index = Array.IndexOf(engArray, inputWord);
                    return $"ENG: {engArray[index]} -> RUS: {rusArray[index]}; UKR: {ukrArray[index]}.";
                }
                else if (ukrArray.Contains(inputWord))
                {
                    int index = Array.IndexOf(ukrArray, inputWord);
                    return $"UKR: {ukrArray[index]} -> RUS: {rusArray[index]}; ENG: {engArray[index]}.";
                }
                else
                    return $"WORD \"{inputWord}\" not found :(";
            }
        }
    }
}
