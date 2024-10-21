using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public string MaskCreditCard(string input)
        {
            string[] parts = input.Split(' ');
            string MaskedCC = "";
            string output = "";
            string seperator = " ";
            bool CCFound = false;
            foreach (string part in parts)
            {
                if (part.Length == 19 && part[4] == '-' && part[9] == '-' && part[14] == '-' && !(part.Contains(' ')))
                {
                    CCFound = true;
                    MaskedCC = "XXXX-XXXX-XXXX-" + part[15] + "" + part[16] + "" + part[17] + "" + part[18];
                    output = output + MaskedCC + seperator;
                }
                else
                {
                    output = output + part + seperator;
                }

            }
            if (CCFound == false)
            {
                output = "Please enter your correct credit card number in the format XXXX-XXXX-XXXX-XXXX with no blank spaces.";
            }
            return output;
        }
        public string MaskSocialSecurity(string input)
        {
            string[] parts = input.Split(' ');
            string separator = " ";
            string MaskInput = "";
            bool SSNFound = false;

            foreach (string part in parts)
            {
                if (part.Length == 11 && part[3] == '-' && part[6] == '-' && !(part.Contains(' ')))
                {
                    SSNFound = true;
                    //Console.Write("XXX-" + part[4] + "" + part[5] + "-XXXX");
                    MaskInput = MaskInput + "XXX-" + part[4] + "" + part[5] + "-XXXX ";
                }
                else
                {
                    MaskInput = MaskInput + part + separator;
                    //Console.Write(part + separator);
                }
            }
            //Console.WriteLine("");
            if (!SSNFound)
            {
                MaskInput = "Please enter your correct social security number in the format XXX-XX-XXXX with no blank spaces.";
            }
            return MaskInput;
        }
        public string MaskData(string input)
        {
            string MaskCCOutput = MaskCreditCard(input);
            string MaskCCnSSNOutput = MaskSocialSecurity(MaskCCOutput);

            return MaskCCnSSNOutput;
        }
    }
}
