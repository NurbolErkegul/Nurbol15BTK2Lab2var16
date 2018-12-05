using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment2
    {
        //Функция работает так: Мы задаем два значения(имя Парня и имя Девушки),если имя парня имеет больше букв чем у 
        //девушки или ровняется с ней то они оба попадает в Массив"Любви" если нет то вместо парня попадает в массив следующяя фраза-"Do not have Cool Name"
        public string[] LoveDuo(string BoyFriend, string GirlFriend)
        {
            string[] LOVEDUOS = new string[2];
            if (BoyFriend.Length >= GirlFriend.Length)
            {
                LOVEDUOS[0] = BoyFriend;
                LOVEDUOS[1] = GirlFriend;
            }
            else
            {
                LOVEDUOS[0] = "Do not have Cool Name";
                LOVEDUOS[1] = GirlFriend;
            }
            return LOVEDUOS;
        }
    }
}
