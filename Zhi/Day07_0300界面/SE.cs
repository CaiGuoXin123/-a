using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_0300界面
{
    public  class SE:Instrument  //程序员类
    {

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private Gender gender;

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private int renqi;

        public int Renqi
        {
            get { return renqi; }
            set { renqi = value; }
        }


        public SE() { }
        public SE(int id, string name, int age, Gender male, int renqi)
           // : base(id, name, age, male, renqi)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Gender = male;
            this.Renqi = renqi;
        }

      
        public void Play(Instrument instrument)
        {
            instrument.Play();

        }
    }
}
