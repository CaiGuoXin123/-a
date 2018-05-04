using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOffice
{
      public  class SE
    {
        private int id;           //工号

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;      //姓名

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;          //年龄

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string jinping;      //评分

        public string Jinping
        {
            get { return jinping; }
            set { jinping = value; }
        }
        private int deifen;    //得分

        public int Deifen
        {
            get { return deifen; }
            set { deifen = value; }
        }
         
    }
}
