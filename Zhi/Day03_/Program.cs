using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1<int> list = new Class1<int>();
            list.r = 2;

            Class1<string> listString = new Class1<string>();
            listString.r = "2";

            Class1<int[]> listShu = new Class1<int[]>();
            listShu.r = new int[3];


            Class1<Dog> listDog= new Class1<Dog>();
            listDog.r = new Dog();

            Class1<Dictionary<string, Dog>> listDogDog = new Class1<Dictionary<string, Dog>>();


        }
    }
}
