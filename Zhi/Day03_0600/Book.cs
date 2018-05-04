using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_0600
{
    class Book
    {
        public string BookName { get; set; }

        public int BookPrcion { get; set; }
        public override string ToString()
        {
            return this.BookName;
        }
    
    }
}
