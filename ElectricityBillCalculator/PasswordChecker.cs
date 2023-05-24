﻿using Org.BouncyCastle.Crypto.Tls;

namespace ElectricityBillCalculator
{
    public enum PasswordStrength
    {
        Length = 12, UpperCase = 10, LowerCase = 9, Symbol = 11, Digit = 8, NotCommon = 50
    }
    internal class PasswordChecker
    {
        Dictionary<PasswordStrength, bool> Conditions;
        Dictionary<PasswordStrength, string> Suggestions;

        public PasswordChecker()
        {
            Conditions = new Dictionary<PasswordStrength, bool>();
            Suggestions = new Dictionary<PasswordStrength, string>();
            Suggestions.Add(PasswordStrength.UpperCase, "Add Uppercase Character.");
            Suggestions.Add(PasswordStrength.LowerCase, "Add Lowercase Character.");
            Suggestions.Add(PasswordStrength.Symbol, "Add Special Character.");
            Suggestions.Add(PasswordStrength.Digit, "Add Number.");
            Suggestions.Add(PasswordStrength.Length, "Password must have a minimum length of 8.");
            Suggestions.Add(PasswordStrength.NotCommon, "Password is common. Try a more complicated one.");
        }

        internal bool IsStrong(string password, out string message)
        {
            message = string.Empty;
            setPasswordStrengths(password);
            return checkPasswordScore(ref message);
        }

        private bool checkPasswordScore(ref string message)
        {
            int passwordScore = 0;
            foreach(var strength in Conditions)
            {
                if(strength.Value)
                {
                    passwordScore += (int)strength.Key;
                }
            }

            if(passwordScore <= 50)
            {
                message = "Password is in the common list. Probably easy to crack";
                return false;
            }

            if(passwordScore > 50 && passwordScore < 60)
            {
                message = "Password is very weak. \n" +additionalSuggestions();
                return false;
            }

            if (passwordScore >= 60 && passwordScore < 70)
            {
                message = "Password is weak. \n" + additionalSuggestions();
                return false;
            }

            if (passwordScore >= 70 && passwordScore < 80)
            {
                message = "Password is medium. \n" + additionalSuggestions();
                return false;
            }

            if (passwordScore >= 80 && passwordScore <= 90)
            {
                message = "Password is strong. \n" + additionalSuggestions();
                return false;
            }

            return true;
        }

        private void setPasswordStrengths(string password)
        {
            Conditions.Clear();
            setPasswordStrengths(PasswordStrength.Length, password.Length > 8);
            setPasswordStrengths(PasswordStrength.UpperCase, password.Any(char.IsUpper));
            setPasswordStrengths(PasswordStrength.LowerCase, password.Any(char.IsLower));
            setPasswordStrengths(PasswordStrength.Symbol, password.Any(c => !char.IsLetterOrDigit(c)));
            setPasswordStrengths(PasswordStrength.Digit, password.Any(char.IsDigit));
            setPasswordStrengths(PasswordStrength.NotCommon, !passwordExists(password));
        }

        private bool passwordExists(string password)
        {
            IEnumerable<string> lines = File.ReadLines("commonpass.txt");
            foreach(string line in lines)
            {
                if (password == line)
                    return true;
            }
            return false;
        }

        private void setPasswordStrengths(PasswordStrength strength, bool IsSatisfied)
        {
            Conditions[strength] = IsSatisfied;
        }

        private string additionalSuggestions()
        {
            string additionalSuggestions = string.Empty;
            foreach(var strength in Conditions)
            {
                if(!strength.Value)
                {
                    additionalSuggestions += "\n" + Suggestions[strength.Key];
                }
            }
            return additionalSuggestions;
        }
    }
}