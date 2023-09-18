namespace LibraryApp
{
    public class BookLib
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }

        public BookLib(string title, string author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }
    }
}