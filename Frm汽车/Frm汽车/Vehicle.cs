using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frm汽车
{
   public class Vehicle
    {
       private string Color;//颜色

        public string Color1
        {
       get { return Color; }
       set { Color = value; }
         }
        private double DailyRent;

        public double DailyRent1//日租金
        {
            get { return DailyRent; }
            set { DailyRent = value; }
        }
        private string LicenseNO; 

        public string LicenseNO1//车牌号
        {
            get { return LicenseNO; }
            set { LicenseNO = value; }
        }
        private string Name;//车名

        public string Name1
        {
            get { return Name; }
            set { Name = value; }
        }
        private int RentDate;//使用时间

        public int RentDate1
        {
            get { return RentDate; }
            set { RentDate = value; }
        }
        private int RentUser; //使用人

        public int RentUser1
        {
            get { return RentUser; }
            set { RentUser = value; }
        }
        private int YearsOfService;//服务年限; 

        public int YearsOfService1
        {
            get { return YearsOfService; }
            set { YearsOfService = value; }
        }
        public Vehicle() { }
        public Vehicle(string color,double dailyrent,string licenseno,string name,int rentdate)
        {
            this.Color1 = color;
            this.DailyRent1 = dailyrent;
            this.LicenseNO1 = licenseno;
            this.Name1 = name;
            this.RentDate1 = rentdate;
            //this.RentUser1 = rentuser;
          
        }
    }
}
