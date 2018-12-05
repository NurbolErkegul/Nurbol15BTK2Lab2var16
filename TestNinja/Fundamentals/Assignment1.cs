using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment1
    {
        // Funkcia rabotaet: esli slovo ili hotyabi bukva prisvoena "UserWord" To Vivoditsa samo slovo, esli "UserWord" 
        //pusto to viveditsa zaranee napisannaya fraza "Vvedite volshebnoe slovo"

            // Velikoe eto prostoe,ya sdelala etu funkciu dlya vievlenie est li text ili hotyabi bukva
        public string TestTheWordOfLength(string UserWord)
        {
            
            if ( UserWord.Length > 0)
            {
                return $"<>{UserWord}</>";

            }
            else
            {
                return "<>Введите волшебное слово!</>";
            }
        }
    }
}
