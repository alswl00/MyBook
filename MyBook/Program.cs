using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    class Program
    {
            class Book
        {
            public string title;
            public string first_edition;
            public string author;
            public string publisher;
            public string publishing_house;
            public string responsible_editor;
            public string planner;
            public string editor;
            public string designer;
        }
        static void Main(string[] args)
        {
            Book book = new Book()
            { 
                title = "PHP프로그래밍 입문", first_edition = "2013년 5월 20일", 
                author = "황재호", publisher = "김태헌", publishing_house = "한빛아카데미(주)", 
                responsible_editor = "김현용", planner = "김이화", editor = "김이화", 
                designer = "여동일" 
            };
        }
    }
}
