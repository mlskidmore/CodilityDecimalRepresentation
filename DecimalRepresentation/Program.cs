using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalRepresentation
{
    public class Program
    {
        public static int findDecimalRepresenation(int subStr, int mainStr)
        {
            // Check if A and B are in [0...999,999,999]
            if ( (subStr >= 0 && subStr <= 999999999) && (mainStr >= 0 && mainStr <= 999999999))
            {
                if (subStr == 0 && mainStr == 0)
                {
                    Console.WriteLine(subStr + " and " + mainStr +" have no length.");
                    return 0;
                }
                // Make sure A < B
                if (subStr < mainStr)
                {                    
                    // Convert A and B to strings
                    string a = subStr.ToString();
                    string b = mainStr.ToString();
                    int index = 0;

                    // See if A is a substring of B
                    if (b.Contains(a))
                    {
                        // Find index where A is
                        if (b.IndexOf(a) != -1)
                        {                            
                            while ((index = b.IndexOf(a, index)) != -1)
                            {
                                Console.WriteLine(subStr + " found at position " + index);
                                index++;
                            }
                            //Console.ReadLine();
                            return b.IndexOf(a);
                        }
                        else
                            return -1;
                    }
                    else
                    {
                        Console.WriteLine(subStr + " is not in " + mainStr + ".");
                        Console.ReadLine();

                        return -1;
                    }
                }
                else
                {
                    Console.WriteLine(subStr + " must be less than " + mainStr + ".");
                   // Console.ReadLine();

                    return -1;
                }                
            }
            else
            {
                Console.WriteLine(subStr + " or " + mainStr + " is out of range.");
                //Console.ReadLine();

                return -1;
            }
        }
        
        public static void Main(string[] args)
        {
            int A = 53, B = 1953786;
            int C = 78, D = 195378678;
            int E = 57, F = 153786;

            findDecimalRepresenation(A, B);
            findDecimalRepresenation(C, D);
            findDecimalRepresenation(E, F);

            Console.WriteLine();
        }
    }
}
