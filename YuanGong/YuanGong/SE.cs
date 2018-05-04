using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuanGong
{
    
    public class SE
    {
        private string ID;  //工号

        public string ID1
        {
            get { return ID; }
            set { ID = value; }
        }
        private string Name;  //姓名

        public string Name1
        {
            get { return Name; }
            set { Name = value; }
        }
        private int Age;        //年龄

        public int Age1
        {
            get { return Age; }
            set { Age = value; }
        }
        private string Sex; //性别

        public string Sex1
        {
            get { return Sex; }
            set { Sex = value; }
        }
    }
    public enum Gender
    {
        男, 女
    }
}
