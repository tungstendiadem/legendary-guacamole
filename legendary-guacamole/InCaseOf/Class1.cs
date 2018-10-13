using System;

namespace InCaseOf
{
    public class caseDeterminer
    {

        // We either know the input type or do not. We need to know the output type.
        private string CompareKnown (string inputType, string outputType, string inputString )
        {
            throw new NotImplementedException();
        }

        private string CompareUnknown   (string outputType, string inputString)
        {
            throw new NotImplementedException();
        }

        public bool CaseEquivalent (string inputString)
        {
             return inputString == inputString.ToLower() && inputString == inputString.ToUpper();
        }

        // Since we are going to use these for finding an index in a string to change maybe bool isn't the best.
        // Of course two different methods might be appropos
        public bool ContainsUnderscore (string InputString)
        {
            return InputString.Contains("_");
        }

        public bool ContainsHyphen(string InputString)
        {
            return InputString.Contains("-");
        }

        public string Wakawaka (string outputType, string inputString, string endString)
        {
            string currentChar = inputString.Substring(0, 1);
            var n = 1;
            // We need to think of the different types. There might be more than snake with "_"
            if (currentChar == "_" && outputType != "snake") { n += 1; currentChar = ""; };
            if (currentChar == "-" && outputType != "kebab") { n += 1; currentChar = ""; };

            endString += currentChar;
            if (inputString.Length == 1) { return endString; }
            else { Wakawaka(outputType, inputString.Substring(n), endString); }


        }
    }
}
