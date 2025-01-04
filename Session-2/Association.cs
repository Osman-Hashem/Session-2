using System.Net;

namespace Session_2
{

    class Library 
    {
        public string Name { get; set; }

        public Book[] Books { get; set; }
    }



    class Book
    {
        public string Title { get; set; }

        public string Code { get; set; }

        public Author Author { get; set; }

    }

    class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }


    }


}
