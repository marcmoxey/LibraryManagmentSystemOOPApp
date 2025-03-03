using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
   public  class MemberModel
    {
        public string Name { get; set; }
        public string MemberID { get; set; }
        public List<BookModel> BorrowedBooks { get; set; }
    }
}
