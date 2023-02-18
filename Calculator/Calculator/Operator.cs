using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
    public class Operator
    {
        public static string Operate(string math)
        {
            bool resultOne = Regex.IsMatch(math.Trim(), @"(?i)^[a-z’'+\-\\//*x\s-]+$");
            if (resultOne == true)
            {
                return math.ToUpper();
            }  
            else
            {
                return " ";
            }    
           

        }
    }
}
