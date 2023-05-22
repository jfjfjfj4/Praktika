using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
   public class Class1
    {

        public bool A(string dl,string shr)
        {
            double gdl = Convert.ToDouble(dl);
            double gshr = Convert.ToDouble(shr);
            string res = "";

            if (gdl < 0 || gshr < 0)
            {
                res = "No";
            }
            else res = "Yes";
            

            return false==res.Contains("No");
        }

        public bool B(string dl, string shr)
        {
            

            string res = "";

            if (dl=="" || shr=="" )
            {
                res = "No";
            }
            else res = "Yes";

            return (true == res.Contains("No"));
        }
    }
}
