namespace LibraryApp.Book
{
    public class LibraryCatalog
    {
        private List<BookLib> bookscatalog = new();

        public void AddBook(BookLib book)
        {
            bookscatalog.Add(book);
        }

        public void RemoveBook(BookLib book)
        {
            bookscatalog.Remove(book);
        }
    }
}
