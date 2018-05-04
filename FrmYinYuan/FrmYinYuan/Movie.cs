using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmYinYuan
{
    public enum MovieType  //枚举类型
    {
        //喜剧
        Comedy,
        //战争
        War,
        //爱情
        Romance,
        //动作
        Action,
        //卡通
        Cartoon,
        //恐怖
        Thriller,
        //冒险
        Adventure


    }
  public  class Movie //电影类
    {
        private string moviename;   //电影名

        public string Moviename
        {
            get { return moviename; }
            set { moviename = value; }
        }
        private string poster;   //海报图片名

        public string Poster
        {
            get { return poster; }
            set { poster = value; }
        }
        private string directer;  //导演名

        public string Directer
        {
            get { return directer; }
            set { directer = value; }
        }
        private string actor;  //主演

        public string Actor
        {
            get { return actor; }
            set { actor = value; }
        }
        private MovieType movieType;  //电影类型

        public MovieType MovieType
        {
            get { return movieType; }
            set { movieType = value; }
        }
        private int price;  //定价

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public Movie()
        {

        }
        public Movie(string moviename,string poster,string director,string actor,MovieType movietype,int price)
        {
            this.Moviename = moviename;
            this.Poster = poster;
            this.Directer = director;
            this.Actor = actor;
            this.MovieType = movietype;
            this.Price = price;
        }
    }
}
