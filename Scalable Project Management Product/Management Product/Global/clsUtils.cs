using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Product.Global
{
    public class clsUtils
    {
        static char[] symbols = { '#', '&', '@' };

        static Random rand = new Random();

        static int RandomNumber(int from, int to)
        {
            return rand.Next(from, to + 1);
        }

        //function 1 : random (LetterUperCase)
        static string UperLetters(int NumberOfUperLetter)
        {
            string result = string.Empty;

            for (int i = 0; i < NumberOfUperLetter; i++)
            {
                result += $"{(char)RandomNumber(65, 90)}";
            }
            return result;
        }

        //function 2 : random (LetterLowerCase)
        static string LowLetters(int NumberOfLowLetter)
        {
            string result = "";

            for (int i = 0; i < NumberOfLowLetter; i++)
            {
                result += $"{(char)RandomNumber(97, 122)}";
            }

            return result;
        }

        //function 3 : random (number)
        static string Numbers(int NumberOfNumbers)
        {
            string number = string.Empty;

            for(int i = 0; i < NumberOfNumbers; i++)
            {
                number += $"{RandomNumber(0, 9)}";
            }

            return number;
        }

        //function 4 : random (sumbol)
        static string Symboles(int NumberOfSymbols)
        {
            string result = string.Empty;

            for (int i = 0; i < NumberOfSymbols; i++)
            {
                result += $"{symbols[RandomNumber(0, 2)]}";
            }

            return result;
        }

        public static string EncryptText(string text, short encryptionKey)
        {
            char[] encryptedChars = text.ToCharArray();

            for (int i = 0; i < encryptedChars.Length; i++)
            {
                encryptedChars[i] = (char)(encryptedChars[i] + encryptionKey);
            }

            return new string(encryptedChars);
        }

        public static string DecryptText(string text, short encryptionKey)
        {
            char[] decryptedChars = text.ToCharArray();

            for (int i = 0; i < decryptedChars.Length; i++)
            {
                decryptedChars[i] = (char)(decryptedChars[i] - encryptionKey);
            }

            return new string(decryptedChars);
        }


        public static string GeneratePassword()
        {
            return ($"{UperLetters(1)}{Numbers(4)}{Symboles(2)}");
        }
    }
}
