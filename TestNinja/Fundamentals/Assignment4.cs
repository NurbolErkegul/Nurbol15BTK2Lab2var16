using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment4
    {
        public double LuckyNumber { get; set; }

        public void LUCKYNUMBERS(double MyNumber)
        {
            if (MyNumber > 6 && MyNumber<13)
            {
                LuckyNumber = MyNumber;
            }
            else
            {
                LuckyNumber = 666;
            }

            
        }
    }
}
