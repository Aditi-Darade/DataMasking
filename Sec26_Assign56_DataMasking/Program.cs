using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec26_Assign56_DataMasking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine(class1.MaskCreditCard("My credit card number is 1234-5678-9012-3456"));
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine(class1.MaskCreditCard("1234-5678-9012-345"));
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine(class1.MaskCreditCard("My credit card number is 1234-567 -9012-3456"));
            Console.WriteLine("-------------------------------------------------------------------------------");

            Console.WriteLine(class1.MaskSocialSecurity("My social security number is 123-47-6 89"));
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine(class1.MaskSocialSecurity("My social security number is 123-47-6789"));
            Console.WriteLine("-------------------------------------------------------------------------------");

            Console.WriteLine(class1.MaskData("My credit card number is 1234-5678-9012-3456 and my social security number is 123-47-6789"));
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine(class1.MaskData("My credit card number is 1234-5678-9012-3456 and my social security number is 1 3-47-6789"));
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine(class1.MaskData("My credit card number is 1234-5678-9012-3456 and my social security number is 123-47-6789"));

            Console.ReadKey();
        }
    }
}
