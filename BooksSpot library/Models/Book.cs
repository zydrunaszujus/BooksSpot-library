namespace BooksSpot_library.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publishing { get; set; }
        public DateOnly Date{get;set;}
        public long ISBNCode { get;set;}
       
    } 
        
}
