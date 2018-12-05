using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment5
    {
        public string SystemName { get; set; }

        public void SystemRUN(string WordForOutSystem)
        {
            if (string.IsNullOrWhiteSpace(WordForOutSystem))
                throw new ArgumentNullException();

            SystemName = WordForOutSystem;
        }
    }
}
