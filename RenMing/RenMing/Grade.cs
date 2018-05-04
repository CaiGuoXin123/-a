using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenMing
{

  public  class Grade
    {                 

      public  List<Student> list = new List<Student>();

        
      
        public void  AddButton()
        {

            Student stu1 = new Student();
            stu1.StuName1 = "李小龙";
            list.Add(stu1);

            Student stu2 = new Student();
            stu2.StuName1 = "梁小龙";
            list.Add(stu2);

            Student stu3 = new Student();
            stu3.StuName1 = "陈惠敏";
            list.Add(stu3);

            Student stu4 = new Student();
            stu4.StuName1 = "李连杰";
            list.Add(stu4);

            Student stu5 = new Student();
            stu5.StuName1 = "甄子丹";
            list.Add(stu5);

            Student stu6 = new Student();
            stu6.StuName1 = "刘家辉";
            list.Add(stu6);
         }
        public void DisplayStudent()
        {
           
        }
    }
}
