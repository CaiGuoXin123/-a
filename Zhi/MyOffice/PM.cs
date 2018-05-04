using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOffice
{
    public class PM
    {
        public int id;             //id
        public int age;            //年龄
        public string name;        //姓名
        public string sex;         //性别
        public string zili;        //资历

        public void Judge(PM se, String zili, int score)
        {
            se.zili = zili;
            se.age = score;
        }
    }
}
