using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day07_0300界面
{
   public class Instrument    //父类
    {
     

       //public   Instrument (){}

       //public Instrument(int id, string name, int age, Gender gender, int renqi)
       // {
       //     this.Id=id;
       //     this.Name=name;
       //     this.Age=age;
       //     this.Gender = gender;
       //     this.Renqi = renqi;
       // }


       public virtual void Play()
       {
           MessageBox.Show("乐器在演奏","信息!",MessageBoxButtons.OK,MessageBoxIcon.Information);

       }

    }
}
