using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment3
    {
        public CentralFunction SORTINGHAT(string WizardName)
        {
            if (WizardName.Length > 0)
            {
                if (WizardName == "Harry")
                {
                    return new Gryffindor();
                }
                if (WizardName == "Kandydi")
                {
                    return new Kogtevran();
                }

                if (WizardName == "Penelopa")
                {
                    return new Puffenduy();
                }

                else
                {
                    return new Slyzerin();
                }
            }
            else
            {
                return new OutTest();
            }
        }
    }
    public class CentralFunction
    {

    }

    public class Gryffindor : CentralFunction
    {

    }

    public class Kogtevran : CentralFunction
    {

    }

    public class Puffenduy : CentralFunction
    {

    }

    public class Slyzerin : CentralFunction
    {

    }
    public class OutTest : CentralFunction
    {

    }
}
