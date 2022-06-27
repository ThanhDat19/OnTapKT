using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OnTapKT
{
    public class Rule_Regex
    {
        public Regex Email_Regex = new Regex(@"[^a-zA-Z0-9{@.}]|([\s])");
        public Regex UserNam_Regex = new Regex(@"[^a-zA-Z0-9{]|([\s])");
        public Regex Name_Regex = new Regex(@"([^\w\s])|([0-9])");
        public Regex Address_Regex = new Regex(@"[^\w\s0-9\{/.()}]");
        public Regex Number_Regex = new Regex(@"([^0-9])");
        public Regex Describe_Regex = new Regex(@"([^\w\s^0-9{,.% }])");
        public string MobileNumer_String = @"^([0])?[1-9][0-9]{8}$";
        public Regex Name_Product_Regex = new Regex(@"([^\w\s0-9])");
        public bool IsPhoneNbr(string number)
        {
            if (number != null) return Regex.IsMatch(number, MobileNumer_String);
            else return false;
        }
    }
}
