using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleReadingApp
{
    internal static class ExtensionMethod
    {
        public static string AppendExtensionMethod(this int inputInteger)
        {
            string appendString = "BBDs";
            try
            {
                if (inputInteger.Equals(55))
                {
                    appendString += Convert.ToString(inputInteger);
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return appendString;
        }
    }
}
