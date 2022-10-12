using System;

namespace BooksSpot_library.Models
{
    public enum Status
    {
        available,
        reserve,
        borrow
    }
    public class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Status BookStatus { get; set; }
        public DateTime PicUp { get; set; }
        public DateTime Return { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
        public List<User> Users { get; set; } = new List<User>();
       


    }
}
