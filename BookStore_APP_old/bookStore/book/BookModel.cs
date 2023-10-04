using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookStore.book
{
    public class BookModel
    {
        public string? BookID { get; set; }
        public string? BookName { get; set; }
        public string? Author { get; set; }
        public string? Description { get; set; }
        public int Edition { get; set; }
    }
}
