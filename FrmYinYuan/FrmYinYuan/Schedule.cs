using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FrmYinYuan
{
   public class Schedule
    {
        private Dictionary<string, ScheduleItem> items = new Dictionary<string, ScheduleItem>();

        public Dictionary<string, ScheduleItem> Items
        {
            get { return items; }
            set { items = value; }
        }
        public void LoadItems()
        {
            
            XmlDocument myXml = new XmlDocument();
            myXml.Load("ShowList.xml");
            XmlNode root = myXml.DocumentElement;
            foreach (XmlNode item in root.ChildNodes)
            {
                Movie movie = new Movie();
                movie.Moviename = item["Name"].InnerText;
                movie.Poster = item["Poster"].InnerText;
                movie.Directer = item["Director"].InnerText;
                movie.Actor = item["Actor"].InnerText;
                movie.MovieType=(MovieType)Enum.Parse(typeof(MovieType),item["Type"].InnerText);
                movie.Price = Convert.ToInt32(item["Price"].InnerText);
                foreach (XmlNode schedule in item["Schedule"].ChildNodes)
                {
                    ScheduleItem sItem = new ScheduleItem();
                    sItem.Time = schedule.InnerText;
                    sItem.Movie = movie;
                    items.Add(sItem.Time, sItem);
                }
            }
        }
    }
}
