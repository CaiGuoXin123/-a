using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmMoShou0
{
   public class LoginInfo
    {
        private static string Name;

        public static string Name1
        {
            get { return Name; }
            set { Name = value; }
        }
        private static string Id;

        public static string Id1
        {
            get { return Id; }
            set { Id = value; }
        }
        private static string Email;

        public static string Email1
        {
            get { return LoginInfo.Email; }
            set { LoginInfo.Email = value; }
        }
        private static string Password;

        public static string Password1
        {
            get { return Password; }
            set { Password = value; }
        }
        private static string pwd11;

        public static string Pwd11
        {
            get { return pwd11; }
            set { pwd11 = value; }
        }
        private static string ema11;

        public static string Ema11
        {
            get { return ema11; }
            set { ema11 = value; }
        }

    }
}
