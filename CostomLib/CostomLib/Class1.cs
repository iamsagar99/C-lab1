using System;
using System.Windows;

namespace CostomLib
{
    public class Class1
    {
        public static string lastFirst(string firstName, string lastName)
        {
            string separator = ", ";
            string result = lastName + separator + firstName;
            return result;
        }
    }
}
