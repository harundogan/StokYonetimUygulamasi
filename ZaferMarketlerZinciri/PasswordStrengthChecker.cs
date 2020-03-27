﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ZaferMarketlerZinciri
{
    public class PasswordStrengthChecker
    {
        private int GetLengthScore(string password)
        {
            return Math.Min(10, password.Length);
        }

        private int GetLowerScore(string password)
        {
            int rawScore = password.Length - Regex.Replace(password, "[a-z]", "").Length;
            return Math.Min(2, rawScore) * 5;
        }

        private int GetUpperScore(string password)
        {
            int rawScore = password.Length - Regex.Replace(password, "[A-Z]", "").Length;
            return Math.Min(2, rawScore) * 8;
        }

        private int GetDigitScore(string password)
        {
            int rawScore = password.Length - Regex.Replace(password, "[0-9]", "").Length;
            return Math.Min(2, rawScore) * 10;
        }

        private int GetSymbolScore(string password)
        {
            int rawScore = password.Length - Regex.Replace(password, "[^a-zA-Z0-9]", "").Length;
            return Math.Min(2, rawScore) * 15;
        }

        public int GeneratePasswordScore(string password)
        {
            if (password == null)
                return 0;

            int lengthScore = GetLengthScore(password);
            int lowerScore = GetLowerScore(password);
            int upperScore = GetUpperScore(password);
            int digitScore = GetDigitScore(password);
            int symbolScore = GetSymbolScore(password);

            return lengthScore + lowerScore + upperScore + digitScore + symbolScore;
        }
    }
}
